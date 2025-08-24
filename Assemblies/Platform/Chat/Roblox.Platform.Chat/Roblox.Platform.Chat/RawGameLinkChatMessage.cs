using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class RawGameLinkChatMessage : IRawGameLinkChatMessage, IRawLinkChatMessage, IRawChatMessage
{
	public ChatMessageType MessageType { get; set; }

	public IReadOnlyCollection<string> Decorators { get; set; }

	public IRawChatMessageSource MessageSource { get; set; }

	public long UniverseId { get; set; }

	public ChatMessageLinkType ChatMessageLinkType { get; set; }
}
