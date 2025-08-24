using System.Collections.Generic;

namespace Roblox.GameInstances.Client;

public struct UpdateResult
{
	public IReadOnlyCollection<PlaySession> PlayersJoined;

	public IReadOnlyCollection<PlaySession> PlayersLeft;

	public bool IsOutOfOrderUpdate;
}
