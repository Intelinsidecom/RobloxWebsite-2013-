using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal interface IRedisMessageCache
{
	IChatMessageEntity StoreMessageInRedis(long actorUserId, long conversationId, IRawChatMessage rawChatMessage);

	void UpdateMessageInRedis(long conversationId, IChatMessageEntity enhancedMessage);

	void SetMessageExpiry(long conversationId, IChatMessageEntity message, TimeSpan expirationTime);

	IChatMessageEntity Get(long conversationId, Guid messageId);

	IChatMessageEntity GetLatestReadMessage(long userId, long conversationId);

	bool MarkMessageAsRead(long userId, long conversationId, Guid lastMessageIdRead);

	void Set(long conversationId, IChatMessageEntity message);

	IReadOnlyCollection<Guid> GetUnreadMessageIds(long userId, long conversationId, int maxRows);

	long GetMessageScoreForOrdering(IChatMessageEntity message);

	IReadOnlyCollection<Guid> GetMessageIds(long userId, long conversationId, Guid? exclusiveStartMessageId, int maxRows);

	void SetMessageIds(long conversationId, IReadOnlyCollection<IChatMessageEntity> messages);

	bool RemoveMessages(long conversationId);

	void RemoveMessageIdsFromConversationCollection(long conversationId, IReadOnlyCollection<Guid> messageIds);

	IReadOnlyCollection<IChatMessageEntity> GetMessagesByMessageIds(long conversationId, IReadOnlyCollection<Guid> messageIds);

	string GetOldestMessageId(long conversationId);

	bool SetOldestMessageId(long conversationId, string messageId, TimeSpan expirationTimespan);

	bool ClearOldestMessageId(long conversationId);

	bool HasMessages(long conversationId);

	void MarkConversationAsSeen(long userId, long conversationId, UtcInstant timeSeen);

	bool IsConversationSeen(long userId, long conversationId, UtcInstant timeToCheck);

	long GetLastSentMessageTimeStampTicks(long userId);
}
