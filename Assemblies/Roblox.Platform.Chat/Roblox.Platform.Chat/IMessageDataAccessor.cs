using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal interface IMessageDataAccessor
{
	IChatMessageEntity StoreMessage(long actorUserId, long conversationId, IRawChatMessage rawChatMessage);

	void SetMessageExpiry(long conversationId, IChatMessageEntity message, TimeSpan expirationTime);

	IChatMessageEntity Get(long conversationId, Guid messageId);

	bool MarkMessageAsRead(long userId, long conversationId, Guid lastMessageIdRead);

	void MarkConversationAsSeen(long userId, long conversationId, UtcInstant lastTimeSeen);

	bool IsConversationSeen(long userId, long conversationId, UtcInstant timeSeen);

	IReadOnlyCollection<MessageWithStatus> GetUnreadMessages(long userId, long conversationId, int maxRows);

	IReadOnlyCollection<MessageWithStatus> GetMessages(long userId, long conversationId, Guid? exclusiveStartMessageId, int maxRows);

	MessageWithStatus GetWithStatus(long userId, long conversationId, Guid messageId);

	bool RemoveMessages(long conversationId);

	Guid? SynchronizeCacheWithPersistentStorage(long conversationId, Guid? exclusiveStartMessageId = null);

	/// <summary>
	/// Commit the changes made to the chatMessage Entity into the database
	/// </summary>
	/// <param name="conversationId">The conversation Id to which the message belongs</param>
	/// <param name="updatedMessage">The updated message where the fields (that need to be committed to the database) are set to the new values</param>
	void SaveMessage(long conversationId, IChatMessageEntity updatedMessage);

	long GetLastSentMessageTimeStampTicks(long userId);
}
