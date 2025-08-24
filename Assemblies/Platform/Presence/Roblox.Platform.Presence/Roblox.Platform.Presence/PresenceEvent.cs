using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.Platform.Presence;

public class PresenceEvent
{
	public long UserId { get; set; }

	public PresenceEventType EventType { get; set; }

	[JsonConverter(typeof(IsoDateTimeConverter))]
	public DateTime? PresenceChanged { get; set; }
}
