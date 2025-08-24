using System;
using System.Linq;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Party.Entities;

internal class PartyInvitation
{
	public static Action<IRedisClient, Guid> OnPartyInvitationUpdated;

	public static void UpdatePartyInvitationExpiry(IRedisClient redisClient, long userId, WalledGarden walledGarden, TimeSpan keyExpiry)
	{
		string partyInvitationsKey = GetPartyInvitationsByUserAndWalledGardenKey(userId, walledGarden);
		redisClient.Execute(partyInvitationsKey, (IDatabase db) => db.KeyExpire(partyInvitationsKey, keyExpiry));
	}

	public static void CreateNew(IRedisClient redisClient, WalledGarden walledGarden, Guid partyId, long recipientUserId, long senderUserId)
	{
		long sent = DateTime.UtcNow.Ticks;
		string partyInvitationsKey = GetPartyInvitationsByUserAndWalledGardenKey(recipientUserId, walledGarden);
		redisClient.Execute(partyInvitationsKey, (IDatabase db) => db.SortedSetAdd(partyInvitationsKey, partyId.ToString(), sent));
		OnPartyInvitationUpdated?.Invoke(redisClient, partyId);
	}

	public static bool DoesPartyInvitationExist(IRedisClient redisClient, WalledGarden walledGarden, Guid partyId, long recipientUserId)
	{
		string partyInvitationsKey = GetPartyInvitationsByUserAndWalledGardenKey(recipientUserId, walledGarden);
		return redisClient.Execute(partyInvitationsKey, (IDatabase db) => db.SortedSetScore(partyInvitationsKey, partyId.ToString())).HasValue;
	}

	public static DateTime? GetPartyInvitationDate(IRedisClient redisClient, WalledGarden walledGarden, Guid partyId, long recipientUserId)
	{
		string partyInvitationsKey = GetPartyInvitationsByUserAndWalledGardenKey(recipientUserId, walledGarden);
		double? score = redisClient.Execute(partyInvitationsKey, (IDatabase db) => db.SortedSetScore(partyInvitationsKey, partyId.ToString()));
		if (!score.HasValue)
		{
			return null;
		}
		return new DateTime((long)score.Value);
	}

	public static bool Remove(IRedisClient redisClient, WalledGarden walledGarden, Guid partyId, long userId)
	{
		string partyInvitationsKey = GetPartyInvitationsByUserAndWalledGardenKey(userId, walledGarden);
		return redisClient.Execute(partyInvitationsKey, (IDatabase db) => db.SortedSetRemove(partyInvitationsKey, partyId.ToString()));
	}

	public static Guid[] GetPartyInvitations(IRedisClient redisClient, WalledGarden walledGarden, long userId, int startRow, int maxRows)
	{
		string partyInvitationsKey = GetPartyInvitationsByUserAndWalledGardenKey(userId, walledGarden);
		return (from value in redisClient.Execute(partyInvitationsKey, (IDatabase db) => db.SortedSetRangeByScore(partyInvitationsKey, double.NegativeInfinity, double.PositiveInfinity, Exclude.None, Order.Descending, startRow, maxRows))
			select Guid.Parse(value)).ToArray();
	}

	private static string GetPartyInvitationsByUserAndWalledGardenKey(long userId, WalledGarden walledGarden)
	{
		return "PartyInvitations_UserId:" + userId + "_WalledGarden:" + walledGarden;
	}
}
