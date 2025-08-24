using System.Collections.Generic;

namespace Roblox.Platform.Presence;

public class BulkPresenceEvent
{
	public IReadOnlyCollection<PresenceEvent> PresenceEvents { get; set; }
}
