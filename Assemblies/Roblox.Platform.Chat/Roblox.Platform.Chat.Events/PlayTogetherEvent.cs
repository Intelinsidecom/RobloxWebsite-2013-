using System;

namespace Roblox.Platform.Chat.Events;

internal class PlayTogetherEvent
{
	public PlayTogetherEventType PlayTogetherEventType { get; set; }

	public long ConversationId { get; set; }

	public long ActorUserId { get; set; }

	public long? UniverseId { get; set; }

	public DateTime? EventDateTime { get; set; }
}
