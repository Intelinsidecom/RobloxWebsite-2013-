using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Redis;
using Roblox.Time;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class RedisChatInteractionsCache
{
	private readonly IRedisClient _RedisClient;

	private readonly ILogger _Logger;

	private readonly IParticipant _SentinelChatParticipant = new Participant(0, 0L);

	private const long _SentinelChatParticipantScore = 0L;

	public RedisChatInteractionsCache(IRedisClient redisClient, ILogger logger)
	{
		_RedisClient = redisClient ?? throw new ArgumentNullException("redisClient");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public IReadOnlyCollection<IParticipant> GetUniqueChatParticipants(IParticipant participant, int startIndex, int maxRows, Func<IParticipant, IReadOnlyCollection<ChatInteraction>> getter)
	{
		bool isCacheMiss;
		IReadOnlyCollection<IParticipant> cachedResult = GetUniqueChatParticipantsFromCache(participant, startIndex, maxRows, out isCacheMiss);
		if (isCacheMiss)
		{
			PopulateChatInteractionsOnCacheMiss(participant, getter(participant));
		}
		if (!isCacheMiss)
		{
			return cachedResult;
		}
		bool isCacheMiss2;
		return GetUniqueChatParticipantsFromCache(participant, startIndex, maxRows, out isCacheMiss2);
	}

	public long GetUniqueChatParticipantsCount(IParticipant participant)
	{
		string sortedChatInteractionsCollectionKey = GetSortedChatInteractionsCollectionIdKey(participant);
		return _RedisClient.Execute(sortedChatInteractionsCollectionKey, (IDatabase db) => db.SortedSetLength(sortedChatInteractionsCollectionKey, 0.0, double.PositiveInfinity, Exclude.Start));
	}

	private IReadOnlyCollection<IParticipant> GetUniqueChatParticipantsFromCache(IParticipant participant, int startIndex, int maxRows, out bool isCacheMiss)
	{
		isCacheMiss = false;
		List<IParticipant> chatParticipants = new List<IParticipant>();
		string sortedChatInteractionsCollectionKey = GetSortedChatInteractionsCollectionIdKey(participant);
		SortedSetEntry[] chatInteractions = _RedisClient.Execute(sortedChatInteractionsCollectionKey, (IDatabase db) => db.SortedSetRangeByScoreWithScores(sortedChatInteractionsCollectionKey, 0.0, double.PositiveInfinity, Exclude.None, Order.Descending, startIndex, maxRows + 1));
		if (chatInteractions.Length == 0)
		{
			if (startIndex == 0)
			{
				isCacheMiss = true;
			}
			else
			{
				isCacheMiss = _RedisClient.Execute(sortedChatInteractionsCollectionKey, (IDatabase db) => db.KeyExists(sortedChatInteractionsCollectionKey));
			}
			return chatParticipants;
		}
		int chatInteractionsLength = chatInteractions.Length;
		int elementsToTake = (ParticipantComparer.AreEqual(_SentinelChatParticipant, GetChatParticipantFromSortedCollectionRedisValue(chatInteractions[chatInteractionsLength - 1].Element)) ? (chatInteractionsLength - 1) : chatInteractionsLength);
		if (elementsToTake > 0)
		{
			chatParticipants.AddRange(from chatInteraction in chatInteractions.Take(elementsToTake)
				select GetChatParticipantFromSortedCollectionRedisValue(chatInteraction.Element) into chatParticipant
				where chatParticipant != null
				select chatParticipant);
		}
		return chatParticipants;
	}

	internal void PopulateChatInteractionsOnCacheMiss(IParticipant participant, IReadOnlyCollection<ChatInteraction> chatInteractions)
	{
		if (participant == null || chatInteractions == null)
		{
			return;
		}
		string sortedChatInteractionsCollectionIdKey = GetSortedChatInteractionsCollectionIdKey(participant);
		SortedSetEntry[] sortedSetEntries = new SortedSetEntry[chatInteractions.Count + 1];
		int i = 0;
		sortedSetEntries[i++] = GetChatParticipantSentinelEntry();
		foreach (ChatInteraction chatParticipant in chatInteractions)
		{
			sortedSetEntries[i++] = new SortedSetEntry(GetChatInteractionsSortedSetEntryValue(chatParticipant.ChatParticipant), chatParticipant.LastInteracted.Ticks);
		}
		_RedisClient.Execute(sortedChatInteractionsCollectionIdKey, (IDatabase db) => db.SortedSetAdd(sortedChatInteractionsCollectionIdKey, sortedSetEntries));
		_RedisClient.Execute(sortedChatInteractionsCollectionIdKey, (IDatabase db) => db.KeyExpire(sortedChatInteractionsCollectionIdKey, Settings.Default.ChatInteractionsCacheCollectionExpiry));
	}

	public void CacheChatInteractionsForUser(IParticipant actorParticipant, IReadOnlyCollection<ChatInteraction> chatInteractions)
	{
		if (actorParticipant == null)
		{
			return;
		}
		SortedSetEntry[] chatParticipantsSortedSetEnties = GetSortedSetEntriesForChatInteractions(chatInteractions);
		SortedSetEntry[] array = chatParticipantsSortedSetEnties;
		if (array != null && array.Length != 0)
		{
			string key = GetSortedChatInteractionsCollectionIdKey(actorParticipant);
			_RedisClient.Execute(key, (IDatabase db) => db.SortedSetAdd(key, chatParticipantsSortedSetEnties, CommandFlags.FireAndForget));
		}
	}

	public void RemoveCachedChatInteractionsForUser(IParticipant actorParticipant, IReadOnlyCollection<IParticipant> participantInteractionsToRemove)
	{
		if (actorParticipant == null)
		{
			return;
		}
		RedisValue[] interactionsSortedSetValuesToRemove = participantInteractionsToRemove?.Select(GetChatInteractionsSortedSetEntryValue)?.ToArray();
		RedisValue[] array = interactionsSortedSetValuesToRemove;
		if (array != null && array.Length != 0)
		{
			string key = GetSortedChatInteractionsCollectionIdKey(actorParticipant);
			_RedisClient.Execute(key, (IDatabase db) => db.SortedSetRemove(key, interactionsSortedSetValuesToRemove, CommandFlags.FireAndForget));
		}
	}

	public void RemoveCachedChatInteractionForUser(IParticipant actorParticipant, IParticipant participantInteractionToRemove)
	{
		if (actorParticipant != null && participantInteractionToRemove != null)
		{
			string key = GetSortedChatInteractionsCollectionIdKey(actorParticipant);
			_RedisClient.Execute(key, (IDatabase db) => db.SortedSetRemove(key, GetChatInteractionsSortedSetEntryValue(participantInteractionToRemove), CommandFlags.FireAndForget));
		}
	}

	public void CacheChatInteractionForUser(IParticipant actorParticipant, ChatInteraction chatInteraction)
	{
		if (actorParticipant != null && chatInteraction?.ChatParticipant != null && !(chatInteraction.LastInteracted == null))
		{
			string key = GetSortedChatInteractionsCollectionIdKey(actorParticipant);
			_RedisClient.Execute(key, (IDatabase db) => db.SortedSetAdd(key, GetChatInteractionsSortedSetEntryValue(chatInteraction.ChatParticipant), GetChatInteractionSortedSetScore(chatInteraction.LastInteracted), CommandFlags.FireAndForget));
		}
	}

	public bool DoesChatInteractionsCacheExistForParticipant(IParticipant participant)
	{
		if (participant == null)
		{
			return false;
		}
		string key = GetSortedChatInteractionsCollectionIdKey(participant);
		return _RedisClient.Execute(key, (IDatabase db) => db.KeyExists(key));
	}

	public double? DoesChatInteractionsCacheExistForParticipants(IParticipant firstParticipant, IParticipant secondParticipant)
	{
		if (firstParticipant == null || secondParticipant == null)
		{
			return null;
		}
		string key = GetSortedChatInteractionsCollectionIdKey(firstParticipant);
		RedisValue value = GetChatInteractionsSortedSetEntryValue(secondParticipant);
		return _RedisClient.Execute(key, (IDatabase db) => db.SortedSetScore(key, value));
	}

	private SortedSetEntry GetChatParticipantSentinelEntry()
	{
		return new SortedSetEntry(GetChatInteractionsSortedSetEntryValue(_SentinelChatParticipant), 0.0);
	}

	private static SortedSetEntry[] GetSortedSetEntriesForChatInteractions(IReadOnlyCollection<ChatInteraction> chatInteractions)
	{
		List<SortedSetEntry> sortedSetEntries = new List<SortedSetEntry>();
		if (chatInteractions != null && chatInteractions.Count > 0)
		{
			sortedSetEntries.AddRange(from chatInteraction in chatInteractions
				where chatInteraction != null
				select new SortedSetEntry(GetChatInteractionsSortedSetEntryValue(chatInteraction.ChatParticipant), GetChatInteractionSortedSetScore(chatInteraction.LastInteracted)));
		}
		return sortedSetEntries.ToArray();
	}

	private static string GetSortedChatInteractionsCollectionIdKey(IParticipant participant)
	{
		return $"SortedDistinctChatInteractionsFor_ParticipantTypeId:{participant.TypeId}_ParticipantTargetId:{participant.TargetId}";
	}

	private static RedisValue GetChatInteractionsSortedSetEntryValue(IParticipant participant)
	{
		return JsonConvert.SerializeObject(participant);
	}

	private IParticipant GetChatParticipantFromSortedCollectionRedisValue(RedisValue redisValue)
	{
		try
		{
			return JsonConvert.DeserializeObject<Participant>(redisValue);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return null;
		}
	}

	private static double GetChatInteractionSortedSetScore(UtcInstant lastUpdated)
	{
		return lastUpdated.Ticks;
	}
}
