using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class RawPlainTextMessage : IRawPlainTextMessage, IRawChatMessage
{
	public string Over13Content { get; set; }

	public string Under13Content { get; set; }

	public ChatMessageType MessageType { get; set; }

	public IReadOnlyCollection<string> Decorators { get; set; }

	public IRawChatMessageSource MessageSource { get; set; }
}
