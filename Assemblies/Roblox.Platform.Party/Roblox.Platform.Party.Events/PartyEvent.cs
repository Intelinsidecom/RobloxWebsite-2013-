using System;

namespace Roblox.Platform.Party.Events;

public class PartyEvent
{
	public PartyEventType PartyEventType { get; set; }

	public Guid PartyId { get; set; }

	public long? AffectedUserId { get; set; }
}
