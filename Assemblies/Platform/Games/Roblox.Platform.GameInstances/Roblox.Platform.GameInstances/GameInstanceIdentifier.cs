using System;
using Roblox.GameInstances.Client;

namespace Roblox.Platform.GameInstances;

internal class GameInstanceIdentifier : IGameInstanceIdentifier
{
	public Guid GameId { get; set; }

	public long PlaceId { get; set; }

	public GameInstanceIdentifier()
	{
	}

	internal GameInstanceIdentifier(GameIdentifier clientGameInstanceIdentifier)
	{
		GameId = clientGameInstanceIdentifier.GameId;
		PlaceId = clientGameInstanceIdentifier.PlaceId;
	}
}
