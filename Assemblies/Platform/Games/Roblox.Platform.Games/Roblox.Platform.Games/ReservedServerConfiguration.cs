using System;

namespace Roblox.Platform.Games;

internal class ReservedServerConfiguration : IReservedServerConfiguration
{
	public long PlaceId { get; set; }

	public Guid GameCode { get; set; }
}
