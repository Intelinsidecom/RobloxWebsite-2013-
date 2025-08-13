using System;
using System.Collections.Generic;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party.Interface;

public interface IPlayTogetherPartyFactory
{
	IReadOnlyCollection<IParty> GetPartiesForConversationIds(IUser currentUser, long[] conversationIds, IPlatform platform);

	IUserParty GetCurrentPartyForUser(IUser currentUser, IPlatform platform);

	IReadOnlyCollection<IParty> GetParties(IUser currentUser, Guid[] partyIds);
}
