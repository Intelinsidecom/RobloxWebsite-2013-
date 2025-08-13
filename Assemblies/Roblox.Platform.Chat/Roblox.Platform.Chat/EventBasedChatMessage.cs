using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class EventBasedChatMessage : IEventBasedChatMessage, IChatMessage
{
	public Guid Id { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public bool Read { get; set; }

	public HashSet<string> Decorators { get; set; }

	public IChatMessageSource MessageSource { get; set; }

	public ChatMessageEventType ChatMessageEventType { get; set; }
}
