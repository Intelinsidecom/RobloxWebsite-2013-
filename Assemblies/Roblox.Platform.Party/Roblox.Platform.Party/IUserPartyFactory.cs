using System;
using System.Collections.Generic;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party;

public interface IUserPartyFactory
{
	IReadOnlyCollection<IParty> GetPendingPartiesForUser(IUser currentUser, IPlatform platform, int startRow, int maxRows);

	IReadOnlyCollection<IParty> GetPartiesForConversationIds(IUser currentUser, long[] conversationIds, IPlatform platform);

	IUserParty GetCurrentPartyForUser(IUser currentUser, IPlatform platform);

	IParty GetPartyById(Guid partyId);

	DateTime? GetPartyJoinDate(IUser user, IParty party);

	DateTime? GetPartyInvitationDate(IUser currentUser, IParty party);
}
