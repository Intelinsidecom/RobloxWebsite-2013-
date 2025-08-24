using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Data;
using Roblox.Platform.Social.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Social.PlayerInteractions;

internal class PlayerInteractionRedisAccessor : IPlayerInteractionDataAccessor
{
	private static int _AsyncThrottleCounter;

	private readonly IRedisClient _RedisClient;

	private readonly IRedisClient _RedisClientWithConnectionPool;

	private const char _Separator = '|';

	public int MaxPlayerInteractionsToStore => Settings.Default.MaxPlayerInteractionsToStore;

	private bool IsPlayerInteractionsRedisConnectionPoolEnabled => Settings.Default.IsPlayerInteractionsRedisConnectionPoolEnabled;

	private IRedisClient PlayerInteractionRedisClient
	{
		get
		{
			if (!IsPlayerInteractionsRedisConnectionPoolEnabled)
			{
				return _RedisClient;
			}
			return _RedisClientWithConnectionPool;
		}
	}

	public PlayerInteractionRedisAccessor(IRedisClient redisClient, IRedisClient redisClientWithConnectionPool)
	{
		_RedisClient = redisClient;
		_RedisClientWithConnectionPool = redisClientWithConnectionPool;
	}

	public IEnumerable<PlayerInteraction> GetRecentPlayerInteractions(long userId, int startIndex, int maxRows)
	{
		string lookupKey = GetRecentPlayerInteractionsLookupKey(userId);
		return PlayerInteractionRedisClient.Execute(lookupKey, (IDatabase db) => db.SortedSetRangeByScoreWithScores(lookupKey, 0.0, double.PositiveInfinity, Exclude.None, Order.Descending, startIndex, maxRows)).Select(TranslateSortedSetEntry);
	}

	public int GetTotalRecentPlayerInteractionCount(long userId)
	{
		string lookupKey = GetRecentPlayerInteractionsLookupKey(userId);
		return (int)PlayerInteractionRedisClient.Execute(lookupKey, (IDatabase db) => db.SortedSetLength(lookupKey));
	}

	public void UpdateRecentPlayerInteractions(long userId, IReadOnlyCollection<long> otherUserIds, long placeId, DateTime interactionTime)
	{
		string lookupKey = GetRecentPlayerInteractionsLookupKey(userId);
		List<SortedSetEntry> newPlayerInteractionEntries = new List<SortedSetEntry>(otherUserIds.Count);
		foreach (long otherUserId in otherUserIds)
		{
			newPlayerInteractionEntries.Add(BuildSortedSetEntry(otherUserId, placeId, interactionTime));
		}
		PlayerInteractionRedisClient.Execute(lookupKey, (IDatabase db) => db.SortedSetAdd(lookupKey, newPlayerInteractionEntries.ToArray(), GetCommandFlags()));
		long start = MaxPlayerInteractionsToStore * -10;
		long end = MaxPlayerInteractionsToStore * -1 - 1;
		PlayerInteractionRedisClient.Execute(lookupKey, (IDatabase db) => db.SortedSetRemoveRangeByRank(lookupKey, start, end, GetCommandFlags()));
	}

	public void DeleteAllPlayerInteractions(long userId)
	{
		string lookUpKey = GetRecentPlayerInteractionsLookupKey(userId);
		PlayerInteractionRedisClient.Execute(lookUpKey, (IDatabase db) => db.KeyDelete(lookUpKey));
	}

	public void RefreshKeyExpiry(long userId)
	{
		string lookupKey = GetRecentPlayerInteractionsLookupKey(userId);
		PlayerInteractionRedisClient.Execute(lookupKey, (IDatabase db) => db.KeyExpire(lookupKey, Settings.Default.PlayerInteractionsTTL, GetCommandFlags()));
	}

	private static string GetRecentPlayerInteractionsLookupKey(long userId)
	{
		return "Interactions_UserId:" + userId;
	}

	private static CommandFlags GetCommandFlags()
	{
		CommandFlags commandFlags = CommandFlags.FireAndForget;
		int asyncThrottleLimit = Settings.Default.PlayerInteractionsRedisAsyncThrottleLimit;
		if (_AsyncThrottleCounter++ % asyncThrottleLimit == 0)
		{
			commandFlags = CommandFlags.None;
			_AsyncThrottleCounter = 0;
		}
		return commandFlags;
	}

	private static PlayerInteraction TranslateSortedSetEntry(SortedSetEntry sortedSetEntry)
	{
		string[] elements = sortedSetEntry.Element.ToString().Split('|');
		if (elements.Length != 2 || !long.TryParse(elements[0], out var userId) || !long.TryParse(elements[1], out var placeId))
		{
			throw new DataIntegrityException("Player Interaction entry is malformed: " + sortedSetEntry.Element);
		}
		return new PlayerInteraction(userId, placeId, new DateTime((long)sortedSetEntry.Score));
	}

	private static SortedSetEntry BuildSortedSetEntry(long userId, long placeId, DateTime interactionTime)
	{
		string text = userId.ToString() + "|" + placeId;
		return new SortedSetEntry(score: interactionTime.Ticks, element: text);
	}
}
