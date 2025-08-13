using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface ISystemInitiatedConversationBuilder
{
	IConversation CreateSystemInitiatedOneToOneConversation(IUser firstUser, IUser secondUser);

	bool UpdateConversationTimestamp(IConversation conversation, Func<DateTime> nowProvider = null);
}
