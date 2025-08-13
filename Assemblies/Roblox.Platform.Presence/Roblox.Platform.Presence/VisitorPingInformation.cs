using System;

namespace Roblox.Platform.Presence;

internal class VisitorPingInformation
{
	public string Location { get; set; }

	public string ClientLocationType { get; set; }

	public string Platform { get; set; }

	public string SessionId { get; set; }

	public DateTime TimeStamp { get; set; }

	public long? UniverseId { get; set; }
}
