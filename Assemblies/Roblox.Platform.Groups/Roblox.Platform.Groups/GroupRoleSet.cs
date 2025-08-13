using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Groups.Entities.GroupRoleSets;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />
/// </summary>
/// <seealso cref="T:Roblox.Platform.Groups.IGroupRoleSet" />
internal class GroupRoleSet : IGroupRoleSet
{
	private readonly GroupDomainFactories _DomainFactories;

	private readonly IUserFactory _UserFactory;

	private const byte GuestRank = 0;

	private const byte OwnerRank = byte.MaxValue;

	public long Id { get; }

	public long GroupId { get; }

	public string Name { get; set; }

	public string Description { get; set; }

	public byte Rank { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Groups.GroupRoleSet" /> class.
	/// </summary>
	/// <param name="entity">The <see cref="T:Roblox.Platform.Groups.Entities.GroupRoleSets.IGroupRoleSetEntity" />.</param>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the <paramref name="entity" /> or <paramref name="domainFactories" /> is null.</exception>
	public GroupRoleSet(IGroupRoleSetEntity entity, GroupDomainFactories domainFactories)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		_DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
		_UserFactory = _DomainFactories.UserFactory;
		Id = entity.Id;
		GroupId = entity.GroupId;
		Name = entity.Name;
		Description = entity.Description;
		Rank = entity.Rank;
	}

	public bool IsGuest()
	{
		return Rank == 0;
	}

	public bool IsOwner()
	{
		return Rank == byte.MaxValue;
	}

	public bool HasPermission(GroupRoleSetPermissionType permission)
	{
		IGroup group = _DomainFactories.GroupFactory.GetById(GroupId);
		if (group == null || group.IsLocked())
		{
			return false;
		}
		return GetAllPermissionTypes().Contains(permission);
	}

	public IEnumerable<GroupRoleSetPermissionType> GetAllPermissionTypes()
	{
		IGroupRoleSetEntity groupRoleSetEntity = _DomainFactories.GroupRoleSetEntityFactory.GetById(Id);
		IEnumerable<IGroupRoleSetPermissionEntity> permissionEntities = _DomainFactories.GroupRoleSetPermissionEntityFactory.GetAllPermissionsByGroupRoleSetId(groupRoleSetEntity.Id);
		IList<IGroupRoleSetPermissionEntity> groupRoleSetPermissionEntities = (permissionEntities as IList<IGroupRoleSetPermissionEntity>) ?? permissionEntities.ToList();
		LazyUpdate_TopRolesetHasAllPermissions(groupRoleSetEntity, groupRoleSetPermissionEntities);
		return groupRoleSetPermissionEntities.Select((IGroupRoleSetPermissionEntity permissionEntity) => _DomainFactories.GroupRoleSetPermissionTypeConverter.GetTypeById(permissionEntity.RoleSetPermissionTypeId)).Where(delegate(GroupRoleSetPermissionType? permissionType)
		{
			GroupRoleSetPermissionType? groupRoleSetPermissionType2 = permissionType;
			return groupRoleSetPermissionType2.HasValue;
		}).Select(delegate(GroupRoleSetPermissionType? permissionType)
		{
			GroupRoleSetPermissionType? groupRoleSetPermissionType = permissionType;
			return groupRoleSetPermissionType.Value;
		})
			.ToList();
	}

	public int GetTotalNumberOfUsersInRoleSet()
	{
		return UserGroup.GetTotalNumberOfUserGroupsByGroupIDAndRoleSetID(GroupId, Id);
	}

	public IPlatformPageResponse<long, IUser> GetUsersInRoleSet(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (exclusiveStartKeyInfo.Count < 0 || exclusiveStartKeyInfo.Count > Settings.Default.GroupMembershipsPageLimit)
		{
			throw new ArgumentOutOfRangeException("exclusiveStartKeyInfo", "ExclusiveStartKeyInfo Count is out of range");
		}
		ICollection<UserGroup> userGroups = UserGroup.GetUserGroupsByGroupIdAndRoleSetId(GroupId, Id, exclusiveStartKeyInfo.GetNullableExclusiveStartKey(), exclusiveStartKeyInfo.Count + 1, exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(SortOrder.Asc) ? SortOrder.Asc : SortOrder.Desc);
		ICollection<IUser> users = new List<IUser>();
		Dictionary<long, long> userGroupMap = new Dictionary<long, long>();
		if (Settings.Default.IsUserFactoryMultiGetEnabled)
		{
			long[] userIds = userGroups.Select((UserGroup ug) => ug.UserID).ToArray();
			IReadOnlyDictionary<long, IUser> usersDictionary = _UserFactory.MultiGetUsers(userIds);
			foreach (UserGroup userGroup2 in userGroups)
			{
				long userId = userGroup2.UserID;
				userGroupMap[userId] = userGroup2.ID;
				users.Add(usersDictionary[userId]);
			}
		}
		else
		{
			foreach (UserGroup userGroup in userGroups)
			{
				userGroupMap[userGroup.UserID] = userGroup.ID;
				users.Add(_UserFactory.GetUser(userGroup.UserID));
			}
		}
		return new PlatformPageResponse<long, IUser>(users.ToArray(), exclusiveStartKeyInfo, (IUser u) => userGroupMap[u.Id]);
	}

	public IPlatformPageResponse<long, long> GetUserIdsInRoleSet(IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo)
	{
		if (exclusiveStartKeyInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartKeyInfo");
		}
		if (exclusiveStartKeyInfo.Count < 0 || exclusiveStartKeyInfo.Count > Settings.Default.GroupMembershipsPageLimit)
		{
			throw new ArgumentOutOfRangeException("exclusiveStartKeyInfo", "ExclusiveStartKeyInfo Count is out of range");
		}
		ICollection<UserGroup> userGroupsByGroupIdAndRoleSetId = UserGroup.GetUserGroupsByGroupIdAndRoleSetId(GroupId, Id, exclusiveStartKeyInfo.GetNullableExclusiveStartKey(), exclusiveStartKeyInfo.Count + 1, exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(SortOrder.Asc) ? SortOrder.Asc : SortOrder.Desc);
		List<long> userIds = new List<long>();
		Dictionary<long, long> userGroupMap = new Dictionary<long, long>();
		foreach (UserGroup userGroup in userGroupsByGroupIdAndRoleSetId)
		{
			userGroupMap[userGroup.UserID] = userGroup.ID;
			userIds.Add(userGroup.UserID);
		}
		return new PlatformPageResponse<long, long>(userIds.ToArray(), exclusiveStartKeyInfo, (long userId) => userGroupMap[userId]);
	}

	private void LazyUpdate_TopRolesetHasAllPermissions(IGroupRoleSetEntity groupRoleSetEntity, IEnumerable<IGroupRoleSetPermissionEntity> groupRoleSetPermissionEntities)
	{
		if (groupRoleSetEntity.Rank != byte.MaxValue || groupRoleSetPermissionEntities.Count() >= Enum.GetValues(typeof(GroupRoleSetPermissionType)).Length)
		{
			return;
		}
		foreach (Roblox.GroupRoleSetPermissionType type in Roblox.GroupRoleSetPermissionType.GetAllPermissions())
		{
			GroupRoleSetPermission.GetOrCreate(groupRoleSetEntity.Id, type);
		}
	}
}
