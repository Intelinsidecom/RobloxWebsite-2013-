using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class GroupConversationActionResponse : IGroupConversationActionResponse
{
	public IConversation Conversation { get; set; }

	public IReadOnlyCollection<IRejectedUser> RejectedUsers { get; set; }
}
