using System;

namespace Roblox.Platform.GameInstances;

public interface IGameInstanceIdentifier
{
	Guid GameId { get; }

	long PlaceId { get; }
}
