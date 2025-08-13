using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Events;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

internal class GroupMembership : IGroupMembership
{
	public GroupDomainFactories DomainFactories { get; }

	public IUser User { get; private set; }

	public IGroup Group { get; private set; }

	public IGroupRoleSet RoleSet { get; private set; }

	public GroupMembership(IUser user, IGroup group, IGroupRoleSet roleSet, GroupDomainFactories domainFactories)
	{
		User = user;
		Group = group;
		RoleSet = roleSet;
		DomainFactories = domainFactories;
	}

	public bool IsInClan()
	{
		IGroup clanGroup = DomainFactories.ClanMemberFactory.GetClanMembership(User);
		if (clanGroup == null)
		{
			return false;
		}
		return clanGroup.Id == Group.Id;
	}

	public void LeaveClan()
	{
		this.VerifyIsNotNull();
		if (IsInClan())
		{
			ClanMember clanMemberEntity = ClanMember.GetByUserID(User.Id);
			if (clanMemberEntity != null && clanMemberEntity.GroupID == Group.Id)
			{
				clanMemberEntity.Delete();
				ClanEventPublisher.PublishUserLeftClan(Group.Id, User.Id);
			}
		}
	}
}
