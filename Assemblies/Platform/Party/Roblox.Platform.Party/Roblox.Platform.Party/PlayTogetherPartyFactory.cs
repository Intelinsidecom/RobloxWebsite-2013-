using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Party.Interface;
using Roblox.Platform.Universes;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public class PlayTogetherPartyFactory : PartyFactory, IPlayTogetherPartyFactory
{
	private readonly IRedisClient _RedisClient;

	public PlayTogetherPartyFactory(IRedisClient redisClient, IUniverseFactory universeFactory, IUserFactory userFactory)
		: base(universeFactory, userFactory)
	{
		_RedisClient = redisClient;
	}

	protected override Guid[] GetPartyInvitations(IUser user, int startRow, int maxRows, IPlatform platform)
	{
		return PartyInvitation.GetPartyInvitations(_RedisClient, WalledGarden.PlayTogether, user.Id, startRow, maxRows);
	}

	protected override Guid?[] GetPartyIdsFromConversationMap(long[] conversationIds, IPlatform platform)
	{
		return ConversationPartyMap.GetPartyIds(_RedisClient, conversationIds, WalledGarden.PlayTogether);
	}

	public new IReadOnlyCollection<IParty> GetPartiesForConversationIds(IUser currentUser, long[] conversationIds, IPlatform platform)
	{
		return base.GetPartiesForConversationIds(currentUser, conversationIds, platform);
	}

	protected override Roblox.Platform.Party.Entities.UserParty GetUserPartyByUserId(IUser user, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, WalledGarden.PlayTogether);
	}

	public new IUserParty GetCurrentPartyForUser(IUser currentUser, IPlatform platform)
	{
		return base.GetCurrentPartyForUser(currentUser, platform);
	}

	protected override DateTime? GetPartyInvitationDate(Guid partyId, WalledGarden walledGarden, IUser user)
	{
		return PartyInvitation.GetPartyInvitationDate(_RedisClient, WalledGarden.PlayTogether, partyId, user.Id);
	}

	protected override DateTime? GetPartyMemberJoinTimeFromPartyEntity(Guid partyId, long userId)
	{
		return Roblox.Platform.Party.Entities.Party.GetPartyMemberJoinTime(_RedisClient, partyId, userId);
	}

	protected override Roblox.Platform.Party.Entities.Party GetPartyEntity(Guid partyId)
	{
		return Roblox.Platform.Party.Entities.Party.Get(_RedisClient, partyId);
	}

	public IReadOnlyCollection<IParty> GetParties(IUser currentUser, Guid[] partyIds)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("currentUser cannot be null");
		}
		return GetFilteredPartiesForUser(currentUser, partyIds);
	}
}
