using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

/// <summary>
/// This class is used to track the participants of a particular conversation in Redis.
/// </summary>
internal class RedisConversationParticipantCache
{
	private readonly IRedisClient _RedisClient;

	internal static event Action OnParticipantCacheHit;

	internal static event Action OnParticipantCacheMiss;

	public RedisConversationParticipantCache(IRedisClient redisClient)
	{
		_RedisClient = redisClient;
	}

	public IReadOnlyCollection<RedisConversationParticipant> GetConversationParticipants(long conversationId, int startIndex, int maxRows)
	{
		string conversationParticipantCollectionKey = GetParticipantCollectionIdKey(conversationId);
		RedisValue[] array = _RedisClient.Execute(conversationParticipantCollectionKey, (IDatabase db) => db.SortedSetRangeByRank(conversationParticipantCollectionKey, startIndex, startIndex + maxRows));
		List<RedisConversationParticipant> conversationParticipants = new List<RedisConversationParticipant>();
		RedisValue[] array2 = array;
		foreach (RedisValue participantValue in array2)
		{
			string conversationParticipantKey = ConvertConversationParticipantValueToLookupKey(participantValue, conversationId);
			RedisConversationParticipant redisConversationParticipant = GetRedisConversationParticipant(_RedisClient.Execute(conversationParticipantKey, (IDatabase db) => db.HashGetAll(conversationParticipantKey)));
			if (redisConversationParticipant != null)
			{
				RedisConversationParticipantCache.OnParticipantCacheHit?.Invoke();
				conversationParticipants.Add(redisConversationParticipant);
				continue;
			}
			RedisConversationParticipantCache.OnParticipantCacheMiss?.Invoke();
			try
			{
				_RedisClient.Execute(conversationParticipantCollectionKey, (IDatabase db) => db.SortedSetRemove(conversationParticipantCollectionKey, participantValue));
			}
			catch (Exception)
			{
			}
		}
		return conversationParticipants;
	}

	public void AddConversationParticipants(long conversationId, IReadOnlyCollection<IParticipant> participants)
	{
		string conversationParticipantCollectionIdKey = GetParticipantCollectionIdKey(conversationId);
		DateTime now = DateTime.UtcNow;
		foreach (IParticipant participant in participants)
		{
			string sortedSetEntryValue = GetConversationParticipantSortedSetEntryValue(participant);
			_RedisClient.Execute(conversationParticipantCollectionIdKey, (IDatabase db) => db.SortedSetAdd(conversationParticipantCollectionIdKey, sortedSetEntryValue, now.Ticks));
			string conversationParticipantKey = GetConversationParticipantKey(conversationId, participant);
			_RedisClient.Execute(conversationParticipantKey, delegate(IDatabase db)
			{
				db.HashSet(conversationParticipantKey, GetHashEntries(participant, now));
			});
			_RedisClient.Execute(conversationParticipantKey, (IDatabase db) => db.KeyExpire(conversationParticipantKey, Settings.Default.ConversationParticipantExpirationTimespan));
		}
	}

	public void RemoveConversationParticipants(long conversationId, IReadOnlyCollection<IParticipant> participants)
	{
		string conversationParticipantCollectionIdKey = GetParticipantCollectionIdKey(conversationId);
		foreach (IParticipant participant in participants)
		{
			string sortedSetEntryValue = GetConversationParticipantSortedSetEntryValue(participant);
			_RedisClient.Execute(conversationParticipantCollectionIdKey, (IDatabase db) => db.SortedSetRemove(conversationParticipantCollectionIdKey, sortedSetEntryValue));
			string conversationParticipantKey = GetConversationParticipantKey(conversationId, participant);
			_RedisClient.Execute(conversationParticipantKey, (IDatabase db) => db.KeyDelete(conversationParticipantKey));
		}
	}

	public bool DoesContainParticipant(long conversationId, IParticipant participant)
	{
		string conversationParticipantKey = GetConversationParticipantKey(conversationId, participant);
		bool individualKeyExists = _RedisClient.Execute(conversationParticipantKey, (IDatabase db) => db.KeyExists(conversationParticipantKey));
		string conversationParticipantCollectionIdKey = GetParticipantCollectionIdKey(conversationId);
		string sortedSetEntryValue = GetConversationParticipantSortedSetEntryValue(participant);
		double? doesContainParticipant = _RedisClient.Execute(conversationParticipantCollectionIdKey, (IDatabase db) => db.SortedSetScore(conversationParticipantCollectionIdKey, sortedSetEntryValue));
		if (!doesContainParticipant.HasValue && individualKeyExists)
		{
			_RedisClient.Execute(conversationParticipantKey, (IDatabase db) => db.KeyDelete(conversationParticipantKey));
		}
		else if (!individualKeyExists && doesContainParticipant.HasValue)
		{
			_RedisClient.Execute(conversationParticipantCollectionIdKey, (IDatabase db) => db.SortedSetRemove(conversationParticipantCollectionIdKey, sortedSetEntryValue));
		}
		return doesContainParticipant.HasValue && individualKeyExists;
	}

	private static string GetParticipantCollectionIdKey(long conversationId)
	{
		return "SortedParticipants_ConversationId:" + conversationId;
	}

	private static string GetConversationParticipantSortedSetEntryValue(IParticipant participant)
	{
		return "ConversationParticipant_TargetId:" + participant.TargetId + "_TypeId:" + participant.TypeId;
	}

	private static string ConvertConversationParticipantValueToLookupKey(string value, long conversationId)
	{
		return value + "_ConversationId:" + conversationId;
	}

	private static string GetConversationParticipantKey(long conversationId, IParticipant participant)
	{
		return "ConversationParticipant_TargetId:" + participant.TargetId + "_TypeId:" + participant.TypeId + "_ConversationId:" + conversationId;
	}

	private static HashEntry[] GetHashEntries(IParticipant participant, DateTime dateAddedToConversation)
	{
		return new HashEntry[3]
		{
			new HashEntry("TypeId", participant.TypeId),
			new HashEntry("TargetId", participant.TargetId),
			new HashEntry("DateAdded", dateAddedToConversation.Ticks)
		};
	}

	private static RedisConversationParticipant GetRedisConversationParticipant(HashEntry[] hashEntries)
	{
		if (hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		return new RedisConversationParticipant
		{
			ParticipantTypeId = (int)dictionary["TypeId"],
			ParticipantTargetId = (long)dictionary["TargetId"],
			ConversationJoinTime = new DateTime((long)dictionary["DateAdded"], DateTimeKind.Utc)
		};
	}
}
