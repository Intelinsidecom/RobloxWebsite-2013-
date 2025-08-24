using System;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Locking;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.PremiumFeatures.Interfaces;

namespace Roblox.Platform.Groups;

public class GroupMembershipAuthority : IGroupMembershipAuthority
{
	private readonly GroupDomainFactories _DomainFactories;

	private readonly IGroupFloodCheckerFactory _FloodCheckerFactory;

	private readonly IRedisLeasedLockFactory _RedisLeasedLockFactory;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly IPremiumFeaturesUser _PremiumFeaturesUser;

	private static bool IsGroupCreatePremiumValidationEnabled => Settings.Default.IsGroupCreatePremiumValidationEnabled;

	private string BuildGroupOwnershipLockKey(IGroup group)
	{
		return $"Roblox.Platform.Groups_Ownership_Group_Id_{group.Id}";
	}

	public GroupMembershipAuthority(GroupDomainFactories domainFactories, IGroupFloodCheckerFactory floodcheckerFactory, IRedisLeasedLockFactory redisLeasedLockFactory, ISettings settings, ILogger logger, IPremiumFeaturesUser premiumFeaturesUser)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
		_FloodCheckerFactory = floodcheckerFactory.AssignOrThrowIfNull("floodcheckerFactory");
		_RedisLeasedLockFactory = redisLeasedLockFactory.AssignOrThrowIfNull("redisLeasedLockFactory");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_Logger = logger.AssignOrThrowIfNull("logger");
		_PremiumFeaturesUser = premiumFeaturesUser.AssignOrThrowIfNull("premiumFeaturesUser");
	}

	public OwnershipChangeResult ChangeOwner(IGroup group, IUser authenticatedUser, IUser newOwner)
	{
		if (group == null || group.IsLocked())
		{
			return OwnershipChangeResult.InvalidGroup;
		}
		if (authenticatedUser == null)
		{
			return OwnershipChangeResult.Unauthorized;
		}
		if (newOwner == null)
		{
			return OwnershipChangeResult.NewOwnerDoesNotExist;
		}
		if (!group.OwnerUserId.HasValue || group.OwnerUserId != authenticatedUser.Id)
		{
			return OwnershipChangeResult.Unauthorized;
		}
		if (IsGroupCreatePremiumValidationEnabled && !newOwner.IsAnyBuildersClubMember() && !_PremiumFeaturesUser.IsPremiumUser(newOwner.Id))
		{
			return OwnershipChangeResult.NewOwnerNeedsPremiumMembership;
		}
		_DomainFactories.GroupMembershipFactory.Get(group, authenticatedUser);
		IGroupMembership newOwnerMembership = _DomainFactories.GroupMembershipFactory.Get(group, newOwner);
		if (newOwnerMembership.IsGuest())
		{
			return OwnershipChangeResult.NewOwnerNotInGroup;
		}
		if (Settings.Default.IsGroupMembershipReadOnlyModeEnabled)
		{
			return OwnershipChangeResult.OperationUnavailable;
		}
		_ = newOwnerMembership.RoleSet.Id;
		Roblox.Group groupEntity = Roblox.Group.Get(group.Id);
		long previousOwnerId = groupEntity.PreviousOwnerUserID;
		UserGroup authenticatedUserGroup = GetUserGroup(authenticatedUser, group);
		UserGroup newOwnerUserGroup = GetUserGroup(newOwner, group);
		long previousOwnerRankId = authenticatedUserGroup.RoleSetID;
		long previousMemberRankId = newOwnerUserGroup.RoleSetID;
		try
		{
			authenticatedUserGroup.RoleSetID = Roblox.GroupRoleSet.GetDefaultStartingRoleSetByGroupID(groupEntity.ID).ID;
			newOwnerUserGroup.RoleSetID = previousOwnerRankId;
			long oldOwnerId = groupEntity.OwnerUserID.Value;
			long newOwnerId = newOwnerUserGroup.UserID;
			groupEntity.PreviousOwnerUserID = oldOwnerId;
			groupEntity.OwnerUserID = newOwnerId;
			authenticatedUserGroup.Save();
			newOwnerUserGroup.Save();
			groupEntity.Save();
		}
		catch (Exception)
		{
			authenticatedUserGroup.RoleSetID = previousOwnerRankId;
			newOwnerUserGroup.RoleSetID = previousMemberRankId;
			groupEntity.PreviousOwnerUserID = previousOwnerId;
			groupEntity.OwnerUserID = authenticatedUser.Id;
			authenticatedUserGroup.Save();
			newOwnerUserGroup.Save();
			groupEntity.Save();
			throw;
		}
		return OwnershipChangeResult.Success;
	}

	public void ClaimOwnership(IGroup group, IUser newOwner)
	{
		if (group == null)
		{
			throw new PlatformArgumentNullException("group");
		}
		if (newOwner == null)
		{
			throw new PlatformArgumentNullException("newOwner");
		}
		if (Settings.Default.IsGroupMembershipReadOnlyModeEnabled)
		{
			throw new OperationUnavailableException("Group memberships are in read-only mode.");
		}
		IFloodChecker claimOwnershipFloodChecker = _FloodCheckerFactory.GetClaimOwnershipFloodChecker(newOwner.Id);
		if (claimOwnershipFloodChecker.IsFlooded())
		{
			throw new ClaimOwnershipFloodCheckedException($"The user:{newOwner.Id} is floodchecked for joining too many groups in a time period.");
		}
		claimOwnershipFloodChecker.UpdateCount();
		ValidateAndRefreshGroupAndNewOwner(group, newOwner);
		string groupKey = BuildGroupOwnershipLockKey(group);
		using IRedisLeasedLock redisLeasedLock = _RedisLeasedLockFactory.CreateLeasedLock(groupKey, _Settings.OwnershipLeasedLockTimeSpan, delegate(Exception ex)
		{
			_Logger.Error(ex);
		});
		if (redisLeasedLock.TryAcquire())
		{
			IGroup refreshedGroup = _DomainFactories.GroupFactory.GetById(group.Id);
			IUser refreshedNewOwner = _DomainFactories.UserFactory.GetUser(newOwner.Id);
			ValidateAndRefreshGroupAndNewOwner(refreshedGroup, refreshedNewOwner).Deconstruct(out var item, out var item2);
			IGroupEntity groupEntity = item;
			UserGroup userGroup = item2;
			long groupOwnerRoleSetId = GetGroupOwnerRoleSetId(groupEntity);
			bool isNewGroupOwnerTryingToClaim = groupEntity.OwnerUserId != userGroup.UserID;
			bool doesGroupOwnerHaveOwnerRoleSet = userGroup.RoleSetID == groupOwnerRoleSetId;
			long prevRoleSetID = userGroup.RoleSetID;
			try
			{
				if (isNewGroupOwnerTryingToClaim)
				{
					groupEntity.OwnerUserId = newOwner.Id;
					groupEntity.Update();
					userGroup.RoleSetID = groupOwnerRoleSetId;
					userGroup.Save();
					LogClaimGroupAction(refreshedGroup, refreshedNewOwner);
				}
				else if (!doesGroupOwnerHaveOwnerRoleSet)
				{
					userGroup.RoleSetID = groupOwnerRoleSetId;
					userGroup.Save();
				}
				return;
			}
			catch (Exception ex2)
			{
				_Logger.Error($"The user:{newOwner.Id} tried to claim group:{group.Id} but failed; attempt to rollback");
				if (isNewGroupOwnerTryingToClaim)
				{
					groupEntity.OwnerUserId = null;
					groupEntity.Update();
					userGroup.RoleSetID = prevRoleSetID;
					userGroup.Save();
				}
				else if (!doesGroupOwnerHaveOwnerRoleSet)
				{
					userGroup.RoleSetID = prevRoleSetID;
					userGroup.Save();
				}
				throw new ClaimGroupException($"The user:{newOwner.Id} tried to claim group:{group.Id} but failed", ex2);
			}
		}
		_Logger.Error($"Failed to get lock {groupKey} for group:{group.Id}.");
		throw new ClaimGroupException($"The user:{newOwner.Id} tried to claim group:{group.Id} but failed");
	}

	/// <summary>
	/// Validates the group, the newOwner, and will return the entity Group and SCL UserGroup that can be used for modification. Please make sure that the group and user are up-to-date as much as possible
	/// and are the objects which will be modified or be used to persist data changes.
	/// </summary>
	internal virtual Tuple<IGroupEntity, UserGroup> ValidateAndRefreshGroupAndNewOwner(IGroup group, IUser newOwner)
	{
		if (group != null)
		{
			_ = group.Id;
			if (0 == 0)
			{
				if (newOwner != null)
				{
					_ = newOwner.Id;
					if (0 == 0)
					{
						if (group.IsLocked())
						{
							throw new ClaimGroupUnauthorizedException($"The user:{newOwner.Id} tried to claim locked group:{group.Id}");
						}
						if (IsGroupCreatePremiumValidationEnabled && !newOwner.IsAnyBuildersClubMember() && !_PremiumFeaturesUser.IsPremiumUser(newOwner.Id))
						{
							throw new ClaimGroupUnauthorizedException($"The user:{newOwner.Id} without any Premium membership tried to claim group:{group.Id}");
						}
						IGroupEntity groupEntity = _DomainFactories.GroupEntityFactory.GetById(group.Id);
						if (groupEntity == null)
						{
							throw new UnknownGroupException(group.Id);
						}
						if (groupEntity.OwnerUserId.HasValue && groupEntity.OwnerUserId != newOwner.Id)
						{
							throw new ClaimGroupWithOwnerException($"The user:{newOwner.Id} tried to claim group:{group.Id} which still has an owner");
						}
						UserGroup userGroup = GetUserGroup(newOwner, group);
						if (userGroup == null)
						{
							throw new ClaimGroupUnauthorizedException($"The user:{newOwner.Id} tried to claim group:{group.Id} but is not a member");
						}
						return new Tuple<IGroupEntity, UserGroup>(groupEntity, userGroup);
					}
				}
				throw new UnknownUserException();
			}
		}
		throw new UnknownGroupException();
	}

	/// <summary>
	/// This is a wrapper around the static GroupManagement LogGroupAction method for unit-tests
	/// </summary>
	internal virtual void LogClaimGroupAction(IGroup group, IUser newOwner)
	{
		GroupManagement.LogGroupAction(newOwner.Id, group.Id, GroupActionType.Claim.ID, new GroupManagement.InitiatorUserJson
		{
			InitiatorId = newOwner.Id
		});
	}

	/// <summary>
	/// This is a wrapper around a static GetOwnerGroupRoleSetByGroupID method
	/// </summary>
	/// <param name="groupEntity">GroupEntity for which to retrieve the owner roleset Id</param>
	/// <returns></returns>
	internal virtual long GetGroupOwnerRoleSetId(IGroupEntity groupEntity)
	{
		return Roblox.GroupRoleSet.GetOwnerGroupRoleSetByGroupID(groupEntity.Id).ID;
	}

	/// <summary>
	/// This is a wrapper around a static UserGroup Get method
	/// </summary>
	internal virtual UserGroup GetUserGroup(IUser user, IGroup group)
	{
		return UserGroup.Get(user.Id, group.Id);
	}
}
