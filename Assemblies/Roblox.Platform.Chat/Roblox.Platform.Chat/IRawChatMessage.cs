using System.Collections.Generic;

namespace Roblox.Platform.Chat;

/// <summary>
/// Interface to be implemented by all types of raw (not yet committed to Database) chat messages
/// </summary>
public interface IRawChatMessage
{
	ChatMessageType MessageType { get; set; }

	IReadOnlyCollection<string> Decorators { get; set; }

	IRawChatMessageSource MessageSource { get; set; }
}
