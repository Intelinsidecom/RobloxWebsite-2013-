using System;
using System.Collections.Generic;

namespace Roblox.Platform.EventStream.WebEvents;

public class ChatConversationUsageEventArgs : WebEventArgs
{
	public DateTime EventTime { get; set; }

	public string Context { get; set; }

	public long ConversationId { get; set; }

	public IReadOnlyCollection<long> ParticipantUserIds { get; set; }
}
