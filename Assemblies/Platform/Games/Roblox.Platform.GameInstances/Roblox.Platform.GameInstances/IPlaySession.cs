using System;

namespace Roblox.Platform.GameInstances;

public interface IPlaySession
{
	DateTime Started { get; }

	Guid Id { get; }
}
