using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using Roblox.Common;
using Roblox.Data;
using Roblox.EphemeralCounters;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Groups.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Counters;
using Roblox.Platform.Groups.Events;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.Platform.PremiumFeatures.Interfaces;
using Roblox.PremiumFeatures.Implementation;
using Roblox.PremiumFeatures.Interfaces;
using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

public static class GroupManagement
{
	public class TargetUserJson
	{
		public long TargetId { get; set; }
	}

	public class InitiatorUserJson
	{
		public long InitiatorId { get; set; }
	}

	public class DeletePostJson
	{
		public string PostDesc { get; set; }

		public long TargetId { get; set; }
	}

	public class TextJson
	{
		public string Text { get; set; }
	}

	public class ChangeRankJson
	{
		public long TargetId { get; set; }

		public long OldRoleSetId { get; set; }

		public long NewRoleSetId { get; set; }
	}

	public class AdJson
	{
		public string AdName { get; set; }

		public int Bid { get; set; }

		public int? CurrencyTypeId { get; set; }
	}

	public class AssetJson
	{
		public long AssetId { get; set; }
	}

	public class SpendGroupFundsJson
	{
		public long Amount { get; set; }

		public int CurrencyTypeId { get; set; }

		public string ItemDescription { get; set; }
	}

	public class RelationshipJson
	{
		public long TargetGroupId;
	}

	public class RenameGroupJson
	{
		public long InitiatorId { get; set; }

		public string NewName { get; set; }
	}

	public class ChangeDescriptionJson
	{
		public long InitiatorId { get; set; }

		public string NewDescription { get; set; }
	}

	public class AdjustCurrencyAmountJson
	{
		public int CurrencyType { get; set; }

		public long InitiatorId { get; set; }

		public long Amount { get; set; }
	}

	public class ChangeGroupOwnerJson
	{
		public long? OldOwnerId { get; set; }

		public long? NewOwnerId { get; set; }

		public long InitiatorId { get; set; }

		public bool IsRoblox { get; set; }
	}

	public class CreateUpdateGroupAssetJson
	{
		public long AssetId { get; set; }

		public long VersionNumber { get; set; }

		public long? RevertVersionNumber { get; set; }
	}

	public class SavePlaceJson
	{
		public long AssetId { get; set; }

		public long VersionNumber { get; set; }
	}

	public class PublishPlaceJson
	{
		public long AssetId { get; set; }

		public long VersionNumber { get; set; }
	}

	public class ConfigureGroupAssetJson
	{
		public long AssetId { get; set; }

		public ConfigureGroupAssetAction[] Actions { get; set; }

		public ConfigureGroupAssetJson(long assetId, bool nameChanged = false, bool descChanged = false, bool disabledBadge = false)
		{
			AssetId = assetId;
			List<ConfigureGroupAssetAction> actions = new List<ConfigureGroupAssetAction>();
			if (nameChanged)
			{
				actions.Add(ConfigureGroupAssetAction.Rename);
			}
			if (descChanged)
			{
				actions.Add(ConfigureGroupAssetAction.ChangeDescription);
			}
			if (disabledBadge)
			{
				actions.Add(ConfigureGroupAssetAction.DisableBadge);
			}
			Actions = actions.ToArray();
		}

		public ConfigureGroupAssetJson()
		{
			new List<ConfigureGroupAssetAction>();
		}
	}

	public enum ConfigureGroupAssetAction
	{
		Rename,
		ChangeDescription,
		DisableBadge,
		DeactivatePlace,
		ActivatePlace,
		ChangedSettings,
		EnableBadge
	}

	public class ConfigureGroupGameJson
	{
		public long TargetId { get; set; }

		public GroupDevelopmentItemType Type { get; set; }

		public long? UniverseId { get; set; }

		public ConfigureGroupGameAction[] Actions { get; set; }

		public ConfigureGroupGameJson()
		{
		}

		public ConfigureGroupGameJson(long universeId, bool changeName, bool changeDescription, bool changeApiAccess)
		{
			TargetId = universeId;
			Type = GroupDevelopmentItemType.Universe;
			List<ConfigureGroupGameAction> actions = new List<ConfigureGroupGameAction>();
			if (changeName)
			{
				actions.Add(ConfigureGroupGameAction.ChangeName);
			}
			if (changeDescription)
			{
				actions.Add(ConfigureGroupGameAction.ChangeDescription);
			}
			if (changeApiAccess)
			{
				actions.Add(ConfigureGroupGameAction.UniverseChangeApiAccess);
			}
			Actions = actions.ToArray();
		}
	}

	public enum ConfigureGroupGameAction
	{
		Configure,
		ChangeName,
		ChangeDescription,
		UniverseSetRootPlace,
		UniverseUnrootPlace,
		UniverseAddPlace,
		UniverseRemovePlace,
		UniverseChangeApiAccess
	}

	public enum GroupDevelopmentItemType
	{
		DeveloperProduct,
		Universe
	}

	public class CreateUpdateGamePassJson
	{
		public long GamePassId;

		public long PlaceId;
	}

	private static readonly JavaScriptSerializer _Serializer = new JavaScriptSerializer();

	private static string _JoinGroupCounterName = "JoinGroup_Success";

	private const string _ReadOnlyModeError = "Group memberships are in read-only mode.";

	private static readonly IAccountAddOnFactory AccountAddOnFactory = new AccountAddOnFactory();

	private static int GroupDescriptionMaxCharacterCount => Settings.Default.GroupDescriptionMaxCharacterCount;

	private static bool IsGroupJoinPremiumValidationEnabled => Settings.Default.IsGroupJoinPremiumValidationEnabled;

	/// Gets *
	[Obsolete("Use userids overload")]
	public static ICollection<User> GetUsersByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		ICollection<User> users = new List<User>();
		foreach (UserGroup item in UserGroup.GetUserGroupsByGroupIDPaged(groupId, startRowIndex, maximumRows))
		{
			User u = User.Get(item.UserID);
			if (u != null)
			{
				users.Add(u);
			}
		}
		return users;
	}

	public static ICollection<long> GetUserIdsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		List<long> userIds = new List<long>();
		foreach (UserGroup ug in UserGroup.GetUserGroupsByGroupIDPaged(groupId, startRowIndex, maximumRows))
		{
			if (ug != null)
			{
				userIds.Add(ug.UserID);
			}
		}
		return userIds;
	}

	[Obsolete("Please use IGroupRoleSet.GetUsersInRoleSet instead.")]
	public static ICollection<User> GetUsersByGroupIDAndRoleSetIDPaged(long groupId, long roleSetId, int startRowIndex, int maximumRows)
	{
		if (maximumRows < 0 || maximumRows > Settings.Default.GroupMembershipsPageLimit)
		{
			throw new ArgumentOutOfRangeException("maximumRows", "Page size is out of range");
		}
		ICollection<User> users = new List<User>();
		foreach (UserGroup item in UserGroup.GetUserGroupsByGroupIDAndRoleSetIDPaged(groupId, roleSetId, startRowIndex, maximumRows))
		{
			User u = User.Get(item.UserID);
			if (u != null)
			{
				users.Add(u);
			}
		}
		return users;
	}

	public static ICollection<long> GetUserIdsByGroupIDAndRoleSetIDPaged(long groupId, long roleSetId, int startRowIndex, int maximumRows)
	{
		if (maximumRows < 0 || maximumRows > Settings.Default.GroupMembershipsPageLimit)
		{
			throw new ArgumentOutOfRangeException("maximumRows", "Page size is out of range");
		}
		List<long> users = new List<long>();
		foreach (UserGroup ug in UserGroup.GetUserGroupsByGroupIDAndRoleSetIDPaged(groupId, roleSetId, startRowIndex, maximumRows))
		{
			if (ug != null)
			{
				users.Add(ug.UserID);
			}
		}
		return users;
	}

	public static ICollection<Roblox.Group> GetGroupsByUserID(long userID)
	{
		return new List<Roblox.Group>(from ug in UserGroup.GetUserGroupsByUserID(userID)
			select Roblox.Group.Get(ug.GroupID) into g
			orderby g.Name
			select g);
	}

	public static ICollection<Roblox.Group> GetGroupsByGroupIDAndRelationshipTypeIDPaged(long groupId, byte relationshipTypeId, int startRowIndex, int maximumRows)
	{
		ICollection<Roblox.Group> groups = new List<Roblox.Group>();
		foreach (GroupRelationship item in GroupRelationship.GetGroupRelationshipsByGroupIDAndTypeIDPaged(groupId, relationshipTypeId, startRowIndex, maximumRows))
		{
			Roblox.Group g = Roblox.Group.Get(item.RelatedGroupID);
			if (g != null)
			{
				groups.Add(g);
			}
		}
		return groups;
	}

	public static int GetTotalNumberOfUsersByGroupID(long groupId)
	{
		return (int)GroupCounter.GetOrCreate(groupId, GroupCounterType.MembersID).Value;
	}

	public static int GetTotalNumberOfUsersByGroupIDAndRoleSetID(long groupId, long roleSetId)
	{
		return UserGroup.GetTotalNumberOfUserGroupsByGroupIDAndRoleSetID(groupId, roleSetId);
	}

	public static int GetTotalNumberOfGroupsByUserID(long userID)
	{
		return UserGroup.GetTotalNumberOfUserGroupsByUserID(userID);
	}

	public static int GetTotalNumberOfGroupsByGroupIDAndRelationshipTypeID(long groupId, byte relationshipTypeId)
	{
		return GroupRelationship.GetTotalNumberOfGroupRelationshipsByGroupIDAndTypeID(groupId, relationshipTypeId);
	}

	public static Asset GetAssetFromGroup(Roblox.Group g)
	{
		if (g == null)
		{
			return null;
		}
		try
		{
			return g.GetEmblem();
		}
		catch (DataIntegrityException ex)
		{
			ExceptionHandler.LogException(ex);
			return null;
		}
	}

	public static int GroupJoinLimit(long userId)
	{
		if (userId == 0L)
		{
			return -1;
		}
		User user = User.Get(userId);
		if (user == null)
		{
			return -1;
		}
		if (PremiumFeatureHelper.IsOutrageousBuildersClubMember(user.AccountID))
		{
			return GroupManagementProperties.OBCUserGroupJoinLimit;
		}
		if (PremiumFeatureHelper.IsTurboBuildersClubMember(user.AccountID))
		{
			return GroupManagementProperties.TBCUserGroupJoinLimit;
		}
		if (PremiumFeatureHelper.IsBuildersClubMember(user.AccountID))
		{
			return GroupManagementProperties.BCUserGroupJoinLimit;
		}
		if (AccountAddOnFactory.IsPremiumAccount(user.AccountID))
		{
			return GroupManagementProperties.PremiumUserGroupJoinLimit;
		}
		return GroupManagementProperties.UserGroupJoinLimit;
	}

	public static int GroupCreateLimit(long userId)
	{
		if (userId == 0L)
		{
			return -1;
		}
		User user = User.Get(userId);
		if (user == null)
		{
			return -1;
		}
		if (PremiumFeatureHelper.IsOutrageousBuildersClubMember(user.AccountID))
		{
			return GroupManagementProperties.OBCUserGroupCreateLimit;
		}
		if (PremiumFeatureHelper.IsTurboBuildersClubMember(user.AccountID))
		{
			return GroupManagementProperties.TBCUserGroupCreateLimit;
		}
		if (PremiumFeatureHelper.IsBuildersClubMember(user.AccountID))
		{
			return GroupManagementProperties.BCUserGroupCreateLimit;
		}
		if (AccountAddOnFactory.IsPremiumAccount(user.AccountID))
		{
			return GroupManagementProperties.PremiumUserGroupCreateLimit;
		}
		return GroupManagementProperties.UserGroupCreateLimit;
	}

	public static Roblox.Group GetPrimaryGroup(long userId)
	{
		UserGroup primaryGroup = PrimaryUserGroup.GetByUserID(userId);
		if (primaryGroup != null)
		{
			return Roblox.Group.Get(primaryGroup.GroupID);
		}
		return null;
	}

	/// Roblox Admin Functions *
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Group memberships are in read-only mode.</exception>
	public static void ReplaceOwner(long groupId, long newOwnerID, IGroupFactory groupFactory, IGroupCounter groupCounter, IGroupEventPublisher groupEventPublisher)
	{
		if (Settings.Default.IsGroupMembershipReadOnlyModeEnabled)
		{
			throw new OperationUnavailableException("Group memberships are in read-only mode.");
		}
		Roblox.Group g = Roblox.Group.Get(groupId);
		if (g == null)
		{
			return;
		}
		long ownerRoleSetID = Roblox.GroupRoleSet.GetOwnerGroupRoleSetByGroupID(groupId).ID;
		if (!g.OwnerUserID.HasValue)
		{
			ICollection<User> ownerSet = GetUsersByGroupIDAndRoleSetIDPaged(groupId, ownerRoleSetID, 0, 10);
			if (ownerSet.Count > 0)
			{
				g.OwnerUserID = ownerSet.First().ID;
				g.Save();
			}
			if (g.OwnerUserID.HasValue && g.OwnerUserID == newOwnerID)
			{
				return;
			}
		}
		UserGroup newOwnerUG = UserGroup.Get(newOwnerID, groupId);
		if (newOwnerUG == null)
		{
			newOwnerUG = CreateNew_PlatformOnly(newOwnerID, groupId, ownerRoleSetID);
			HandleMemberEvent(groupId, newOwnerID, groupFactory, groupCounter, groupEventPublisher, GroupEventType.MemberJoin);
		}
		else
		{
			newOwnerUG.RoleSetID = ownerRoleSetID;
			newOwnerUG.Save();
		}
		if (g.OwnerUserID.HasValue && g.OwnerUserID != newOwnerID && UserGroup.Get(g.OwnerUserID.Value, groupId) != null)
		{
			LeaveGroup(g.OwnerUserID.Value, groupId, groupFactory, groupCounter, groupEventPublisher);
		}
		GroupJoinRequest.Get(groupId, newOwnerID)?.Delete();
		g.OwnerUserID = newOwnerID;
		g.Save();
	}

	/// Public methods *
	public static bool IsMemberOfGroup(long userID, long groupId)
	{
		if (userID == 0L)
		{
			throw new ApplicationException("Invalid UserID");
		}
		if (groupId == 0L)
		{
			throw new ApplicationException("Invalid GroupID");
		}
		if (UserGroup.Get(userID, groupId) != null)
		{
			return true;
		}
		return false;
	}

	/// Actions *
	private static void PostOnWall(long userID, long groupId, string message)
	{
		if (Roblox.Group.Get(groupId) == null)
		{
			throw new ApplicationException("Invalid group ID");
		}
		Roblox.GroupRoleSet currentRoleSet = Roblox.GroupRoleSet.Get(userID, groupId);
		GroupWallPostFloodChecker groupWallPostFloodChecker = new GroupWallPostFloodChecker(userID);
		if (!groupWallPostFloodChecker.IsFlooded())
		{
			if (!currentRoleSet.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanPostToWall))
			{
				throw new ApplicationException($"User: {userID} is not allowed to post to group {groupId}'s wall!");
			}
			GroupWallPost.CreateNew(userID, groupId, message);
			groupWallPostFloodChecker.UpdateCount();
		}
	}

	private static void DeleteWallPost(Roblox.GroupRoleSet roleSet, GroupWallPost post, long approverUserId)
	{
		if (post != null && (CanPerformAction(approverUserId, roleSet.GroupID, Roblox.GroupRoleSetPermissionType.Permission.CanDeletePosts) || approverUserId == post.UserID))
		{
			DeletePostJson json = new DeletePostJson
			{
				PostDesc = post.Value,
				TargetId = post.UserID
			};
			post.Delete();
			LogGroupAction(approverUserId, roleSet.GroupID, GroupActionType.DeletePost.ID, json);
		}
	}

	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Group memberships are in read-only mode.</exception>
	/// <exception cref="T:Roblox.Platform.Groups.AcceptJoinRequestException">Thrown when the user has insufficient permissions and shouldThrow is true.</exception>
	public static void AcceptJoinRequest(GroupJoinRequest request, long approverUserId, IGroupFactory groupFactory, IGroupCounter groupCounter, IGroupEventPublisher groupEventPublisher, bool shouldThrow = false)
	{
		if (Settings.Default.IsGroupMembershipReadOnlyModeEnabled)
		{
			throw new OperationUnavailableException("Group memberships are in read-only mode.");
		}
		if (CanPerformAction(approverUserId, request.GroupID, Roblox.GroupRoleSetPermissionType.Permission.CanInviteMembers))
		{
			if (IsMemberOfGroup(request.UserID, request.GroupID))
			{
				request.Delete();
				return;
			}
			if (GetTotalNumberOfGroupsByUserID(request.UserID) >= GroupJoinLimit(request.UserID))
			{
				request.Delete();
				if (!shouldThrow)
				{
					return;
				}
				throw new AcceptJoinRequestException(AcceptJoinRequestFailureReason.MaxGroups);
			}
			if (Roblox.Group.Get(request.GroupID) == null)
			{
				throw new ApplicationException($"OldGroupEntity:{request.GroupID} does not exist!");
			}
			CreateNew_PlatformOnly(request.UserID, request.GroupID, Roblox.GroupRoleSet.GetDefaultStartingRoleSetByGroupID(request.GroupID).ID);
			HandleMemberEvent(request.GroupID, request.UserID, groupFactory, groupCounter, groupEventPublisher, GroupEventType.MemberJoin);
			request.Delete();
			TargetUserJson json = new TargetUserJson
			{
				TargetId = request.UserID
			};
			LogGroupAction(approverUserId, request.GroupID, GroupActionType.AcceptJoinRequest.ID, json);
		}
		else if (shouldThrow)
		{
			throw new AcceptJoinRequestException(AcceptJoinRequestFailureReason.InsufficientPermissions);
		}
	}

	public static bool DeclineJoinRequest(GroupJoinRequest request, long approverUserId)
	{
		bool selfDecline = request.UserID == approverUserId;
		if (selfDecline || CanPerformAction(approverUserId, request.GroupID, Roblox.GroupRoleSetPermissionType.Permission.CanInviteMembers))
		{
			request.Delete();
			if (!selfDecline)
			{
				TargetUserJson json = new TargetUserJson
				{
					TargetId = request.UserID
				};
				LogGroupAction(approverUserId, request.GroupID, GroupActionType.DeclineJoinRequest.ID, json);
			}
			return true;
		}
		return false;
	}

	private static void ChangeStatus(long groupId, long approverUserId, string message)
	{
		if (CanPerformAction(approverUserId, groupId, Roblox.GroupRoleSetPermissionType.Permission.CanPostToStatus))
		{
			GroupStatus gs = GroupStatus.GetGroupStatusByGroupID(groupId);
			message = message.Trim();
			message = ((message.Length > 255) ? message.Substring(0, 255) : message);
			if (gs == null)
			{
				gs = GroupStatus.CreateNew(approverUserId, groupId, message);
			}
			else
			{
				gs.Message = message;
				gs.PosterID = approverUserId;
				gs.Save();
			}
			LogGroupAction(approverUserId, groupId, GroupActionType.PostStatus.ID, new TextJson
			{
				Text = gs.Message
			});
		}
	}

	/// <summary>
	/// Attempts to join a group as the given user
	/// </summary>
	/// <param name="userID">The user id</param>
	/// <param name="groupId">The group id</param>
	/// <param name="roleSetID">The group role set id</param>
	/// <param name="groupFactory">The <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <param name="groupCounter">The <see cref="T:Roblox.Platform.Groups.Counters.IGroupCounter" /></param>
	/// <param name="groupEventPublisher">The <see cref="T:Roblox.Platform.Groups.Events.IGroupEventPublisher" /></param>
	/// <param name="groupFloodCheckerFactory">The <see cref="T:Roblox.Platform.Groups.IGroupFloodCheckerFactory" /></param>
	/// <param name="premiumFeaturesUser">The <see cref="T:Roblox.Platform.PremiumFeatures.Interfaces.IPremiumFeaturesUser" /></param>
	/// <param name="ephemeralCounterFactory">Optional <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" /></param>
	/// <param name="bypassRestrictions">If true, the user will bypass any user or group restrictions e.g. user has max # of groups, group is private or BC-only</param>
	/// <exception cref="T:Roblox.Platform.Groups.JoinGroupException">User failed to join the group. Exception has a Reason enum that contains more information.</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Group memberships are in read-only mode.</exception>
	public static void JoinGroup(long userID, long groupId, long roleSetID, IGroupFactory groupFactory, IGroupCounter groupCounter, IGroupEventPublisher groupEventPublisher, IGroupFloodCheckerFactory groupFloodCheckerFactory, IPremiumFeaturesUser premiumFeaturesUser, IEphemeralCounterFactory ephemeralCounterFactory = null, bool bypassRestrictions = false)
	{
		if (IsMemberOfGroup(userID, groupId))
		{
			throw new JoinGroupException(JoinGroupFailureReason.AlreadyMember, userID, groupId);
		}
		int t = GetTotalNumberOfGroupsByUserID(userID);
		if (!bypassRestrictions && t >= GroupJoinLimit(userID))
		{
			throw new JoinGroupException(JoinGroupFailureReason.UserInMaxGroups, userID, groupId);
		}
		Roblox.Group g = Roblox.Group.Get(groupId);
		if (g == null)
		{
			throw new JoinGroupException(JoinGroupFailureReason.NonexistentGroup, userID, groupId);
		}
		if (GroupJoinRequest.Get(groupId, userID) != null)
		{
			throw new JoinGroupException(JoinGroupFailureReason.JoinRequestAlreadyPending, userID, groupId);
		}
		if (IsGroupJoinPremiumValidationEnabled && !bypassRestrictions && g.BCOnlyJoin && !PremiumFeatureHelper.IsAnyBuildersClubMember(User.Get(userID).AccountID) && !premiumFeaturesUser.IsPremiumUser(userID))
		{
			throw new JoinGroupException(JoinGroupFailureReason.NeedsPremiumMembership, userID, groupId);
		}
		if (!g.OwnerUserID.HasValue && !g.PublicEntryAllowed)
		{
			throw new JoinGroupException(JoinGroupFailureReason.GroupClosed, userID, groupId);
		}
		if (Settings.Default.IsGroupMembershipReadOnlyModeEnabled)
		{
			throw new OperationUnavailableException("Group memberships are in read-only mode.");
		}
		ephemeralCounterFactory?.GetCounter(_JoinGroupCounterName).IncrementInBackground();
		if (bypassRestrictions)
		{
			try
			{
				CreateNew_PlatformOnly(userID, groupId, roleSetID);
			}
			catch (UserAlreadyGroupMemberException)
			{
				throw new JoinGroupException(JoinGroupFailureReason.AlreadyMember, userID, groupId);
			}
			HandleMemberEvent(groupId, userID, groupFactory, groupCounter, groupEventPublisher, GroupEventType.MemberJoin);
		}
		else if (g.PublicEntryAllowed)
		{
			IFloodChecker joinGroupFloodChecker = groupFloodCheckerFactory.GetJoinGroupFloodChecker(userID);
			if (joinGroupFloodChecker.IsFlooded())
			{
				throw new JoinGroupException(JoinGroupFailureReason.Floodchecked, userID, groupId);
			}
			joinGroupFloodChecker.UpdateCount();
			try
			{
				CreateNew_PlatformOnly(userID, groupId, roleSetID);
			}
			catch (UserAlreadyGroupMemberException)
			{
				throw new JoinGroupException(JoinGroupFailureReason.AlreadyMember, userID, groupId);
			}
			HandleMemberEvent(groupId, userID, groupFactory, groupCounter, groupEventPublisher, GroupEventType.MemberJoin);
		}
		else
		{
			GroupJoinRequest.CreateNew(groupId, userID);
		}
	}

	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Group memberships are in read-only mode.</exception>
	public static void LeaveGroup(long userID, long groupId, IGroupFactory groupFactory, IGroupCounter groupCounter, IGroupEventPublisher groupEventPublisher)
	{
		UserGroup obj = UserGroup.Get(userID, groupId) ?? throw new LeaveGroupException($"User:{userID} is not in group{groupId}");
		Roblox.Group g = Roblox.Group.Get(obj.GroupID);
		if (g == null)
		{
			throw new LeaveGroupException($"OldGroupEntity:{groupId} does not exist");
		}
		if (Settings.Default.IsGroupMembershipReadOnlyModeEnabled)
		{
			throw new OperationUnavailableException("Group memberships are in read-only mode.");
		}
		if (g.OwnerUserID.HasValue && g.OwnerUserID.Value == userID)
		{
			g.PreviousOwnerUserID = g.OwnerUserID.Value;
			g.OwnerUserID = null;
			g.Save();
		}
		obj.Delete();
		HandleMemberEvent(g.ID, userID, groupFactory, groupCounter, groupEventPublisher, GroupEventType.MemberLeave);
	}

	public static void ChangeRank(long groupId, long targetUserId, Roblox.GroupRoleSet newGrs, long approverUserId)
	{
		Roblox.GroupRoleSet performerGrs = Roblox.GroupRoleSet.Get(approverUserId, groupId);
		Roblox.GroupRoleSet oldGrs = Roblox.GroupRoleSet.Get(targetUserId, groupId);
		if (CanPerformActionCompareRank(performerGrs, oldGrs, Roblox.GroupRoleSetPermissionType.Permission.CanChangeRank, equalRanksCanPerform: false) && newGrs.Rank < performerGrs.Rank)
		{
			UserGroup targetUserGroup = UserGroup.Get(targetUserId, groupId);
			if (targetUserGroup != null)
			{
				ChangeRankJson json = new ChangeRankJson
				{
					TargetId = targetUserId,
					OldRoleSetId = oldGrs.ID,
					NewRoleSetId = newGrs.ID
				};
				targetUserGroup.RoleSetID = newGrs.ID;
				targetUserGroup.Save();
				LogGroupAction(approverUserId, groupId, GroupActionType.ChangeRank.ID, json);
			}
		}
	}

	public static void LogAd(long userId, long groupId, string name, int bid, int currencyTypeID)
	{
		AdJson json = new AdJson
		{
			AdName = name,
			Bid = bid,
			CurrencyTypeId = currencyTypeID
		};
		LogGroupAction(userId, groupId, GroupActionType.BuyAd.ID, json);
	}

	/// <summary>
	/// Create a new Group based on the given parameters.
	/// </summary>
	/// <param name="ownerUser"></param>
	/// <param name="name"></param>
	/// <param name="description"></param>
	/// <param name="emblemID"></param>
	/// <param name="publicEntryAllowed"></param>
	/// <param name="bcOnlyJoin"></param>
	/// <param name="groupFactory"></param>
	/// <param name="groupCounter"></param>
	/// <param name="groupEventPublisher"></param>
	/// <param name="textFilter"></param>
	/// <returns>The Roblox.Group that was created.</returns>
	/// <exception cref="!:GroupCreationException">There was an issue create the group as requested.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Some part of the system is unavailable to completely the operation. Likely TextFilter.</exception>
	public static Roblox.Group CreateGroup(IUser ownerUser, string name, string description, long emblemID, bool publicEntryAllowed, bool bcOnlyJoin, IGroupFactory groupFactory, IGroupCounter groupCounter, IGroupEventPublisher groupEventPublisher, ITextFilter textFilter)
	{
		if (ownerUser == null)
		{
			throw new ArgumentNullException("ownerUser");
		}
		if (!string.IsNullOrEmpty(description) && description.Length > GroupDescriptionMaxCharacterCount)
		{
			throw new LongDescriptionException($"The description is {description.Length} characters long but the max is {GroupDescriptionMaxCharacterCount}.");
		}
		Tuple<string, string> filteredText = FilterNameAndDescription(ownerUser, name, description, textFilter);
		if (Roblox.Group.Get(filteredText.Item1) != null)
		{
			throw new ArgumentException("Group with same name already exists.", "name");
		}
		Roblox.Group g = Roblox.Group.CreateNew(ownerUser.Id, filteredText.Item1, filteredText.Item2, emblemID, publicEntryAllowed, bcOnlyJoin);
		Roblox.GroupRoleSet owner = Roblox.GroupRoleSet.GetOrCreate(g.ID, "Owner", "The group's owner.", byte.MaxValue);
		Roblox.GroupRoleSet admin = Roblox.GroupRoleSet.GetOrCreate(g.ID, "Admin", "A group administrator.", Convert.ToByte(Convert.ToInt32(byte.MaxValue) - 1));
		Roblox.GroupRoleSet member = Roblox.GroupRoleSet.GetOrCreate(g.ID, "Member", "A regular group member.", 1);
		Roblox.GroupRoleSet guest = Roblox.GroupRoleSet.GetOrCreate(g.ID, "Guest", "A non-group member.", 0);
		CreateNew_PlatformOnly(ownerUser.Id, g.ID, owner.ID);
		HandleMemberEvent(g.ID, ownerUser.Id, groupFactory, groupCounter, groupEventPublisher, GroupEventType.MemberJoin);
		foreach (Roblox.GroupRoleSetPermissionType permissionType in Roblox.GroupRoleSetPermissionType.GetAllPermissions())
		{
			GroupRoleSetPermission.GetOrCreate(owner.ID, permissionType.ID, (byte)permissionType.Category);
		}
		GroupRoleSetPermission.GetOrCreate(admin.ID, Roblox.GroupRoleSetPermissionType.Permission.CanPostToWall);
		GroupRoleSetPermission.GetOrCreate(member.ID, Roblox.GroupRoleSetPermissionType.Permission.CanPostToWall);
		GroupRoleSetPermission.GetOrCreate(admin.ID, Roblox.GroupRoleSetPermissionType.Permission.CanViewWall);
		GroupRoleSetPermission.GetOrCreate(member.ID, Roblox.GroupRoleSetPermissionType.Permission.CanViewWall);
		GroupRoleSetPermission.GetOrCreate(guest.ID, Roblox.GroupRoleSetPermissionType.Permission.CanViewWall);
		GroupRoleSetPermission.GetOrCreate(admin.ID, Roblox.GroupRoleSetPermissionType.Permission.CanViewStatus);
		GroupRoleSetPermission.GetOrCreate(member.ID, Roblox.GroupRoleSetPermissionType.Permission.CanViewStatus);
		GroupRoleSetPermission.GetOrCreate(guest.ID, Roblox.GroupRoleSetPermissionType.Permission.CanViewStatus);
		return g;
	}

	private static Tuple<string, string> FilterNameAndDescription(IUser ownerUser, string name, string description, ITextFilter textFilter)
	{
		try
		{
			Guid tempId = Guid.NewGuid();
			ModeratedTextRequest moderatedNameRequest = new ModeratedTextRequest(ownerUser.ToTextAuthor(), name, "GroupName", tempId.ToString());
			ModeratedTextRequest moderatedDescriptionRequest = new ModeratedTextRequest(ownerUser.ToTextAuthor(), description, "GroupName", tempId.ToString());
			string filteredText = textFilter.FilterText(moderatedNameRequest).FilteredText;
			string filteredDescription = textFilter.FilterText(moderatedDescriptionRequest).FilteredText;
			return new Tuple<string, string>(filteredText, filteredDescription);
		}
		catch (TextFilterOperationUnavailableException ex)
		{
			throw new PlatformOperationUnavailableException("CommunitySift not available", ex);
		}
	}

	public static void SetPrimaryGroup(long userId, long groupId)
	{
		PrimaryUserGroup.SetForUserIDAndGroupID(userId, groupId);
	}

	public static void ClearPrimaryGroup(long userId)
	{
		PrimaryUserGroup.RemoveForUserID(userId);
	}

	public static GroupRelationshipModificationStatus CreateRelationship(long approverUserId, long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		GroupRelationshipModificationStatus createRelationshipStatus = GroupRelationshipModificationStatus.Success;
		if (CanPerformAction(approverUserId, groupId, Roblox.GroupRoleSetPermissionType.Permission.CanManageRelationships))
		{
			if (groupId == relatedGroupId || GroupRelationship.Get(groupId, relatedGroupId, groupRelationshipTypeId) != null)
			{
				return (groupId == relatedGroupId) ? GroupRelationshipModificationStatus.SelfError : GroupRelationshipModificationStatus.DuplicateError;
			}
			GroupRelationship.CreateNew(groupId, relatedGroupId, groupRelationshipTypeId);
			if (GroupRelationshipType.Get(groupRelationshipTypeId).IsReciprocal)
			{
				GroupRelationship.CreateNew(relatedGroupId, groupId, groupRelationshipTypeId);
			}
			if (groupRelationshipTypeId == GroupRelationshipType.AllyID)
			{
				GroupRelationship.Get(groupId, relatedGroupId, GroupRelationshipType.EnemyID)?.Delete();
				GroupRelationship.Get(relatedGroupId, groupId, GroupRelationshipType.EnemyID)?.Delete();
			}
			else if (groupRelationshipTypeId == GroupRelationshipType.EnemyID)
			{
				GroupRelationship.Get(groupId, relatedGroupId, GroupRelationshipType.AllyID)?.Delete();
				GroupRelationship.Get(relatedGroupId, groupId, GroupRelationshipType.AllyID)?.Delete();
				RelationshipJson json = new RelationshipJson
				{
					TargetGroupId = relatedGroupId
				};
				LogGroupAction(approverUserId, groupId, GroupActionType.CreateEnemy.ID, json);
			}
		}
		else
		{
			createRelationshipStatus = GroupRelationshipModificationStatus.PermissionError;
		}
		return createRelationshipStatus;
	}

	public static GroupRelationshipModificationStatus DeleteRelationship(long approverUserId, long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		if (!CanPerformAction(approverUserId, groupId, Roblox.GroupRoleSetPermissionType.Permission.CanManageRelationships))
		{
			return GroupRelationshipModificationStatus.PermissionError;
		}
		GroupRelationship relationship = GroupRelationship.Get(groupId, relatedGroupId, groupRelationshipTypeId);
		relationship?.Delete();
		if (GroupRelationshipType.Get(groupRelationshipTypeId).IsReciprocal)
		{
			GroupRelationship.Get(relatedGroupId, groupId, groupRelationshipTypeId)?.Delete();
		}
		RelationshipJson json = new RelationshipJson
		{
			TargetGroupId = relatedGroupId
		};
		if (groupRelationshipTypeId == GroupRelationshipType.AllyID)
		{
			LogGroupAction(approverUserId, groupId, GroupActionType.DeleteAlly.ID, json);
		}
		else if (groupRelationshipTypeId == GroupRelationshipType.EnemyID)
		{
			LogGroupAction(approverUserId, groupId, GroupActionType.DeleteEnemy.ID, json);
			ClanEventPublisher.PublishClanEnemyStatusTerminated(groupId, relatedGroupId);
		}
		if (relationship == null)
		{
			return GroupRelationshipModificationStatus.DoesNotExist;
		}
		return GroupRelationshipModificationStatus.Success;
	}

	public static GroupRelationshipModificationStatus SendRelationshipRequest(long sendingUserId, long sendingGroupId, long receivingGroupId, byte relationshipTypeId)
	{
		GroupRelationshipModificationStatus sendRequestStatus = GroupRelationshipModificationStatus.Success;
		if (CanPerformAction(sendingUserId, sendingGroupId, Roblox.GroupRoleSetPermissionType.Permission.CanManageRelationships))
		{
			if (sendingGroupId != receivingGroupId && GroupRelationship.Get(receivingGroupId, sendingGroupId, relationshipTypeId) == null && GroupRelationshipRequest.GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndRelatedGroupIDAndTypeID(receivingGroupId, sendingGroupId, relationshipTypeId) < 1)
			{
				GroupRelationshipRequest.CreateNew(receivingGroupId, sendingGroupId, relationshipTypeId);
				if (relationshipTypeId == GroupRelationshipType.AllyID)
				{
					RelationshipJson json = new RelationshipJson
					{
						TargetGroupId = receivingGroupId
					};
					LogGroupAction(sendingUserId, sendingGroupId, GroupActionType.SendAllyRequest.ID, json);
				}
				else
				{
					sendRequestStatus = GroupRelationshipModificationStatus.TypeError;
				}
			}
			else
			{
				sendRequestStatus = ((sendingGroupId == receivingGroupId) ? GroupRelationshipModificationStatus.SelfError : GroupRelationshipModificationStatus.DuplicateError);
			}
		}
		else
		{
			sendRequestStatus = GroupRelationshipModificationStatus.PermissionError;
		}
		return sendRequestStatus;
	}

	public static GroupRelationshipModificationStatus AcceptRelationshipRequest(GroupRelationshipRequest request, long approverUserId)
	{
		if (request == null)
		{
			return GroupRelationshipModificationStatus.DoesNotExist;
		}
		if (!CanPerformAction(approverUserId, request.GroupID, Roblox.GroupRoleSetPermissionType.Permission.CanManageRelationships))
		{
			return GroupRelationshipModificationStatus.PermissionError;
		}
		CreateRelationship(approverUserId, request.GroupID, request.RelatedGroupID, request.GroupRelationshipTypeID);
		RelationshipJson json = new RelationshipJson
		{
			TargetGroupId = request.RelatedGroupID
		};
		if (request.GroupRelationshipTypeID == GroupRelationshipType.AllyID)
		{
			LogGroupAction(approverUserId, request.GroupID, GroupActionType.AcceptAllyRequest.ID, json);
		}
		request.Delete();
		return GroupRelationshipModificationStatus.Success;
	}

	public static GroupRelationshipModificationStatus DeclineRelationshipRequest(GroupRelationshipRequest request, long approverUserId)
	{
		if (request == null)
		{
			return GroupRelationshipModificationStatus.DoesNotExist;
		}
		if (!CanPerformAction(approverUserId, request.GroupID, Roblox.GroupRoleSetPermissionType.Permission.CanManageRelationships))
		{
			return GroupRelationshipModificationStatus.PermissionError;
		}
		RelationshipJson json = new RelationshipJson
		{
			TargetGroupId = request.RelatedGroupID
		};
		if (request.GroupRelationshipTypeID == GroupRelationshipType.AllyID)
		{
			LogGroupAction(approverUserId, request.GroupID, GroupActionType.DeclineAllyRequest.ID, json);
		}
		request.Delete();
		return GroupRelationshipModificationStatus.Success;
	}

	public static void LogGroupAction(long userId, long groupId, int actionTypeId, object json)
	{
		GroupAction.CreateNew(userId, groupId, actionTypeId, _Serializer.Serialize(json));
	}

	/// Permissions checks *
	[Obsolete("Use long overload")]
	public static bool CanPerformAction(User user, long groupId, Roblox.GroupRoleSetPermissionType.Permission action)
	{
		if (user == null)
		{
			return CanPerformAction((long?)null, groupId, action);
		}
		return CanPerformAction(user.ID, groupId, action);
	}

	public static bool CanPerformAction(long? userId, long groupId, Roblox.GroupRoleSetPermissionType.Permission action)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Invalid GroupID");
		}
		Roblox.GroupRoleSet groupRoleSet = Roblox.GroupRoleSet.Get(userId, groupId);
		if (groupRoleSet == null)
		{
			throw new ApplicationException($"No GroupRoleSet found!  UserID:{userId}, GroupID:{groupId}");
		}
		return groupRoleSet.HasPermission(action);
	}

	public static bool CanPerformActionCompareRank(long groupId, long performerUserId, long targetUserId, Roblox.GroupRoleSetPermissionType.Permission action, bool equalRanksCanPerform)
	{
		Roblox.GroupRoleSet groupRoleSet = Roblox.GroupRoleSet.Get(performerUserId, groupId);
		if (groupRoleSet == null)
		{
			throw new ApplicationException($"Invalid GroupRoleSet! GroupID:{groupId}, PerformerUserID:{performerUserId}");
		}
		Roblox.GroupRoleSet grsTarget = Roblox.GroupRoleSet.Get(targetUserId, groupId);
		if (grsTarget == null)
		{
			throw new ApplicationException(string.Format("Invalid GroupRoleSet! GroupID:{0}, TargetUserID:{1}", targetUserId));
		}
		return CanPerformActionCompareRank(groupRoleSet, grsTarget, action, equalRanksCanPerform);
	}

	public static bool CanPerformActionCompareRank(Roblox.GroupRoleSet grsPerformer, Roblox.GroupRoleSet target, Roblox.GroupRoleSetPermissionType.Permission action, bool equalRanksCanPerform)
	{
		if (grsPerformer == null)
		{
			return false;
		}
		if (target == null)
		{
			return true;
		}
		if (!grsPerformer.HasPermission(action))
		{
			return false;
		}
		int rank = target.Rank;
		if (equalRanksCanPerform)
		{
			rank--;
		}
		if (grsPerformer.Rank > rank)
		{
			return true;
		}
		return false;
	}

	public static bool CanViewGroupConfiguration(long userId, long groupId)
	{
		UserGroup ug = UserGroup.Get(userId, groupId);
		if (ug == null)
		{
			return false;
		}
		Roblox.GroupRoleSet grs = Roblox.GroupRoleSet.Get(ug.RoleSetID);
		if (grs == null)
		{
			return false;
		}
		User user = User.Get(userId);
		if (user == null)
		{
			return false;
		}
		Roblox.Group group = Roblox.Group.Get(groupId);
		if (group == null)
		{
			return false;
		}
		if (group.IsLocked)
		{
			return false;
		}
		if (user.ID == group.OwnerUserID)
		{
			return true;
		}
		if (!grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanPostToStatus) && !grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanRemoveMembers) && !grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanInviteMembers) && !grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanManageClan) && !grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanChangeRank))
		{
			return grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanManageRelationships);
		}
		return true;
	}

	public static bool CanCreateGroupPlace(UserGroup ug, Roblox.Group g)
	{
		if (ug == null)
		{
			return false;
		}
		if (Asset.GetTotalNumberOfAssetsByTypeAndAgentID(AssetType.PlaceID, g.AgentID.Value, CreatorType.Group) >= GroupManagementProperties.maximumNumberOfPlacesPerGroup)
		{
			return false;
		}
		Roblox.Group group = Roblox.Group.Get(ug.GroupID);
		if (group == null || group.IsLocked)
		{
			return false;
		}
		return User.Get(ug.UserID).ID == group.OwnerUserID;
	}

	public static bool CanConfigureGroupPlace(UserGroup ug)
	{
		if (ug == null)
		{
			return false;
		}
		User user = User.Get(ug.UserID);
		if (user == null)
		{
			return false;
		}
		Roblox.Group group = Roblox.Group.Get(ug.GroupID);
		if (group == null || group.IsLocked)
		{
			return false;
		}
		Roblox.GroupRoleSet grs = Roblox.GroupRoleSet.Get(user.ID, group.ID);
		if (grs == null)
		{
			return false;
		}
		return grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanManageGroupGames);
	}

	public static bool CanViewAuditLog(long? userId, long groupId)
	{
		Roblox.GroupRoleSet grs = Roblox.GroupRoleSet.Get(userId, groupId);
		if (grs == null)
		{
			return false;
		}
		User user = User.Get(userId);
		if (user == null)
		{
			return false;
		}
		Roblox.Group group = Roblox.Group.Get(groupId);
		if (group == null)
		{
			return false;
		}
		if (group.IsLocked)
		{
			return false;
		}
		if (user.ID != group.OwnerUserID)
		{
			return grs.HasPermission(Roblox.GroupRoleSetPermissionType.Permission.CanViewAuditLog);
		}
		return true;
	}

	private static void HandleMemberEvent(long groupId, long userId, IGroupFactory groupFactory, IGroupCounter groupCounter, IGroupEventPublisher groupEventPublisher, GroupEventType groupEventType)
	{
		IGroup group = groupFactory.GetById(groupId);
		switch (groupEventType)
		{
		case GroupEventType.MemberJoin:
			groupCounter.IncrementMembersCounter(group, DateTime.Now);
			groupEventPublisher.Publish(groupId, groupEventType, userId);
			break;
		case GroupEventType.MemberLeave:
			groupCounter.DecrementMembersCounter(group, DateTime.Now);
			groupEventPublisher.Publish(groupId, groupEventType, userId);
			break;
		default:
			throw new ArgumentOutOfRangeException("groupEventType", groupEventType, null);
		}
	}

	private static UserGroup CreateNew_PlatformOnly(long userId, long groupId, long roleSetId)
	{
		UserGroup entity = new UserGroup
		{
			UserID = userId,
			GroupID = groupId,
			RoleSetID = roleSetId,
			IsTopGroup = false
		};
		entity.Save();
		if (UserGroup.GetTotalNumberOfUserGroupsByUserID(userId) >= GroupJoinLimit(userId))
		{
			foreach (GroupJoinRequest item in GroupJoinRequest.GetGroupJoinRequestsByUserID(userId))
			{
				item.Delete();
			}
		}
		return entity;
	}
}
