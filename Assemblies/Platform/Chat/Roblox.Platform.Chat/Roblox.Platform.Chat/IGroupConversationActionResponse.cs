using System.Collections.Generic;

namespace Roblox.Platform.Chat;

public interface IGroupConversationActionResponse
{
	IConversation Conversation { get; }

	IReadOnlyCollection<IRejectedUser> RejectedUsers { get; }
}
