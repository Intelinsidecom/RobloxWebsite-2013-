using System;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Party.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public class RedisEventsHandler
{
	public void Register()
	{
		Roblox.Platform.Party.Entities.Party.OnPartyUpdated += OnAnyPartyEntityUpdateHandler;
		Roblox.Platform.Party.Entities.UserParty.OnUserPartyUpdated = (Action<IRedisClient, long, WalledGarden>)Delegate.Combine(Roblox.Platform.Party.Entities.UserParty.OnUserPartyUpdated, new Action<IRedisClient, long, WalledGarden>(OnUserPartyUpdateHandler));
		PartyInvitation.OnPartyInvitationUpdated = (Action<IRedisClient, Guid>)Delegate.Combine(PartyInvitation.OnPartyInvitationUpdated, new Action<IRedisClient, Guid>(OnAnyPartyEntityUpdateHandler));
		ConversationPartyMap.OnConversationPartyMapUpdated = (Action<IRedisClient, Guid>)Delegate.Combine(ConversationPartyMap.OnConversationPartyMapUpdated, new Action<IRedisClient, Guid>(OnAnyPartyEntityUpdateHandler));
	}

	public void OnAnyPartyEntityUpdateHandler(IRedisClient redisClient, Guid partyId)
	{
		Roblox.Platform.Party.Entities.Party.UpdatePartyExpiry(redisClient, partyId, Settings.Default.PartyRedisExpiryTimespan);
		Roblox.Platform.Party.Entities.Party.UpdatePartyMembersExpiry(redisClient, partyId, Settings.Default.PartyRedisExpiryTimespan);
		Roblox.Platform.Party.Entities.Party party = Roblox.Platform.Party.Entities.Party.Get(redisClient, partyId);
		long[] memberUserIds = party.MemberUserIds;
		foreach (long userId in memberUserIds)
		{
			Roblox.Platform.Party.Entities.UserParty.UpdateUserPartyExpiry(redisClient, partyId, userId, party.WalledGarden, Settings.Default.UserPartyRedisExpiryTimespan);
		}
		memberUserIds = party.PendingUserIds;
		foreach (long userId2 in memberUserIds)
		{
			PartyInvitation.UpdatePartyInvitationExpiry(redisClient, userId2, party.WalledGarden, Settings.Default.PartyInvitationExpiryTimespan);
		}
		if (party.ConversationId.HasValue)
		{
			ConversationPartyMap.UpdateConversationPartyMapExpiry(redisClient, party.ConversationId.Value, party.WalledGarden, Settings.Default.ConversationPartyMapExpiryTimespan);
		}
	}

	public void OnUserPartyUpdateHandler(IRedisClient redisClient, long userId, WalledGarden walledGarden)
	{
		Roblox.Platform.Party.Entities.UserParty party = Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(redisClient, userId, walledGarden);
		OnAnyPartyEntityUpdateHandler(redisClient, party.PartyId);
	}
}
