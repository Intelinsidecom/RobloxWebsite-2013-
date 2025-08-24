using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class RawSetConversationUniverseEventBasedChatMessage : IRawSetConversationUniverseEventBasedChatMessage, IRawEventBasedChatMessage, IRawChatMessage
{
	public ChatMessageType MessageType { get; set; }

	public IReadOnlyCollection<string> Decorators { get; set; }

	public IRawChatMessageSource MessageSource { get; set; }

	public ChatMessageEventType ChatMessageEventType { get; set; }

	public long ActorUserId { get; set; }

	public long UniverseId { get; set; }
}
