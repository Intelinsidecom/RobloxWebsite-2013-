using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat;

public class PlainTextChatMessage : IPlainTextChatMessage, IChatMessage
{
	public Guid Id { get; set; }

	public HashSet<string> Decorators { get; set; }

	public bool Read { get; set; }

	public IChatMessageSource MessageSource { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public string ContentForViewer { get; set; }
}
