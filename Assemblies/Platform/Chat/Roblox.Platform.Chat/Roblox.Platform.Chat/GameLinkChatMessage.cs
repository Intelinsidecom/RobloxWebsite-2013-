using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class GameLinkChatMessage : IGameLinkChatMessage, ILinkChatMessage, IChatMessage
{
	public long UniverseId { get; set; }

	public ChatMessageLinkType ChatMessageLinkType { get; set; }

	public Guid Id { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public bool Read { get; set; }

	public HashSet<string> Decorators { get; set; }

	public IChatMessageSource MessageSource { get; set; }
}
