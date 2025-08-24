using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Chat.Properties;
using Roblox.Redis;
using Roblox.Time;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

/// <summary>
/// This class provides participant based lookups for conversations and has methods to help manage conversations for a particular participant.
/// TODO: Encapsulate redis calls and retry
/// </summary>
internal class RedisParticipantConversationCache
{
	internal delegate void ParticipantConversationCacheMissingEntriesDetected(long userId, IReadOnlyCollection<ConversationIdWithUpdatedDate> conversations);

	internal delegate void ParticipantAllConversationCacheMiss(long userId);

	private readonly IRedisClient _RedisClient;

	private readonly IInstantProvider _InstantProvider;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly Random _Random = new Random();

	private readonly object _RandomLock = new object();

	private const long _SentinelConversationId = 0L;

	private const long _SentinelConversationScore = 0L;

	internal static event Action OnConversationCacheHit;

	internal static event Action OnConversationCacheMiss;

	internal static event ParticipantConversationCacheMissingEntriesDetected OnParticipantConversationCacheMissingEntriesDetected;

	internal static event ParticipantAllConversationCacheMiss OnParticipantAllConversationCacheMiss;

	public RedisParticipantConversationCache(IRedisClient redisClient, IInstantProvider instantProvider, ISettings settings, ILogger logger)
	{
		_RedisClient = redisClient;
		_InstantProvider = instantProvider;
		_Settings = settings;
		_Logger = logger;
	}

	public bool TryToMarkConversationAsReadForParticipant(long conversationId, IParticipant participant)
	{
		MarkConversationAsReadForParticipant(participant, conversationId);
		return true;
	}

	public void UpdateParticipantConversationsForNewMessage(IConversationWithParticipants conversation, IParticipant messageSender)
	{
		UtcInstant currentInstant = _InstantProvider.GetCurrentUtcInstant();
		UpdateParticipantConversationScores(conversation.Participants, conversation.Id, currentInstant);
		IParticipant[] participants = conversation.Participants;
		foreach (IParticipant conversationParticipant in participants)
		{
			if (ParticipantComparer.AreEqual(conversationParticipant, messageSender))
			{
				MarkConversationAsReadForParticipant(conversationParticipant, conversation.Id);
			}
			else
			{
				MarkConversationAsUnreadForParticipant(conversationParticipant, conversation.Id, currentInstant);
			}
		}
	}

	public IReadOnlyCollection<ConversationIdWithStatus> GetConversationIds(IParticipant participant, int startIndex, int maxRows, Func<IParticipant, IReadOnlyCollection<ConversationIdWithUpdatedDate>> getter)
	{
		if (CacheConsistencyCheckRequired(participant))
		{
			CheckCacheConsistency(participant, getter(participant));
		}
		if (GetConversationIds(participant, startIndex, maxRows) == null)
		{
			CacheParticipantsConversations(participant, getter(participant));
			RedisParticipantConversationCache.OnConversationCacheMiss?.Invoke();
		}
		else
		{
			RedisParticipantConversationCache.OnConversationCacheHit?.Invoke();
		}
		return GetConversationIds(participant, startIndex, maxRows) ?? new List<ConversationIdWithStatus>();
	}

	public long GetConversationCount(IParticipant participant, ConversationStatusFilter statusFilter, Func<IParticipant, IReadOnlyCollection<ConversationIdWithUpdatedDate>> getter)
	{
		if (!GetConversationCount(participant, statusFilter).HasValue)
		{
			IReadOnlyCollection<ConversationIdWithUpdatedDate> conversationIds = getter(participant);
			CacheParticipantsConversations(participant, conversationIds);
			RedisParticipantConversationCache.OnConversationCacheMiss?.Invoke();
		}
		else
		{
			RedisParticipantConversationCache.OnConversationCacheHit?.Invoke();
		}
		return GetConversationCount(participant, statusFilter) ?? 0;
	}

	public bool DoesThisParticipantsConversationCollectionExistInCache(IParticipant participant)
	{
		return DoesThisParticipantsConversationCollectionExistInCache(_RedisClient, participant);
	}

	/// <summary>
	/// When new participants are added to a conversation, this should be called so that if any of those participants have their
	/// conversation collection cached, it can be updated with the new conversation they are a part of
	/// </summary>
	/// <param name="conversationId"></param>
	/// <param name="newParticipants"></param>
	public void UpdateForNewConversationParticipants(long conversationId, IReadOnlyCollection<IParticipant> newParticipants)
	{
		UtcInstant currentInstant = _InstantProvider.GetCurrentUtcInstant();
		UpdateParticipantConversationScores(newParticipants, conversationId, currentInstant);
		foreach (IParticipant newParticipant in newParticipants)
		{
			MarkConversationAsUnreadForParticipant(newParticipant, conversationId, currentInstant);
		}
	}

	/// <summary>
	/// When participants are removed from a conversation, this should be called so that the conversation is removed from the participants'
	/// conversation collections
	/// </summary>
	/// <param name="conversationId"></param>
	/// <param name="removedParticipants"></param>
	public void UpdateForRemovedConversationParticipants(long conversationId, IReadOnlyCollection<IParticipant> removedParticipants)
	{
		foreach (IParticipant participant in removedParticipants)
		{
			string sortedConversationIdsKey = GetSortedConversationCollectionIdKey(participant);
			_RedisClient.Execute(sortedConversationIdsKey, (IDatabase db) => db.SortedSetRemove(sortedConversationIdsKey, conversationId));
			MarkConversationAsReadForParticipant(participant, conversationId);
		}
	}

	/// <summary>
	/// When an event on a participant's conversations cache miss is invoked, this method is used to return the conversations still eligible for restoring its score
	/// Scenario 1: conversationsMissingInCache.MissingConversationIds == null =&gt; All cache conversations missed
	///             return all conversations with score less than event's timestamp
	/// Scenario 2: conversationsMissingInCache.MissingConversationIds != null =&gt; specific conversations in cache missed
	///             use missing conversation's lowest and highest score to query redis
	/// </summary>
	/// <param name="participant"></param>
	/// <param name="conversationsMissingInCache"></param>
	/// <returns></returns>
	public IReadOnlyCollection<ConversationIdWithScore> GetCacheMissParticipantConversationsEligibleForScoreUpdate(IParticipant participant, ConversationsMissingInCache conversationsMissingInCache)
	{
		if (participant != null)
		{
			_ = participant.TargetId;
			if (conversationsMissingInCache != null)
			{
				string participantConversationKey = GetSortedConversationCollectionIdKey(participant);
				int start = 0;
				double minScore = conversationsMissingInCache.MinConversationScoreInRange;
				double maxScore = conversationsMissingInCache.MaxConversationScoreInRange;
				HashSet<long> missingConversationIds = ((conversationsMissingInCache.MissingConversationIds != null) ? new HashSet<long>(conversationsMissingInCache.MissingConversationIds) : null);
				List<ConversationIdWithScore> missingConversationsWithScore = new List<ConversationIdWithScore>();
				SortedSetEntry[] missingConversationsInCache;
				do
				{
					missingConversationsInCache = _RedisClient.Execute(participantConversationKey, (IDatabase db) => db.SortedSetRangeByScoreWithScores(participantConversationKey, minScore, maxScore, Exclude.None, Order.Descending, start, 50L));
					missingConversationsWithScore.AddRange(from _003C_003Eh__TransparentIdentifier0 in missingConversationsInCache.Select(delegate(SortedSetEntry missingConversation)
						{
							SortedSetEntry sortedSetEntry = missingConversation;
							return new
							{
								missingConversation = missingConversation,
								conversationId = (long)sortedSetEntry.Element
							};
						})
						where _003C_003Eh__TransparentIdentifier0.conversationId != 0L && (missingConversationIds?.Contains(_003C_003Eh__TransparentIdentifier0.conversationId) ?? true)
						select new ConversationIdWithScore(_003C_003Eh__TransparentIdentifier0.conversationId, (long)_003C_003Eh__TransparentIdentifier0.missingConversation.Score));
					start += missingConversationsInCache.Length;
				}
				while (missingConversationsInCache != null && missingConversationsInCache.Length >= 50 && missingConversationsWithScore.Count < Settings.Default.MaxConversationsPerUserToUpdateScoreOnCacheMiss);
				return missingConversationsWithScore;
			}
		}
		return null;
	}

	/// <summary>
	/// update a participant's conversation with correct score/ last updated timestamp
	/// </summary>
	/// <param name="participant"></param>
	/// <param name="conversationId"></param>
	/// <param name="score"></param>
	public void UpdateParticipantConversationScore(IParticipant participant, long conversationId, long score)
	{
		if (DoesThisParticipantsConversationCollectionExistInCache(participant))
		{
			string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
			_RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.SortedSetAdd(sortedConversationIdKey, conversationId, score));
		}
	}

	private void CacheParticipantsConversations(IParticipant participant, IReadOnlyCollection<ConversationIdWithUpdatedDate> conversationIdsAndDates)
	{
		string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
		SortedSetEntry[] sortedSetEntries = new SortedSetEntry[conversationIdsAndDates.Count + 1];
		int i = 0;
		sortedSetEntries[i++] = GetParticipantConversationSentinelEntry();
		foreach (ConversationIdWithUpdatedDate entry in conversationIdsAndDates)
		{
			sortedSetEntries[i++] = new SortedSetEntry(entry.ConversationId, GetScoreForConversation(entry.Updated));
		}
		_RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.SortedSetAdd(sortedConversationIdKey, sortedSetEntries));
	}

	private void CheckCacheConsistency(IParticipant participant, IReadOnlyCollection<ConversationIdWithUpdatedDate> primarySource)
	{
		try
		{
			string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
			RedisValue[] existingKeys = _RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.SortedSetRangeByRank(sortedConversationIdKey, 0L, -1L));
			if (!existingKeys.Any())
			{
				CacheParticipantsConversations(participant, primarySource);
				RedisParticipantConversationCache.OnConversationCacheMiss?.Invoke();
				if (participant != null)
				{
					RedisParticipantConversationCache.OnParticipantAllConversationCacheMiss?.Invoke(participant.TargetId);
				}
			}
			else
			{
				HashSet<long> existingKeyHashSet = new HashSet<long>(existingKeys.Select((RedisValue x) => (long)x));
				List<ConversationIdWithUpdatedDate> missingEntries = new List<ConversationIdWithUpdatedDate>();
				foreach (ConversationIdWithUpdatedDate primaryEntry in primarySource)
				{
					if (!existingKeyHashSet.Contains(primaryEntry.ConversationId))
					{
						missingEntries.Add(primaryEntry);
					}
				}
				RedisParticipantConversationCache.OnConversationCacheHit?.Invoke();
				if (missingEntries.Any())
				{
					CacheParticipantsConversations(participant, missingEntries);
					try
					{
						RedisParticipantConversationCache.OnConversationCacheMiss?.Invoke();
						if (participant != null)
						{
							RedisParticipantConversationCache.OnParticipantConversationCacheMissingEntriesDetected?.Invoke(participant.TargetId, missingEntries);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			RemoveInvalidUnreadConversations(participant, primarySource);
			SetNewCheckCacheConsistencyKey(participant);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}

	/// <summary>
	/// Find all the valid conversations that are marked as unread.
	/// If that number is lower than the number of fields in the hash, then there are invalid
	/// conversations in the hash, so we should create a new hash without the extra fields
	/// </summary>
	private void RemoveInvalidUnreadConversations(IParticipant participant, IReadOnlyCollection<ConversationIdWithUpdatedDate> primarySource)
	{
		int redisOperationBatchSize = 50;
		long totalUnreadConversations = GetUnreadConversationCount(participant);
		if (totalUnreadConversations == 0L)
		{
			return;
		}
		string unreadKey = GetParticipantUnreadConversationHashKey(participant);
		List<long> primaryConversationIds = primarySource.Select((ConversationIdWithUpdatedDate x) => x.ConversationId).ToList();
		HashSet<Tuple<long, RedisValue>> validUnreadConversations = new HashSet<Tuple<long, RedisValue>>();
		for (int j = 0; j < primaryConversationIds.Count; j += redisOperationBatchSize)
		{
			List<long> batch2 = primaryConversationIds.Skip(j).Take(redisOperationBatchSize).ToList();
			RedisValue[] unreadConversationLookupResults = _RedisClient.Execute(unreadKey, (IDatabase db) => db.HashGet(unreadKey, ((IEnumerable<long>)batch2).Select((Func<long, RedisValue>)((long x) => x)).ToArray()));
			(from x in batch2.Zip(unreadConversationLookupResults, (long convId, RedisValue redisValue) => new Tuple<long, RedisValue>(convId, redisValue))
				where !x.Item2.IsNull
				select x).ToList().ForEach(delegate(Tuple<long, RedisValue> id)
			{
				validUnreadConversations.Add(id);
			});
		}
		if (validUnreadConversations.Count >= totalUnreadConversations)
		{
			return;
		}
		_RedisClient.Execute(unreadKey, (IDatabase db) => db.KeyDelete(unreadKey));
		for (int i = 0; i < validUnreadConversations.Count; i += redisOperationBatchSize)
		{
			IEnumerable<Tuple<long, RedisValue>> batch = validUnreadConversations.Skip(i).Take(redisOperationBatchSize);
			IEnumerable<HashEntry> entries = batch.Select((Tuple<long, RedisValue> x) => new HashEntry(x.Item1, x.Item2));
			_RedisClient.Execute(unreadKey, delegate(IDatabase db)
			{
				db.HashSet(unreadKey, entries.ToArray());
			});
		}
	}

	/// <summary>
	/// Set a new flag to expire after the specified frequency plus a random interval up to 50% of the interval
	/// </summary>
	/// <param name="participant"></param>
	private void SetNewCheckCacheConsistencyKey(IParticipant participant)
	{
		string key = GetParticipantCacheConsistencyCheckKey(participant);
		TimeSpan baseFrequency = _Settings.PeriodicParticipantConversationCacheConsistencyCheckFrequency;
		int random = GetRandom(Convert.ToInt32(baseFrequency.TotalMinutes) / 2);
		TimeSpan expiry = baseFrequency.Add(TimeSpan.FromMinutes(random));
		_RedisClient.Execute(key, (IDatabase db) => db.StringSet(key, true, expiry));
	}

	private bool DoesThisParticipantsConversationCollectionExistInCache(IRedisClient redisClient, IParticipant participant)
	{
		string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
		return redisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.KeyExists(sortedConversationIdKey));
	}

	private IReadOnlyCollection<ConversationIdWithStatus> GetConversationIds(IParticipant participant, int startIndex, int maxRows)
	{
		string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
		SortedSetEntry[] conversationsWithScore = _RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.SortedSetRangeByScoreWithScores(sortedConversationIdKey, double.NegativeInfinity, double.PositiveInfinity, Exclude.None, Order.Descending, startIndex, maxRows + 1));
		if (conversationsWithScore.Length == 0)
		{
			if (startIndex == 0)
			{
				return null;
			}
			if (!_RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.KeyExists(sortedConversationIdKey)))
			{
				return null;
			}
			return new List<ConversationIdWithStatus>();
		}
		List<ConversationIdWithStatus> conversationsWithStatus = new List<ConversationIdWithStatus>(conversationsWithScore.Length);
		HashSet<long> unreadConversations = GetUnreadConversationIds(participant, conversationsWithScore.Select((SortedSetEntry x) => (long)x.Element).ToList());
		bool sentinelEntryWasPartOfResultSet = false;
		SortedSetEntry[] array = conversationsWithScore;
		foreach (SortedSetEntry entry in array)
		{
			long conversationId = (long)entry.Element;
			if (conversationId == 0L)
			{
				sentinelEntryWasPartOfResultSet = true;
				continue;
			}
			ConversationStatus status = ((!unreadConversations.Contains(conversationId)) ? ConversationStatus.Read : ConversationStatus.Unread);
			conversationsWithStatus.Add(new ConversationIdWithStatus(conversationId, status));
		}
		if (!sentinelEntryWasPartOfResultSet && conversationsWithStatus.Any())
		{
			if (conversationsWithScore[0].Score < 0.0)
			{
				conversationsWithStatus.RemoveAt(0);
			}
			else
			{
				conversationsWithStatus.RemoveAt(conversationsWithStatus.Count - 1);
			}
		}
		return conversationsWithStatus;
	}

	private long? GetConversationCount(IParticipant participant, ConversationStatusFilter filter)
	{
		string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
		if (filter == ConversationStatusFilter.Unread)
		{
			long unreadCount = GetUnreadConversationCount(participant);
			if (unreadCount == 0L && !_RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.KeyExists(sortedConversationIdKey)))
			{
				return null;
			}
			return unreadCount;
		}
		double inclusiveStartScore = double.NegativeInfinity;
		long conversationCount = _RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.SortedSetLength(sortedConversationIdKey, inclusiveStartScore));
		if (conversationCount == 0L)
		{
			return null;
		}
		return conversationCount - 1;
	}

	private static SortedSetEntry GetParticipantConversationSentinelEntry()
	{
		return new SortedSetEntry(0L, 0.0);
	}

	private long GetScoreForConversation(UtcInstant lastUpdated)
	{
		return lastUpdated.Ticks;
	}

	private bool CacheConsistencyCheckRequired(IParticipant participant)
	{
		if (participant.TargetId % 100 >= _Settings.PeriodicParticipantConversationCacheConsistencyCheckRollout)
		{
			return false;
		}
		try
		{
			string key = GetParticipantCacheConsistencyCheckKey(participant);
			return !_RedisClient.Execute(key, (IDatabase db) => db.KeyExists(key));
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
			return false;
		}
	}

	private void UpdateParticipantConversationScores(IEnumerable<IParticipant> participants, long conversationId, UtcInstant updateTime)
	{
		long score = GetScoreForConversation(updateTime);
		foreach (IParticipant participant in participants)
		{
			if (DoesThisParticipantsConversationCollectionExistInCache(participant))
			{
				string sortedConversationIdKey = GetSortedConversationCollectionIdKey(participant);
				_RedisClient.Execute(sortedConversationIdKey, (IDatabase db) => db.SortedSetAdd(sortedConversationIdKey, conversationId, score));
			}
		}
	}

	private void MarkConversationAsReadForParticipant(IParticipant participant, long conversationId)
	{
		string unreadKey = GetParticipantUnreadConversationHashKey(participant);
		_RedisClient.Execute(unreadKey, (IDatabase db) => db.HashDelete(unreadKey, conversationId));
	}

	private void MarkConversationAsUnreadForParticipant(IParticipant participant, long conversationId, UtcInstant updateTime)
	{
		if (DoesThisParticipantsConversationCollectionExistInCache(participant))
		{
			string unreadKey = GetParticipantUnreadConversationHashKey(participant);
			_RedisClient.Execute(unreadKey, (IDatabase db) => db.HashSet(unreadKey, conversationId, updateTime.Ticks));
		}
	}

	private long GetUnreadConversationCount(IParticipant participant)
	{
		string unreadConversationKey = GetParticipantUnreadConversationHashKey(participant);
		return _RedisClient.Execute(unreadConversationKey, (IDatabase db) => db.HashLength(unreadConversationKey));
	}

	private HashSet<long> GetUnreadConversationIds(IParticipant participant, List<long> conversationIds)
	{
		HashSet<long> unreadConversations = new HashSet<long>();
		string unreadKey = GetParticipantUnreadConversationHashKey(participant);
		RedisValue[] matchingFields = _RedisClient.Execute(unreadKey, (IDatabase db) => db.HashGet(unreadKey, ((IEnumerable<long>)conversationIds).Select((Func<long, RedisValue>)((long x) => x)).ToArray()));
		for (int i = 0; i < matchingFields.Length; i++)
		{
			if (!matchingFields[i].IsNull)
			{
				unreadConversations.Add(conversationIds[i]);
			}
		}
		return unreadConversations;
	}

	private int GetRandom(int maximum)
	{
		lock (_RandomLock)
		{
			return _Random.Next(maximum);
		}
	}

	private static string GetParticipantCacheConsistencyCheckKey(IParticipant participant)
	{
		return "SortedConversations_CacheConsistencyCheck_ParticipantTypeId:" + participant.TypeId + "_ParticipantTargetId:" + participant.TargetId;
	}

	private static string GetSortedConversationCollectionIdKey(IParticipant participant)
	{
		return "SortedConversations_ParticipantTypeId:" + participant.TypeId + "_ParticipantTargetId:" + participant.TargetId;
	}

	private static string GetParticipantUnreadConversationHashKey(IParticipant participant)
	{
		return "UnreadConv_PTypeId:" + participant.TypeId + "_PTargetId:" + participant.TargetId;
	}
}
