using System.Collections.Generic;

namespace Roblox.Platform.Chat.Events;

/// <summary>
/// Events trigerred on chat conversations state change (ex: creation, participants added/removed)
/// currently consumed to maintain chat interactions cache for participants
/// </summary>
internal class ChatConversationEvent : IChatEvent
{
	public long ConversationId { get; set; }

	public ChatConversationEventType ChatConversationEventType { get; set; }

	public IReadOnlyCollection<long> AffectedUserIds { get; set; }
}
