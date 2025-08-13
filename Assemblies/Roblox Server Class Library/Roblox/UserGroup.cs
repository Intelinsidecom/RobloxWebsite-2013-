using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.Caching.Interfaces;
using Roblox.DataV2.Core;
using Roblox.Groups.Client;
using Roblox.Locking;
using Roblox.Properties;

namespace Roblox;

public class UserGroup : IEquatable<UserGroup>
{
	private static IGroupsClient _InjectedGroupsClient = null;

	private static readonly IGroupsClient _UncachedGroupsClient = (IGroupsClient)new GroupsClient((Func<string>)(() => Settings.Default.GroupsClientApiKey), (IRequestCache)null);

	[DataObjectField(true, true)]
	public long ID { get; private set; }

	[DataObjectField(false)]
	public long UserID { get; set; }

	[DataObjectField(false, false, false)]
	public long GroupID { get; set; }

	[DataObjectField(false, false, false)]
	public long RoleSetID { get; set; }

	[DataObjectField(false, false, false)]
	public bool IsTopGroup { get; set; }

	[DataObjectField(false)]
	public DateTime Created { get; private set; }

	[DataObjectField(false)]
	public DateTime Updated { get; private set; }

	public static IGroupsClient GroupsClient
	{
		get
		{
			return _InjectedGroupsClient ?? _UncachedGroupsClient;
		}
		set
		{
			_InjectedGroupsClient = value;
		}
	}

	public void Delete()
	{
		LeasedLock decrementLock = LeasedLock.GetOrCreate($"TryDecrementGroupCounter, UserGroup:{ID}");
		GroupsClient.RemoveUserFromGroup(UserID, GroupID);
		if (decrementLock.TryAcquire(ParallelTaskWorker.ID, 5000))
		{
			GroupCounter.GetOrCreate(GroupID, GroupCounterType.MembersID).TryDecrement();
			decrementLock.TryRelease(ParallelTaskWorker.ID);
		}
	}

	public void Save()
	{
		bool num = ID == 0;
		GroupMembershipModel model;
		if (num)
		{
			model = GroupsClient.AddUserToGroup(UserID, GroupID, RoleSetID);
			ID = model.Id;
		}
		else
		{
			model = GroupsClient.UpdateGroupMembership(UserID, GroupID, RoleSetID, IsTopGroup);
		}
		Created = model.Created;
		Updated = model.Updated;
		if (num)
		{
			GroupCounter.GetOrCreate(GroupID, GroupCounterType.MembersID).Increment();
		}
	}

	public static void Delete(long userId, long groupId)
	{
		Get(userId, groupId)?.Delete();
	}

	public static UserGroup Get(long userId, long groupId)
	{
		return FromClientModel(GroupsClient.GetGroupMembership(userId, groupId));
	}

	public static ICollection<UserGroup> GetUserGroupsByGroupIDAndRoleSetIDPaged(long groupId, long roleSetId, int startRowIndex, int maximumRows)
	{
		return GroupsClient.GetGroupMembershipsByGroupIdAndRoleSetIdPaged(groupId, roleSetId, startRowIndex, maximumRows).Select(FromClientModel).ToList();
	}

	public static ICollection<UserGroup> GetUserGroupsByGroupIdAndRoleSetId(long groupId, long roleSetId, long? exclusiveStartId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		GroupMembershipModel exclusiveStartObject = GetExclusiveStartClientModel(exclusiveStartId);
		return GroupsClient.GetGroupMembershipsByGroupIdAndRoleSetIdEnumerative(groupId, roleSetId, count, exclusiveStartObject, ToApiSortOrder(sortOrder)).Select(FromClientModel).ToList();
	}

	public static ICollection<UserGroup> GetUserGroupsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		return GroupsClient.GetGroupMembershipsByGroupIdPaged(groupId, startRowIndex, maximumRows).Select(FromClientModel).ToList();
	}

	public static ICollection<UserGroup> GetUserGroupsByUserID(long userId)
	{
		return GroupsClient.GetGroupMembershipsByUserId(userId).Select(FromClientModel).ToList();
	}

	public static ICollection<UserGroup> GetTopUserGroupsByUserIDPaged(long userId, int startRowIndex, int maximumRows)
	{
		return GroupsClient.GetTopGroupMembershipsByUserIdPaged(userId, startRowIndex, maximumRows).Select(FromClientModel).ToList();
	}

	public static int GetTotalNumberOfUserGroupsByGroupID(long groupId)
	{
		if (groupId != 0L)
		{
			return GroupsClient.GetGroupMembershipCountByGroupId(groupId);
		}
		return 0;
	}

	public static int GetTotalNumberOfUserGroupsByUserID(long userId)
	{
		return GroupsClient.GetGroupMembershipCountByUserId(userId);
	}

	public static int GetTotalNumberOfUserGroupsByGroupIDAndRoleSetID(long groupId, long roleSetId)
	{
		return GroupsClient.GetGroupMembershipCountByGroupIdAndRoleSetId(groupId, roleSetId);
	}

	public bool Equals(UserGroup other)
	{
		return ID == other?.ID;
	}

	private static UserGroup FromClientModel(GroupMembershipModel model)
	{
		if (model != null)
		{
			return new UserGroup
			{
				RoleSetID = model.RoleSetId,
				UserID = model.UserId,
				GroupID = model.GroupId,
				Created = model.Created,
				ID = model.Id,
				IsTopGroup = model.IsTopGroup,
				Updated = model.Updated
			};
		}
		return null;
	}

	private static Roblox.ApiClientBase.SortOrder ToApiSortOrder(Roblox.DataV2.Core.SortOrder sortOrder)
	{
		return sortOrder switch
		{
			Roblox.DataV2.Core.SortOrder.Asc => Roblox.ApiClientBase.SortOrder.Asc, 
			Roblox.DataV2.Core.SortOrder.Desc => Roblox.ApiClientBase.SortOrder.Desc, 
			_ => throw new InvalidEnumArgumentException(), 
		};
	}

	private static GroupMembershipModel GetExclusiveStartClientModel(long? legacyId)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (!legacyId.HasValue)
		{
			return null;
		}
		return new GroupMembershipModel
		{
			Id = legacyId.Value
		};
	}
}
