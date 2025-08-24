using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Redis;
using Roblox.Time;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class RedisMessageCache : IRedisMessageCache
{
	private const string _HashField_UniqueId = "UniqueId";

	private const string _HashField_Sent = "Sent";

	private const string _HashField_MessageType = "MessageType";

	private const string _HashField_Decorators = "DecoratorsCsv";

	private readonly IRedisClient _ChatMessageRedisClient;

	private readonly IRedisClient _ChatConversationRedisClient;

	private readonly IEphemeralChatMessageParserFactory _EphemeralChatMessageParserFactory;

	private readonly ILogger _Logger;

	private readonly IInstantProvider _InstantProvider;

	private readonly ISettings _Settings;

	public RedisMessageCache(IChatRedisClients chatRedisClients, IInstantProvider instantProvider, ILogger logger)
		: this(chatRedisClients, ChatMessageParserFactoryCreator.GetEphemeralChatMessageParserFactory(instantProvider), logger, instantProvider, Settings.Default)
	{
	}

	internal RedisMessageCache(IChatRedisClients chatRedisClients, IEphemeralChatMessageParserFactory ephemeralChatMessageParserFactory, ILogger logger, IInstantProvider instantProvider, ISettings settings)
	{
		if (chatRedisClients == null)
		{
			throw new PlatformArgumentNullException("chatRedisClients");
		}
		_EphemeralChatMessageParserFactory = ephemeralChatMessageParserFactory ?? throw new PlatformArgumentNullException("ephemeralChatMessageParserFactory");
		_ChatMessageRedisClient = chatRedisClients.ChatMessageRedisClient ?? throw new PlatformArgumentNullException("ChatMessageRedisClient");
		_ChatConversationRedisClient = chatRedisClients.ChatConversationRedisClient ?? throw new PlatformArgumentNullException("ChatConversationRedisClient");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public IChatMessageEntity StoreMessageInRedis(long actorUserId, long conversationId, IRawChatMessage rawChatMessage)
	{
		IChatMessageEntity message = _EphemeralChatMessageParserFactory.GetChatMessageParser(rawChatMessage.MessageType)?.Translate(rawChatMessage);
		HashEntry[] hashEntries = GetHashEntries(message);
		string messageStoreKeyWithUniqueId = GetMessageStoreKey(conversationId, message.UniqueId);
		_ChatMessageRedisClient.Execute(messageStoreKeyWithUniqueId, delegate(IDatabase db)
		{
			db.HashSet(messageStoreKeyWithUniqueId, hashEntries);
		});
		string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
		_ChatConversationRedisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.SortedSetAdd(orderedMessageIdStoreKey, message.UniqueId.ToString(), GetScore(message)));
		string readMessagesStoreKey = GetReadMessagesStoreKey(actorUserId);
		Guid currentMessageReadMarker = GetMessageReadMarker(message);
		_ChatConversationRedisClient.Execute(readMessagesStoreKey, (IDatabase db) => db.HashSet(readMessagesStoreKey, conversationId, currentMessageReadMarker.ToString()));
		try
		{
			if (Settings.Default.IsLastSentMessageTimeStampEnabled)
			{
				string lastSentMessageTimeStamp = GetLastSentMessageTimeStampKey(actorUserId);
				_ChatMessageRedisClient.Execute(lastSentMessageTimeStamp, (IDatabase db) => db.StringSet(lastSentMessageTimeStamp, _InstantProvider.GetCurrentUtcInstant().Ticks, _Settings.LastSentMessageTimeStampExpiry, When.Always, CommandFlags.FireAndForget));
			}
		}
		catch (Exception exp)
		{
			if (Settings.Default.IsChatMessageLastSentTimeStampErrorLoggingEnabled)
			{
				_Logger.Error(exp);
			}
		}
		return message;
	}

	/// <summary>
	/// Commits the chatMessage entity properties to cache
	/// </summary>
	/// <param name="conversationId">Conversation Id that the message belongs to</param>
	/// <param name="enhancedMessage">Chat Message with updated fields to be committed in cache</param>
	public void UpdateMessageInRedis(long conversationId, IChatMessageEntity enhancedMessage)
	{
		string messageStoreKey = GetMessageStoreKey(conversationId, enhancedMessage.UniqueId);
		HashEntry[] hashEntries = _EphemeralChatMessageParserFactory.GetChatMessageParser(enhancedMessage.MessageType)?.GetHashEntries(enhancedMessage);
		if (hashEntries == null || !_ChatMessageRedisClient.Execute(messageStoreKey, (IDatabase db) => db.KeyExists(messageStoreKey)))
		{
			return;
		}
		HashEntry[] array = hashEntries;
		for (int i = 0; i < array.Length; i++)
		{
			HashEntry entry = array[i];
			_ChatMessageRedisClient.Execute(messageStoreKey, (IDatabase db) => db.HashSet(messageStoreKey, entry.Name, entry.Value));
		}
	}

	public void SetMessageExpiry(long conversationId, IChatMessageEntity message, TimeSpan expirationTime)
	{
		string messageWithUniqueIdStoreKey = GetMessageStoreKey(conversationId, message.UniqueId);
		_ChatMessageRedisClient.Execute(messageWithUniqueIdStoreKey, (IDatabase db) => db.KeyExpire(messageWithUniqueIdStoreKey, expirationTime));
	}

	public IChatMessageEntity Get(long conversationId, Guid messageId)
	{
		string messageStoreKey = GetMessageStoreKey(conversationId, messageId);
		HashEntry[] hashEntries = _ChatMessageRedisClient.Execute(messageStoreKey, (IDatabase db) => db.HashGetAll(messageStoreKey));
		return GetMessageFromHashEntries(hashEntries);
	}

	public IChatMessageEntity GetLatestReadMessage(long userId, long conversationId)
	{
		string readMessagesStoreKey = GetReadMessagesStoreKey(userId);
		RedisValue existingMessageReadMarker = _ChatConversationRedisClient.Execute(readMessagesStoreKey, (IDatabase db) => db.HashGet(readMessagesStoreKey, conversationId));
		if (existingMessageReadMarker.IsNull)
		{
			return null;
		}
		Guid.TryParse(existingMessageReadMarker, out var latestReadMessageId);
		return Get(conversationId, latestReadMessageId);
	}

	public bool MarkMessageAsRead(long userId, long conversationId, Guid lastMessageIdRead)
	{
		string readMessagesStoreKey = GetReadMessagesStoreKey(userId);
		return _ChatConversationRedisClient.Execute(readMessagesStoreKey, (IDatabase db) => db.HashSet(readMessagesStoreKey, conversationId, lastMessageIdRead.ToString()));
	}

	public void Set(long conversationId, IChatMessageEntity message)
	{
		HashEntry[] hashEntries = GetHashEntries(message);
		string messageStoreKeyWithUniqueId = GetMessageStoreKey(conversationId, message.UniqueId);
		_ChatMessageRedisClient.Execute(messageStoreKeyWithUniqueId, delegate(IDatabase db)
		{
			db.HashSet(messageStoreKeyWithUniqueId, hashEntries);
		});
	}

	public IReadOnlyCollection<Guid> GetUnreadMessageIds(long userId, long conversationId, int maxRows)
	{
		IChatMessageEntity latestReadMessage = GetLatestReadMessage(userId, conversationId);
		if (latestReadMessage == null)
		{
			return new List<Guid>();
		}
		long scoreForLatestReadMessage = GetScore(latestReadMessage);
		return GetMessageIdsBetweenScore(userId, conversationId, scoreForLatestReadMessage, double.PositiveInfinity, Exclude.Start, maxRows);
	}

	public long GetMessageScoreForOrdering(IChatMessageEntity message)
	{
		return GetScore(message);
	}

	public IReadOnlyCollection<Guid> GetMessageIds(long userId, long conversationId, Guid? exclusiveStartMessageId, int maxRows)
	{
		if (!exclusiveStartMessageId.HasValue)
		{
			return GetMessageIdsBetweenScore(userId, conversationId, 0.0, double.PositiveInfinity, Exclude.None, maxRows);
		}
		IChatMessageEntity startMessage = Get(conversationId, exclusiveStartMessageId.Value);
		if (startMessage == null)
		{
			return new List<Guid>();
		}
		return GetMessageIdsBetweenScore(userId, conversationId, 0.0, GetScore(startMessage), Exclude.Stop, maxRows);
	}

	public void SetMessageIds(long conversationId, IReadOnlyCollection<IChatMessageEntity> messages)
	{
		string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
		List<SortedSetEntry> sortedSetEntries = new List<SortedSetEntry>();
		foreach (IChatMessageEntity message in messages)
		{
			sortedSetEntries.Add(new SortedSetEntry(message.UniqueId.ToString(), GetMessageScoreForOrdering(message)));
		}
		_ChatConversationRedisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.SortedSetAdd(orderedMessageIdStoreKey, sortedSetEntries.ToArray()));
	}

	public bool RemoveMessages(long conversationId)
	{
		bool wereMessagesDeleted = true;
		string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
		OperateOnAllMessageIdsInConversation(_ChatConversationRedisClient, conversationId, delegate(Guid id)
		{
			string messageStoreKey = GetMessageStoreKey(conversationId, id);
			wereMessagesDeleted = wereMessagesDeleted && _ChatMessageRedisClient.Execute(messageStoreKey, (IDatabase db) => db.KeyDelete(messageStoreKey));
		});
		return _ChatConversationRedisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.KeyDelete(orderedMessageIdStoreKey)) && wereMessagesDeleted;
	}

	public void RemoveMessageIdsFromConversationCollection(long conversationId, IReadOnlyCollection<Guid> messageIds)
	{
		if (messageIds.Count != 0)
		{
			string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
			RedisValue[] redisValues = ((IEnumerable<Guid>)messageIds).Select((Func<Guid, RedisValue>)((Guid messageId) => messageId.ToString())).ToArray();
			_ChatConversationRedisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.SortedSetRemove(orderedMessageIdStoreKey, redisValues, CommandFlags.FireAndForget));
		}
	}

	public IReadOnlyCollection<IChatMessageEntity> GetMessagesByMessageIds(long conversationId, IReadOnlyCollection<Guid> messageIds)
	{
		List<IChatMessageEntity> messages = new List<IChatMessageEntity>(messageIds.Count);
		foreach (Guid messageId in messageIds)
		{
			IChatMessageEntity message = Get(conversationId, messageId);
			if (message != null)
			{
				messages.Add(message);
			}
		}
		return messages;
	}

	public string GetOldestMessageId(long conversationId)
	{
		string oldestMessageStoreKey = GetOldestMessageStoreKey(conversationId);
		return _ChatConversationRedisClient.Execute(oldestMessageStoreKey, (IDatabase db) => db.StringGet(oldestMessageStoreKey));
	}

	public bool SetOldestMessageId(long conversationId, string messageId, TimeSpan expirationTimespan)
	{
		bool success = false;
		if (!string.IsNullOrEmpty(messageId))
		{
			string oldestMessageStoreKey = GetOldestMessageStoreKey(conversationId);
			success = _ChatConversationRedisClient.Execute(oldestMessageStoreKey, (IDatabase db) => db.StringSet(oldestMessageStoreKey, messageId));
			_ChatConversationRedisClient.Execute(oldestMessageStoreKey, (IDatabase db) => db.KeyExpire(oldestMessageStoreKey, expirationTimespan));
		}
		return success;
	}

	public bool ClearOldestMessageId(long conversationId)
	{
		string oldestMessageStoreKey = GetOldestMessageStoreKey(conversationId);
		return _ChatConversationRedisClient.Execute(oldestMessageStoreKey, (IDatabase db) => db.KeyDelete(oldestMessageStoreKey));
	}

	public bool HasMessages(long conversationId)
	{
		string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
		return _ChatConversationRedisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.KeyExists(orderedMessageIdStoreKey));
	}

	public void MarkConversationAsSeen(long userId, long conversationId, UtcInstant timeSeen)
	{
		string key = GetSeenMessageKey(conversationId, userId);
		if (!IsConversationSeen(userId, conversationId, timeSeen))
		{
			_ChatConversationRedisClient.Execute(key, (IDatabase db) => db.StringSet(key, timeSeen.Ticks, Settings.Default.MessageSeenCacheExpiry));
		}
	}

	public bool IsConversationSeen(long userId, long conversationId, UtcInstant timeToCheck)
	{
		string key = GetSeenMessageKey(conversationId, userId);
		RedisValue latestSeenTicks = _ChatConversationRedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
		if (latestSeenTicks == RedisValue.Null)
		{
			return false;
		}
		return (long)latestSeenTicks >= timeToCheck.Ticks;
	}

	public HashEntry[] GetHashEntries(IChatMessageEntity message)
	{
		List<HashEntry> hashEntryList = new List<HashEntry>
		{
			new HashEntry("UniqueId", message.UniqueId.ToString()),
			new HashEntry("Sent", message.Sent.Ticks),
			new HashEntry("MessageType", (int)message.MessageType)
		};
		AddDecoratorsHashField(hashEntryList, message);
		HashEntry[] hashEntries = _EphemeralChatMessageParserFactory.GetChatMessageParser(message.MessageType)?.GetHashEntries(message);
		if (hashEntries != null)
		{
			hashEntryList.AddRange(hashEntries);
		}
		return hashEntryList.ToArray();
	}

	public long GetLastSentMessageTimeStampTicks(long userId)
	{
		string lastSentMessageTimeStampKey = GetLastSentMessageTimeStampKey(userId);
		return (long)_ChatMessageRedisClient.Execute(lastSentMessageTimeStampKey, (IDatabase db) => db.StringGet(lastSentMessageTimeStampKey));
	}

	private IReadOnlyCollection<Guid> GetMessageIdsBetweenScore(long userId, long conversationId, double startScore, double endScore, Exclude exclude, int maxRows)
	{
		string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
		RedisValue[] array = _ChatConversationRedisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.SortedSetRangeByScore(orderedMessageIdStoreKey, startScore, endScore, exclude, Order.Descending, 0L, maxRows));
		List<Guid> messageIds = new List<Guid>(array.Length);
		RedisValue[] array2 = array;
		foreach (RedisValue messageIdString in array2)
		{
			messageIds.Add(Guid.Parse(messageIdString));
		}
		return messageIds;
	}

	/// <remarks>
	/// Do not execute from foreground processes.
	/// </remarks>
	private static void OperateOnAllMessageIdsInConversation(IRedisClient redisClient, long conversationId, Action<Guid> operationOnMessageId)
	{
		string orderedMessageIdStoreKey = GetOrderedMessageIdStoreKey(conversationId);
		int startRow = 0;
		RedisValue[] currentResults;
		do
		{
			currentResults = redisClient.Execute(orderedMessageIdStoreKey, (IDatabase db) => db.SortedSetRangeByRank(orderedMessageIdStoreKey, startRow, startRow + 20 - 1));
			RedisValue[] array = currentResults;
			for (int i = 0; i < array.Length; i++)
			{
				Guid.TryParse(array[i], out var messageId);
				operationOnMessageId(messageId);
			}
			startRow += 20;
		}
		while (currentResults.Length == 20);
	}

	private static Guid GetMessageReadMarker(IChatMessageEntity message)
	{
		return message.UniqueId;
	}

	private static long GetScore(IChatMessageEntity message)
	{
		return message.Sent.Ticks;
	}

	private IChatMessageEntity GetMessageFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		ChatMessageType messageType = ChatMessageType.PlainText;
		if (dictionary.TryGetValue("MessageType", out var messageTypeValue))
		{
			messageType = (ChatMessageType)(int)messageTypeValue;
		}
		if (!dictionary.TryGetValue("UniqueId", out var uniqueIdValue) || !Guid.TryParse(uniqueIdValue, out var uniqueId))
		{
			_Logger.Error($"Could not parse unique Id for chat message from hash Entries -> UniqueId : {uniqueIdValue}");
			return null;
		}
		if (!dictionary.TryGetValue("Sent", out var sent) || !long.TryParse(sent, out var sentLong))
		{
			_Logger.Error($"Could not parse sent for chat message from hash Entries -> sent : {sent}");
			return null;
		}
		string decoratorsCsv = string.Empty;
		if (dictionary.TryGetValue("DecoratorsCsv", out var decoratorsCsvValue))
		{
			decoratorsCsv = decoratorsCsvValue;
		}
		UtcInstant sentUtc = new UtcInstant(sentLong);
		IChatMessageEntity message = _EphemeralChatMessageParserFactory.GetChatMessageParser(messageType)?.GetMessageFromHashEntries(hashEntries);
		if (message == null)
		{
			return null;
		}
		message.MessageType = messageType;
		message.UniqueId = uniqueId;
		message.Sent = sentUtc;
		message.Decorators = new HashSet<string>(decoratorsCsv.Split(','), StringComparer.OrdinalIgnoreCase);
		return message;
	}

	private void AddDecoratorsHashField(List<HashEntry> hashEntries, IChatMessageEntity chatMessageEntity)
	{
		if (chatMessageEntity.Decorators == null || chatMessageEntity.Decorators.Count == 0)
		{
			return;
		}
		List<string> acceptedDecorators = new List<string>();
		string[] array = chatMessageEntity.Decorators.ToArray();
		foreach (string decorator in array)
		{
			if (!string.IsNullOrWhiteSpace(decorator))
			{
				acceptedDecorators.Add(decorator);
			}
		}
		if (acceptedDecorators.Any())
		{
			hashEntries.Add(new HashEntry("DecoratorsCsv", string.Join(",", acceptedDecorators)));
		}
	}

	private static string GetReadMessagesStoreKey(long userId)
	{
		return "ReadMessages_v2_UserId:" + userId;
	}

	private static string GetOrderedMessageIdStoreKey(long conversationId)
	{
		return "OrderedMessageIds_v2_ConversationId:" + conversationId;
	}

	private static string GetMessageStoreKey(long conversationId, Guid uniqueMessageId)
	{
		return $"Messages_ConversationId:{conversationId}_UniqueMessageId:{uniqueMessageId}";
	}

	private static string GetOldestMessageStoreKey(long conversationId)
	{
		return $"OldestMessage_ConversationId:{conversationId}";
	}

	private static string GetSeenMessageKey(long conversationId, long userId)
	{
		return $"SeenMessages_{conversationId}_{userId}";
	}

	private static string GetLastSentMessageTimeStampKey(long userId)
	{
		return $"LastSentMessageTimeStamp_UserId:{userId}";
	}
}
