using System;
using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.Chat.Entities;

internal class SetConversationUniverseEventBasedChatMessageEntity : ISetConversationUniverseEventBasedChatMessageEntity, IEventBasedChatMessageEntity, IChatMessageEntity
{
	public Guid UniqueId { get; set; }

	public ChatMessageType MessageType { get; set; }

	public UtcInstant Sent { get; set; }

	public HashSet<string> Decorators { get; set; }

	public IChatMessageSourceEntity ChatMessageSourceEntity { get; set; }

	public ChatMessageEventType ChatMessageEventType { get; set; }

	public long ActorUserId { get; set; }

	public long UniverseId { get; set; }
}
