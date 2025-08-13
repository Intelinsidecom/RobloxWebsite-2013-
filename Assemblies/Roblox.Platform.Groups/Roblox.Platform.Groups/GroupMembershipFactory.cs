using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public class GroupMembershipFactory : IGroupMembershipFactory
{
	private readonly GroupDomainFactories _DomainFactories;

	private readonly IUserFactory _UserFactory;

	public GroupMembershipFactory(GroupDomainFactories domainFactories, IUserFactory userFactory)
	{
		if (domainFactories == null)
		{
			throw new ArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public virtual IGroupMembership Get(IGroup group, IUser user)
	{
		group.VerifyIsNotNull();
		IGroupRoleSet roleSet = group.GetGroupRoleSetByUserId(user);
		return new GroupMembership(user, group, roleSet, _DomainFactories);
	}

	/// <summary>
	/// Note that user can still be null
	/// </summary>
	public virtual IGroupMembership CheckedGet(IUser user, long groupId)
	{
		IGroup group = _DomainFactories.GroupFactory.CheckedGetById(groupId);
		return Get(group, user);
	}

	public virtual IGroupMembership Get(IGroup group, long? userId)
	{
		group.VerifyIsNotNull();
		IUser user = (userId.HasValue ? _UserFactory.GetUser(userId.Value) : null);
		return Get(group, user);
	}

	public virtual IGroupMembership CheckedGet(long groupId, long? userId)
	{
		IGroup group = _DomainFactories.GroupFactory.CheckedGetById(groupId);
		IUser user = (userId.HasValue ? _UserFactory.GetUser(userId.Value) : null);
		return Get(group, user);
	}

	private IEnumerable<IGroupMembership> CheckedMultiGet(ICollection<UserGroup> userGroups, IUser user)
	{
		if (userGroups == null)
		{
			throw new ArgumentNullException("userGroups");
		}
		if (userGroups.Count == 0)
		{
			yield break;
		}
		long[] roleSetIds = userGroups.Select((UserGroup ug) => ug.RoleSetID).ToArray();
		IReadOnlyCollection<IGroupRoleSet> roleSets = _DomainFactories.GroupRoleSetAccessor_Internal.MultiGet(roleSetIds);
		Dictionary<long, IGroupRoleSet> groupIdToRoleSetMapping = roleSets.ToDictionary((IGroupRoleSet roleSet) => roleSet.GroupId, (IGroupRoleSet roleSet) => roleSet);
		foreach (UserGroup userGroup in userGroups)
		{
			IGroup group = _DomainFactories.GroupFactory.CheckedGetById(userGroup.GroupID);
			groupIdToRoleSetMapping.TryGetValue(userGroup.GroupID, out var roleSet2);
			yield return new GroupMembership(user, group, roleSet2, _DomainFactories);
		}
	}

	public virtual IEnumerable<IGroupMembership> GetGroupMembershipsByUser(IUser user)
	{
		user.VerifyIsNotNull();
		ICollection<UserGroup> userGroupEntities = UserGroup.GetUserGroupsByUserID(user.Id);
		if (Settings.Default.IsMultiGetGroupRoleSetsForGetGroupMembershipsByUserEnabled)
		{
			return CheckedMultiGet(userGroupEntities, user);
		}
		return userGroupEntities.Select((UserGroup userGroupEntity) => CheckedGet(user, userGroupEntity.GroupID));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Groups.IGroupMembershipFactory.GetDevelopmentGroupMembershipsByUser(Roblox.Platform.Membership.IUser)" />
	public virtual ICollection<IGroupMembership> GetDevelopmentGroupMembershipsByUser(IUser user)
	{
		user.VerifyIsNotNull();
		List<IGroupMembership> developmentGroups = (from gm in GetGroupMembershipsByUser(user)
			where gm.RoleSet.HasPermission(GroupRoleSetPermissionType.CanManageGroupGames)
			select gm).ToList();
		UserGroup primaryGroup = PrimaryUserGroup.GetByUserID(user.Id);
		IGroupMembership primaryGroupMembership = ((primaryGroup != null) ? developmentGroups.FirstOrDefault((IGroupMembership gm) => gm.Group.Id == primaryGroup.GroupID) : null);
		if (primaryGroupMembership != null)
		{
			int primaryGroupIndex = developmentGroups.IndexOf(primaryGroupMembership);
			developmentGroups.RemoveAt(primaryGroupIndex);
			developmentGroups.Insert(0, primaryGroupMembership);
		}
		return developmentGroups;
	}
}
