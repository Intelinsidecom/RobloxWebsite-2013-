using System;
using System.Collections.Generic;
using Roblox.EventStream.WebEvents.EventArgs;
using Roblox.EventStream.WebEvents;
namespace Roblox.EventStream.WebEvents {
    public class ChatConversationUsageEventArgs : WebEventArgs

{
	public DateTime EventTime { get; set; }

	public string Context { get; set; }

	public long ConversationId { get; set; }

	public IReadOnlyCollection<long> ParticipantUserIds { get; set; }
}


}




