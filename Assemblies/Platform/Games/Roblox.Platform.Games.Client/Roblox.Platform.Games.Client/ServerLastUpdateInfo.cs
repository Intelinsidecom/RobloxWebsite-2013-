using System;

namespace Roblox.Games.Client;

public class ServerLastUpdateInfo
{
	public DateTime? LastUpdatedTimeForServer { get; set; }

	public DateTime UpdatesKnownSinceTime { get; set; }
}
