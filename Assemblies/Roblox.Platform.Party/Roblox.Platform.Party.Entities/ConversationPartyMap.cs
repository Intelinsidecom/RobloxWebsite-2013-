using System;
using System.Collections.Generic;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Party.Entities;

internal class ConversationPartyMap
{
	public static Action<IRedisClient, Guid> OnConversationPartyMapUpdated;

	public static void UpdateConversationPartyMapExpiry(IRedisClient redisClient, long conversationId, WalledGarden walledGarden, TimeSpan keyExpiry)
	{
		string key = GetConversationPartyMapKey(conversationId, walledGarden);
		redisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, keyExpiry));
	}

	public static void MapConversationToParty(IRedisClient redisClient, long conversationId, Guid partyId, WalledGarden walledGarden)
	{
		string key = GetConversationPartyMapKey(conversationId, walledGarden);
		redisClient.Execute(key, (IDatabase db) => db.StringSet(key, partyId.ToString()));
		OnConversationPartyMapUpdated?.Invoke(redisClient, partyId);
	}

	public static Guid? GetPartyId(IRedisClient redisClient, long conversationId, WalledGarden walledGarden)
	{
		string key = GetConversationPartyMapKey(conversationId, walledGarden);
		RedisValue value = redisClient.Execute(key, (IDatabase db) => db.StringGet(key));
		if (value == RedisValue.Null)
		{
			return null;
		}
		if (!Guid.TryParse(value, out var partyId))
		{
			return null;
		}
		return partyId;
	}

	public static Guid?[] GetPartyIds(IRedisClient redisClient, long[] conversationIds, WalledGarden walledGarden)
	{
		List<Guid?> partyIds = new List<Guid?>(conversationIds.Length);
		foreach (long conversationId in conversationIds)
		{
			partyIds.Add(GetPartyId(redisClient, conversationId, walledGarden));
		}
		return partyIds.ToArray();
	}

	public static void RemoveMapping(IRedisClient redisClient, long conversationId, WalledGarden walledGarden)
	{
		string key = GetConversationPartyMapKey(conversationId, walledGarden);
		redisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
	}

	private static string GetConversationPartyMapKey(long conversationId, WalledGarden walledGarden)
	{
		if (walledGarden == WalledGarden.General || walledGarden == WalledGarden.Xbox)
		{
			return "ConversationPartyMap_ConversationId:" + conversationId;
		}
		return $"CPMap_WG:{walledGarden}_ConvId:{conversationId}";
	}
}
