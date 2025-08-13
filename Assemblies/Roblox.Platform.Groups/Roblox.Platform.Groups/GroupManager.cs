using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

internal class GroupManager
{
	private readonly GroupDomainFactories _DomainFactories;

	internal virtual int MaxClanMembers => Settings.Default.MaxClanMembers;

	public GroupManager(GroupDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories;
	}

	internal bool CanInviteToClan(IGroupMembership groupAdminMembership, IUser userToInvite)
	{
		groupAdminMembership.VerifyIsNotNull();
		userToInvite.VerifyIsNotNull();
		if (!groupAdminMembership.HasPermission(GroupRoleSetPermissionType.CanManageClan))
		{
			throw new InsufficientPermissionsException();
		}
		IGroupMembership userToInviteGroupMembership = _DomainFactories.GroupMembershipFactory.Get(groupAdminMembership.Group, userToInvite);
		userToInviteGroupMembership.VerifyIsNotNull();
		if (userToInviteGroupMembership.RoleSet.IsGuest())
		{
			throw new NotAGroupMemberException();
		}
		if (groupAdminMembership.User.Id != userToInvite.Id && userToInviteGroupMembership.RoleSet.Rank >= groupAdminMembership.RoleSet.Rank)
		{
			throw new InsufficientRankException();
		}
		if (userToInviteGroupMembership.IsInClan())
		{
			return true;
		}
		if (ClanIsFull(groupAdminMembership.Group))
		{
			throw new ClanIsFullException();
		}
		return true;
	}

	internal bool InviteToClan(IGroupMembership groupAdminMembership, IUser userToInvite)
	{
		if (!CanInviteToClan(groupAdminMembership, userToInvite))
		{
			return false;
		}
		_DomainFactories.ClanInvitationFactory.CreateNew(groupAdminMembership.Group, userToInvite);
		return true;
	}

	internal bool ClanIsFull(IGroup group)
	{
		return group.GetTotalClanMembers() + group.GetTotalPendingInvitations() >= MaxClanMembers;
	}
}
