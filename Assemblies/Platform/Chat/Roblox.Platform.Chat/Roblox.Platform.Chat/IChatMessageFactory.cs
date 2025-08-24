using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Time;

namespace Roblox.Platform.Chat;

public interface IChatMessageFactory
{
	IReadOnlyCollection<IChatMessage> GetMessages(IUser user, long conversationId, Guid? exclusiveStartMessageId, int maxRows);

	IReadOnlyCollection<IChatMessage> GetUnreadMessages(IUser user, long conversationId, int maxRows);

	IChatMessage GetMessage(IUser user, long conversationId, Guid messageId);

	bool IsConversationSeen(IUser user, long conversationId, UtcInstant timeSeen);

	bool IsActiveChatUser(IUser user);
}
