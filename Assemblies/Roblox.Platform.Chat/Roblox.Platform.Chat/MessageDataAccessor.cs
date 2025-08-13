using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class MessageDataAccessor : IMessageDataAccessor
{
	private readonly IRedisMessageCache _RedisMessageCache;

	private readonly IPersistedMessageFactory _PersistedMessageFactory;

	private const string _EmptyStringMarker = "Empty";

	private readonly IInstantProvider _InstantProvider;

	private readonly ISettings _Settings;

	public static event Action<long> OnMessagesMissingFromCache;

	public static event Action<int> OnRedisHit;

	public static event Action<int> OnRedisMiss;

	public MessageDataAccessor(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, ILogger logger, IInstantProvider instantProvider)
		: this(new RedisMessageCache(chatRedisClients, instantProvider, logger), new PersistedMessageFactory(dynamoDbClient, logger), instantProvider, Settings.Default)
	{
	}

	internal MessageDataAccessor(IRedisMessageCache redisMessageCache, IPersistedMessageFactory persistedMessageFactory, IInstantProvider instantProvider, ISettings settings)
	{
		_RedisMessageCache = redisMessageCache ?? throw new PlatformArgumentNullException("redisMessageCache");
		_PersistedMessageFactory = persistedMessageFactory ?? throw new PlatformArgumentNullException("persistedMessageFactory");
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public IChatMessageEntity StoreMessage(long actorUserId, long conversationId, IRawChatMessage rawChatMessage)
	{
		return _RedisMessageCache.StoreMessageInRedis(actorUserId, conversationId, rawChatMessage);
	}

	public void SaveMessage(long conversationId, IChatMessageEntity updatedMessage)
	{
		_RedisMessageCache.UpdateMessageInRedis(conversationId, updatedMessage);
	}

	public void SetMessageExpiry(long conversationId, IChatMessageEntity message, TimeSpan expirationTime)
	{
		_RedisMessageCache.SetMessageExpiry(conversationId, message, expirationTime);
	}

	public bool MarkMessageAsRead(long userId, long conversationId, Guid lastMessageIdRead)
	{
		IChatMessageEntity message = _RedisMessageCache.Get(conversationId, lastMessageIdRead);
		if (message == null)
		{
			return false;
		}
		IChatMessageEntity latestMessage = _RedisMessageCache.GetLatestReadMessage(userId, conversationId);
		if (latestMessage == null || latestMessage.Sent.Ticks < message.Sent.Ticks || (latestMessage.Sent.Ticks == message.Sent.Ticks && !latestMessage.UniqueId.Equals(message.UniqueId)))
		{
			_RedisMessageCache.MarkMessageAsRead(userId, conversationId, lastMessageIdRead);
			_RedisMessageCache.MarkConversationAsSeen(userId, conversationId, message.Sent);
			return true;
		}
		return false;
	}

	public void MarkConversationAsSeen(long userId, long conversationId, UtcInstant lastTimeSeen)
	{
		_RedisMessageCache.MarkConversationAsSeen(userId, conversationId, lastTimeSeen);
	}

	public bool IsConversationSeen(long userId, long conversationId, UtcInstant timeSeen)
	{
		return _RedisMessageCache.IsConversationSeen(userId, conversationId, timeSeen);
	}

	public IReadOnlyCollection<MessageWithStatus> GetUnreadMessages(long userId, long conversationId, int maxRows)
	{
		IReadOnlyCollection<Guid> unreadMessageIds = _RedisMessageCache.GetUnreadMessageIds(userId, conversationId, maxRows);
		return GetMessagesByIds(userId, conversationId, unreadMessageIds);
	}

	/// <summary>
	/// This provides an ordered list of message ids ordered descending by timestamp
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="conversationId"></param>
	/// <param name="exclusiveStartMessageId"></param>
	/// <param name="maxRows"></param>
	/// <returns></returns>
	public IReadOnlyCollection<MessageWithStatus> GetMessages(long userId, long conversationId, Guid? exclusiveStartMessageId, int maxRows)
	{
		IReadOnlyCollection<Guid> messageIds = _RedisMessageCache.GetMessageIds(userId, conversationId, exclusiveStartMessageId, maxRows);
		IReadOnlyCollection<Guid> persistedMessagedIds = null;
		if (messageIds.Count < maxRows)
		{
			bool shouldFetchFromDynamoDb = true;
			string oldestMessageIdInConversation = GetOldestMessageIdInConversation(conversationId);
			if (!string.IsNullOrEmpty(oldestMessageIdInConversation))
			{
				if (messageIds.Count > 0)
				{
					if (messageIds.LastOrDefault().ToString().Equals(oldestMessageIdInConversation))
					{
						shouldFetchFromDynamoDb = false;
					}
					else if (messageIds.Any((Guid guid) => guid.ToString().Equals(oldestMessageIdInConversation)))
					{
						_RedisMessageCache.ClearOldestMessageId(conversationId);
					}
				}
				else if (string.Equals(oldestMessageIdInConversation, "Empty"))
				{
					shouldFetchFromDynamoDb = false;
				}
			}
			if (shouldFetchFromDynamoDb && !Settings.Default.DisableFetchingMessageIdsOnCacheMiss)
			{
				if (!exclusiveStartMessageId.HasValue)
				{
					persistedMessagedIds = _PersistedMessageFactory.GetMessageIds(conversationId, maxRows);
				}
				else
				{
					IChatMessageEntity exclusiveStartMessage = Get(conversationId, exclusiveStartMessageId.Value);
					if (exclusiveStartMessage == null)
					{
						persistedMessagedIds = _PersistedMessageFactory.GetMessageIds(conversationId, maxRows);
					}
					else
					{
						long score = _RedisMessageCache.GetMessageScoreForOrdering(exclusiveStartMessage);
						persistedMessagedIds = _PersistedMessageFactory.GetMessageIds(conversationId, maxRows, exclusiveStartMessageId, score);
					}
				}
			}
		}
		if (persistedMessagedIds != null && persistedMessagedIds.Count > messageIds.Count)
		{
			messageIds = persistedMessagedIds;
			MessageDataAccessor.OnMessagesMissingFromCache?.Invoke(conversationId);
		}
		return GetMessagesByIds(userId, conversationId, messageIds);
	}

	public IChatMessageEntity Get(long conversationId, Guid messageId)
	{
		IChatMessageEntity message = _RedisMessageCache.Get(conversationId, messageId);
		if (message == null)
		{
			message = _PersistedMessageFactory.GetChatMessage(messageId);
			if (message != null)
			{
				_RedisMessageCache.Set(conversationId, message);
			}
		}
		return message;
	}

	public MessageWithStatus GetWithStatus(long userId, long conversationId, Guid messageId)
	{
		return GetMessagesByIds(userId, conversationId, (IReadOnlyCollection<Guid>)(object)new Guid[1] { messageId }).FirstOrDefault();
	}

	/// <summary>
	/// Removes all the messages for a conversation. Don't use in foreground processes -- this may take a long time.
	/// </summary>
	/// <returns>Whether the operation was successful.</returns>
	public bool RemoveMessages(long conversationId)
	{
		return _RedisMessageCache.RemoveMessages(conversationId);
	}

	public Guid? SynchronizeCacheWithPersistentStorage(long conversationId, Guid? exclusiveStartMessageId = null)
	{
		IChatMessageEntity exclusiveStartMessage = null;
		long? exclusiveStartMessageScore = null;
		if (exclusiveStartMessageId.HasValue)
		{
			exclusiveStartMessage = Get(conversationId, exclusiveStartMessageId.Value);
			if (exclusiveStartMessage != null)
			{
				exclusiveStartMessageScore = _RedisMessageCache.GetMessageScoreForOrdering(exclusiveStartMessage);
			}
		}
		IReadOnlyCollection<Guid> persistedMessagedIds = _PersistedMessageFactory.GetMessageIds(conversationId, Settings.Default.MaxRowsToFetchForCacheSync, exclusiveStartMessage?.UniqueId, exclusiveStartMessageScore);
		return GetMessagesByIdsWithCacheCorrection(conversationId, persistedMessagedIds).LastOrDefault()?.UniqueId;
	}

	public long GetLastSentMessageTimeStampTicks(long userId)
	{
		return _RedisMessageCache.GetLastSentMessageTimeStampTicks(userId);
	}

	private string GetOldestMessageIdInConversation(long conversationId)
	{
		string oldestMessageIdInConversation = _RedisMessageCache.GetOldestMessageId(conversationId);
		if (string.IsNullOrEmpty(oldestMessageIdInConversation))
		{
			Guid? persistedMessageId = _PersistedMessageFactory.GetOldestMessageIdInConversation(conversationId);
			if (persistedMessageId.HasValue)
			{
				oldestMessageIdInConversation = persistedMessageId.Value.ToString();
				_RedisMessageCache.SetOldestMessageId(conversationId, oldestMessageIdInConversation, Settings.Default.OldestMessageIdStoreExpiration);
			}
			else
			{
				if (_RedisMessageCache.HasMessages(conversationId))
				{
					return null;
				}
				_RedisMessageCache.SetOldestMessageId(conversationId, "Empty", Settings.Default.OldestMessageIdStoreExpiration);
			}
		}
		else if (oldestMessageIdInConversation.Equals("Empty") && _RedisMessageCache.HasMessages(conversationId))
		{
			_RedisMessageCache.ClearOldestMessageId(conversationId);
			return null;
		}
		return oldestMessageIdInConversation;
	}

	private IReadOnlyCollection<MessageWithStatus> GetMessagesByIds(long userId, long conversationId, IReadOnlyCollection<Guid> messageIds)
	{
		IReadOnlyCollection<IChatMessageEntity> messagesByIdsWithCacheCorrection = GetMessagesByIdsWithCacheCorrection(conversationId, messageIds);
		IChatMessageEntity latestReadMessage = _RedisMessageCache.GetLatestReadMessage(userId, conversationId);
		double orderingScoreForLatestReadMessage = ((latestReadMessage != null) ? ((double)_RedisMessageCache.GetMessageScoreForOrdering(latestReadMessage)) : 0.0);
		List<MessageWithStatus> sortedMessages = new List<MessageWithStatus>(messagesByIdsWithCacheCorrection.Count);
		foreach (IChatMessageEntity message in messagesByIdsWithCacheCorrection)
		{
			if (message != null)
			{
				long orderingScoreForCurrentMessage = _RedisMessageCache.GetMessageScoreForOrdering(message);
				MessageStatus messageStatus = ((latestReadMessage != null && !((double)orderingScoreForCurrentMessage > orderingScoreForLatestReadMessage)) ? MessageStatus.Read : MessageStatus.Unread);
				MessageWithStatus sortedMessage = new MessageWithStatus(message, messageStatus);
				sortedMessages.Add(sortedMessage);
			}
		}
		return sortedMessages;
	}

	private IReadOnlyCollection<IChatMessageEntity> GetMessagesByIdsWithCacheCorrection(long conversationId, IReadOnlyCollection<Guid> messageIds)
	{
		Dictionary<Guid, IChatMessageEntity> cacheHitMessages = new Dictionary<Guid, IChatMessageEntity>();
		Dictionary<Guid, int> positionDictionary = new Dictionary<Guid, int>();
		List<IChatMessageEntity> orderedMessages = new List<IChatMessageEntity>(messageIds.Count);
		foreach (IChatMessageEntity cacheMessage in _RedisMessageCache.GetMessagesByMessageIds(conversationId, messageIds))
		{
			cacheHitMessages.Add(cacheMessage.UniqueId, cacheMessage);
		}
		HashSet<Guid> cacheMissedMessageIds = new HashSet<Guid>();
		int position = 0;
		foreach (Guid messageId in messageIds)
		{
			if (!cacheHitMessages.ContainsKey(messageId))
			{
				cacheMissedMessageIds.Add(messageId);
				orderedMessages.Add(null);
			}
			else
			{
				orderedMessages.Add(cacheHitMessages[messageId]);
			}
			positionDictionary.Add(messageId, position);
			position++;
		}
		if (cacheMissedMessageIds.Count > 0)
		{
			foreach (IChatMessageEntity databaseMessage in _PersistedMessageFactory.GetChatMessages(cacheMissedMessageIds.ToList()))
			{
				int messagePosition = positionDictionary[databaseMessage.UniqueId];
				orderedMessages[messagePosition] = databaseMessage;
				_RedisMessageCache.Set(conversationId, databaseMessage);
				_RedisMessageCache.SetMessageExpiry(conversationId, databaseMessage, Settings.Default.MessageExpirationTimespan);
			}
		}
		MessageDataAccessor.OnRedisHit?.Invoke(cacheHitMessages.Count);
		MessageDataAccessor.OnRedisMiss?.Invoke(cacheMissedMessageIds.Count);
		List<Guid> missingMessageIds = new List<Guid>();
		int counter = 0;
		List<IChatMessageEntity> validMessages = new List<IChatMessageEntity>();
		foreach (IChatMessageEntity message in orderedMessages)
		{
			if (message == null)
			{
				missingMessageIds.Add(messageIds.ElementAt(counter));
			}
			else
			{
				validMessages.Add(message);
			}
			counter++;
		}
		_RedisMessageCache.RemoveMessageIdsFromConversationCollection(conversationId, missingMessageIds);
		_RedisMessageCache.SetMessageIds(conversationId, validMessages);
		return orderedMessages;
	}
}
