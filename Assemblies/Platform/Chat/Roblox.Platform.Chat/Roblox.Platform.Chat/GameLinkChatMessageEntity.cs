using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Entities;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class GameLinkChatMessageEntity : IGameLinkChatMessageEntity, ILinkChatMessageEntity, IChatMessageEntity
{
	public Guid UniqueId { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public HashSet<string> Decorators { get; set; }

	public IChatMessageSourceEntity ChatMessageSourceEntity { get; set; }

	public ChatMessageLinkType ChatMessageLinkType { get; set; }

	public long UniverseId { get; set; }
}
