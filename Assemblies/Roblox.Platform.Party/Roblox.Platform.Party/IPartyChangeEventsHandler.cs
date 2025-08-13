using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party;

public interface IPartyChangeEventsHandler
{
	void OnPartyReadyToBeDeleted(Guid partyId);

	void OnPartyCreated(Guid partyId);

	void OnPartyInvitationAccepted(Guid partyId, IUser user);

	void OnPartyInvitationSent(Guid partyId, IUser user);

	void OnPartyMemberLeft(Guid partyId, IUser user);
}
