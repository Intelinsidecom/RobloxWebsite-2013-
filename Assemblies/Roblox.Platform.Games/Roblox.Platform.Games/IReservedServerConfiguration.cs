using System;

namespace Roblox.Platform.Games;

public interface IReservedServerConfiguration
{
	long PlaceId { get; }

	Guid GameCode { get; }
}
