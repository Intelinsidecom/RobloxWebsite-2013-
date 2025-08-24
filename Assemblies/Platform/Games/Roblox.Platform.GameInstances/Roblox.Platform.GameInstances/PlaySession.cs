using System;

namespace Roblox.Platform.GameInstances;

public class PlaySession : IPlaySession
{
	public DateTime Started { get; set; }

	public Guid Id { get; set; }
}
