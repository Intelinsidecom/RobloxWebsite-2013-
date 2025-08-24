using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

internal class ClanInvitationFactory
{
	private readonly GroupDomainFactories _DomainFactories;

	public ClanInvitationFactory(GroupDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new ArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	private IClanInvitation Translate(Roblox.Platform.Groups.Entities.ClanInvitation clanInvitationEntity)
	{
		return new ClanInvitation(clanInvitationEntity.ID, clanInvitationEntity.GroupID, clanInvitationEntity.UserID, clanInvitationEntity.Created, _DomainFactories);
	}

	internal IClanInvitation CreateNew(IGroup group, IUser user)
	{
		group.VerifyIsNotNull();
		user.VerifyIsNotNull();
		Roblox.Platform.Groups.Entities.ClanInvitation clanInvitationEntity = Roblox.Platform.Groups.Entities.ClanInvitation.CreateNew(group.Id, user.Id);
		return Translate(clanInvitationEntity);
	}

	internal IEnumerable<IClanInvitation> GetClanInvitationsByGroup(IGroup group, int index, int count)
	{
		group.VerifyIsNotNull();
		return Roblox.Platform.Groups.Entities.ClanInvitation.GetClanInvitationsByGroupID_Paged(group.Id, index, count).Select(Translate);
	}

	internal virtual int GetTotalPendingClanInvitationsByGroup(IGroup group)
	{
		group.VerifyIsNotNull();
		return Roblox.Platform.Groups.Entities.ClanInvitation.GetTotalNumberOfClanInvitationsByGroupID(group.Id);
	}

	internal IClanInvitation GetClanInvitationForUser(IGroup group, IUser user)
	{
		group.VerifyIsNotNull();
		user.VerifyIsNotNull();
		Roblox.Platform.Groups.Entities.ClanInvitation clanInvitationEntity = Roblox.Platform.Groups.Entities.ClanInvitation.GetByGroupIDUserID(group.Id, user.Id);
		if (clanInvitationEntity == null)
		{
			return null;
		}
		return Translate(clanInvitationEntity);
	}
}
