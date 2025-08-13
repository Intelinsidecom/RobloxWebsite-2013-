using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class SetConversationUniverseEventBasedChatMessage : ISetConversationUniverseEventBasedChatMessage, IEventBasedChatMessage, IChatMessage
{
	public Guid Id { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public bool Read { get; set; }

	public HashSet<string> Decorators { get; set; }

	public IChatMessageSource MessageSource { get; set; }

	public ChatMessageEventType ChatMessageEventType { get; set; }

	public long ActorUserId { get; set; }

	public long UniverseId { get; set; }
}
