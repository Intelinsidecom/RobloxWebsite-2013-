using System;
using System.Collections.Generic;
using Roblox.Moderation;
using Roblox.Platform.Groups.Implementation;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public static class Extensions
{
	internal static void VerifyIsNotNull(this IGroupRoleSet roleset)
	{
		if (roleset == null)
		{
			throw new UnknownRolesetException();
		}
	}

	internal static void VerifyIsNotNull(this IGroup group)
	{
		if (group == null)
		{
			throw new UnknownGroupException();
		}
	}

	public static bool CanSell(this IGroup group)
	{
		if (group == null)
		{
			return false;
		}
		SellBan sellBanEntity = SellBan.GetByUserID(group.AgentId);
		if (sellBanEntity == null)
		{
			return true;
		}
		return sellBanEntity.Expiration <= DateTime.Now;
	}

	public static IEnumerable<IUser> GetClanMembers(this IGroup group, int index, int count)
	{
		group.VerifyIsNotNull();
		return group.DomainFactories.ClanMemberFactory.GetClanMembersByGroup(group, index, count);
	}

	public static IEnumerable<IClanInvitation> GetPendingClanInvitations(this IGroup group, int index, int count)
	{
		group.VerifyIsNotNull();
		return group.DomainFactories.ClanInvitationFactory.GetClanInvitationsByGroup(group, index, count);
	}

	public static int GetTotalPendingInvitations(this IGroup group)
	{
		group.VerifyIsNotNull();
		return group.DomainFactories.ClanInvitationFactory.GetTotalPendingClanInvitationsByGroup(group);
	}

	public static int GetTotalClanMembers(this IGroup group)
	{
		group.VerifyIsNotNull();
		return group.DomainFactories.ClanMemberFactory.GetTotalClanMembers(group);
	}

	public static bool ClanIsFull(this IGroup group)
	{
		return new GroupManager(group.DomainFactories).ClanIsFull(group);
	}

	public static IEnumerable<IGroup> GetRelatedGroups(this IGroup group, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType, int startRow, int maxRows)
	{
		return group.DomainFactories.GroupFactory.GetRelatedGroups(group.Id, relationshipType, startRow, maxRows);
	}

	public static int GetTotalRelatedGroups(this IGroup group, Roblox.Platform.Groups.Implementation.GroupRelationshipType relationshipType)
	{
		return group.DomainFactories.GroupFactory.GetTotalRelatedGroups(group.Id, relationshipType);
	}

	public static IEnumerable<IGroupRoleSet> GetRoleSets(this IGroup group)
	{
		return group.DomainFactories.GroupRoleSetAccessor.GetAllForGroup(group);
	}

	internal static void VerifyIsNotNull(this IGroupMembership groupMembership)
	{
		if (groupMembership == null)
		{
			throw new UnknownGroupMembershipException();
		}
		groupMembership.User.VerifyIsNotNull();
		groupMembership.Group.VerifyIsNotNull();
		groupMembership.RoleSet.VerifyIsNotNull();
	}

	public static bool IsAuthorizedToBuyClan(this IGroupMembership groupMembership)
	{
		groupMembership.VerifyIsNotNull();
		groupMembership.Group.VerifyIsNotNull();
		if (groupMembership.User == null || groupMembership.User.Id != groupMembership.Group.OwnerUserId)
		{
			return false;
		}
		return true;
	}

	public static bool CanBuyClan(this IGroupMembership groupMembership)
	{
		if (!groupMembership.IsAuthorizedToBuyClan())
		{
			return false;
		}
		if (groupMembership.Group.HasClan)
		{
			return false;
		}
		return true;
	}

	public static bool CanInviteToClan(this IGroupMembership groupAdminMembership, IUser userToInvite)
	{
		return new GroupManager(groupAdminMembership.DomainFactories).CanInviteToClan(groupAdminMembership, userToInvite);
	}

	public static bool HasPermission(this IGroupMembership groupMembership, GroupRoleSetPermissionType permission)
	{
		groupMembership.VerifyIsNotNull();
		return groupMembership.RoleSet.HasPermission(permission);
	}

	public static bool InviteToClan(this IGroupMembership groupAdminMembership, IUser userToInvite)
	{
		return new GroupManager(groupAdminMembership.DomainFactories).InviteToClan(groupAdminMembership, userToInvite);
	}

	public static IClanInvitation GetClanInvitation(this IGroupMembership groupMembership)
	{
		groupMembership.VerifyIsNotNull();
		if (groupMembership.RoleSet.IsGuest())
		{
			return null;
		}
		return groupMembership.DomainFactories.ClanInvitationFactory.GetClanInvitationForUser(groupMembership.Group, groupMembership.User);
	}

	public static void KickFromClan(this IGroupMembership kickeeGroupMembership, IGroupMembership adminGroupMembership)
	{
		kickeeGroupMembership.VerifyIsNotNull();
		adminGroupMembership.VerifyIsNotNull();
		if (!adminGroupMembership.HasPermission(GroupRoleSetPermissionType.CanManageClan))
		{
			throw new InsufficientPermissionsException();
		}
		if (kickeeGroupMembership.RoleSet.Rank >= adminGroupMembership.RoleSet.Rank)
		{
			throw new InsufficientRankException();
		}
		kickeeGroupMembership.LeaveClan();
	}

	public static void AdminJoinClan(this IGroupMembership groupMembership)
	{
		groupMembership.VerifyIsNotNull();
		if (!groupMembership.Group.HasClan)
		{
			throw new HasNoClanException();
		}
		if (!groupMembership.HasPermission(GroupRoleSetPermissionType.CanManageClan))
		{
			throw new InsufficientPermissionsException();
		}
		if (groupMembership.Group.ClanIsFull())
		{
			throw new ClanIsFullException();
		}
		groupMembership.JoinClan();
	}

	internal static void JoinClan(this IGroupMembership groupMembership)
	{
		IGroup currentClan = groupMembership.DomainFactories.ClanMemberFactory.GetClanMembership(groupMembership.User);
		if (currentClan != null && currentClan.Id != groupMembership.Group.Id)
		{
			groupMembership.DomainFactories.GroupMembershipFactory.Get(currentClan, groupMembership.User).LeaveClan();
		}
		else if (currentClan != null && currentClan.Id == groupMembership.Group.Id)
		{
			return;
		}
		groupMembership.DomainFactories.ClanMemberFactory.CreateClanMembership(groupMembership);
	}

	public static bool IsGroupOwner(this IGroupMembership groupMembership)
	{
		if (groupMembership.User == null)
		{
			return false;
		}
		return groupMembership.RoleSet.IsOwner();
	}

	public static bool IsGuest(this IGroupMembership groupMembership)
	{
		if (groupMembership.User == null)
		{
			return true;
		}
		return groupMembership.RoleSet.IsGuest();
	}

	public static void VerifyIsNotNull(this IClanInvitation clanInvitation)
	{
		if (clanInvitation == null)
		{
			throw new UnknownClanInvitationException();
		}
	}

	public static void TurnOnFeature(this IGroup group, IGroupMembership groupMembership, byte groupFeatureTypeId)
	{
		new GroupFeatureEnabler().TurnOnFeature(group, groupMembership, groupFeatureTypeId);
	}

	public static void TurnOffFeature(this IGroup group, IGroupMembership groupMembership, byte groupFeatureTypeId)
	{
		new GroupFeatureEnabler().TurnOffFeature(group, groupMembership, groupFeatureTypeId);
	}

	public static bool HasFeature(this IGroup group, byte groupFeatureTypeId)
	{
		return new GroupFeatureEnabler().HasFeature(group, groupFeatureTypeId);
	}
}
