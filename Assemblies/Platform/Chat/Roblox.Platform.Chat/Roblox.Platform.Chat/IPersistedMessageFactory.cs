using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface IPersistedMessageFactory
{
	Guid? GetLatestMessageIdInConversation(long conversationId);

	Guid? GetOldestMessageIdInConversation(long conversationId);

	IChatMessageEntity GetChatMessage(Guid messageId);

	IReadOnlyCollection<Guid> GetMessageIds(long conversationId, int pageSize, Guid? exclusiveStartKeyId = null, long? exclusiveStartKeyTimestampTicks = null);

	IReadOnlyCollection<IChatMessageEntity> GetChatMessages(IReadOnlyCollection<Guid> messageIds);
}
