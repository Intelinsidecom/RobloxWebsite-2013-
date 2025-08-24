using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.GameInstances.Interfaces;

namespace Roblox.GameInstances.Client;

public class UniverseGame : IGame
{
	public long PlaceId { get; }

	public int MatchmakingContextId { get; }

	public IEnumerable<PlaySession> PlaySessions { get; }

	public DateTime Updated { get; }

	public UniverseGame(long placeId, int matchmakingContextId)
	{
		PlaceId = placeId;
		MatchmakingContextId = matchmakingContextId;
		PlaySessions = Enumerable.Empty<PlaySession>();
		Updated = DateTime.UtcNow;
	}
}
