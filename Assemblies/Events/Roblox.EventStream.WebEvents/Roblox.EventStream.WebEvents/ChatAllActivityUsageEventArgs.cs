using System.Collections.Generic;
using Roblox.Time;

namespace Roblox.Platform.EventStream.WebEvents;

public class ChatAllActivityUsageEventArgs : WebEventArgs
{
	public UtcInstant EventTime { get; set; }

	public string Context { get; set; }

	public long ConversationId { get; set; }

	public IReadOnlyCollection<long> ParticipantUserIds { get; set; }

	public string DeviceType { get; set; }
}
