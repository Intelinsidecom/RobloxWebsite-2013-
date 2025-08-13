using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Events;
using Roblox.Platform.Groups.Interfaces;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public class ClanMemberFactory : IClanMemberFactory
{
	private readonly GroupDomainFactories _DomainFactories;

	private readonly IUserFactory _UserFactory;

	public ClanMemberFactory(GroupDomainFactories domainFactories, IUserFactory userFactory)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public virtual IEnumerable<IUser> GetClanMembersByGroup(IGroup group, int startRowIndex, int maxRows)
	{
		group.VerifyIsNotNull();
		return from clanMemberEntity in ClanMember.GetClanMembersByGroupID_Paged(@group.Id, startRowIndex, maxRows)
			select _UserFactory.GetUser(clanMemberEntity.UserID);
	}

	public virtual int GetTotalClanMembers(IGroup group)
	{
		group.VerifyIsNotNull();
		return ClanMember.GetTotalNumberOfClanMembersByGroupID(group.Id);
	}

	public virtual IGroup GetClanMembership(IUser user)
	{
		user.VerifyIsNotNull();
		return GetClanMembershipByUserId(user.Id);
	}

	public virtual IGroup GetClanMembershipByUserId(long userId)
	{
		ClanMember clanMemberEntity = ClanMember.GetByUserID(userId);
		if (clanMemberEntity == null)
		{
			return null;
		}
		return _DomainFactories.GroupFactory.GetById(clanMemberEntity.GroupID);
	}

	internal virtual void CreateClanMembership(IGroupMembership groupMembership)
	{
		groupMembership.VerifyIsNotNull();
		if (ClanMember.CreateNew(groupMembership.Group.Id, groupMembership.User.Id) == null)
		{
			throw new Exception("Failed to create clan member entity for user " + groupMembership.User.Id + "in group " + groupMembership.Group.Id);
		}
		ClanEventPublisher.PublishUserJoinedClan(groupMembership.Group.Id, groupMembership.User.Id);
	}
}
