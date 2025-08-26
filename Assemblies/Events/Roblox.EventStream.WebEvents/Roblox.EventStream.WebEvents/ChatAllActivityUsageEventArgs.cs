using System;
using Roblox.EventStream.WebEvents.EventArgs;
using Roblox.EventStream.WebEvents;
using Roblox.Time;
using System.Collections.Generic;
namespace Roblox.EventStream.WebEvents {
    public class ChatAllActivityUsageEventArgs : WebEventArgs

{
	public UtcInstant EventTime { get; set; }

	public string Context { get; set; }

	public long ConversationId { get; set; }

	public IReadOnlyCollection<long> ParticipantUserIds { get; set; }

	public string DeviceType { get; set; }
}


}





