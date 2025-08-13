using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Universes;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public class UserPartyFactory : PartyFactory, IUserPartyFactory
{
	private readonly IRedisClient _RedisClient;

	public UserPartyFactory(IRedisClient redisClient, IUniverseFactory universeFactory, IUserFactory userFactory)
		: base(universeFactory, userFactory)
	{
		_RedisClient = redisClient;
	}

	protected override Guid[] GetPartyInvitations(IUser user, int startRow, int maxRows, IPlatform platform)
	{
		return PartyInvitation.GetPartyInvitations(_RedisClient, platform.ToWalledGarden(), user.Id, startRow, maxRows);
	}

	public new IParty GetPartyById(Guid partyId)
	{
		return base.GetPartyById(partyId);
	}

	public new DateTime? GetPartyJoinDate(IUser user, IParty party)
	{
		return base.GetPartyJoinDate(user, party);
	}

	public new DateTime? GetPartyInvitationDate(IUser currentUser, IParty party)
	{
		return base.GetPartyInvitationDate(currentUser, party);
	}

	public new IReadOnlyCollection<IParty> GetPendingPartiesForUser(IUser currentUser, IPlatform platform, int startRow, int maxRows)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		return base.GetPendingPartiesForUser(currentUser, platform, startRow, maxRows);
	}

	protected override Guid?[] GetPartyIdsFromConversationMap(long[] conversationIds, IPlatform platform)
	{
		return ConversationPartyMap.GetPartyIds(_RedisClient, conversationIds, platform.ToWalledGarden());
	}

	public new IReadOnlyCollection<IParty> GetPartiesForConversationIds(IUser currentUser, long[] conversationIds, IPlatform platform)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		return base.GetPartiesForConversationIds(currentUser, conversationIds, platform);
	}

	protected override Roblox.Platform.Party.Entities.UserParty GetUserPartyByUserId(IUser user, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, platform.ToWalledGarden());
	}

	public new IUserParty GetCurrentPartyForUser(IUser currentUser, IPlatform platform)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		return base.GetCurrentPartyForUser(currentUser, platform);
	}

	protected override DateTime? GetPartyInvitationDate(Guid partyId, WalledGarden walledGarden, IUser user)
	{
		return PartyInvitation.GetPartyInvitationDate(_RedisClient, walledGarden, partyId, user.Id);
	}

	protected override DateTime? GetPartyMemberJoinTimeFromPartyEntity(Guid partyId, long userId)
	{
		return Roblox.Platform.Party.Entities.Party.GetPartyMemberJoinTime(_RedisClient, partyId, userId);
	}

	protected override Roblox.Platform.Party.Entities.Party GetPartyEntity(Guid partyId)
	{
		return Roblox.Platform.Party.Entities.Party.Get(_RedisClient, partyId);
	}
}
