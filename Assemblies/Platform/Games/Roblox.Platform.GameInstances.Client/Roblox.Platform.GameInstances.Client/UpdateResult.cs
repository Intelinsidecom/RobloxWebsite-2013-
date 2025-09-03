using System.Collections.Generic;
namespace Roblox.Platform.GameInstances.Client {
    struct UpdateResult

{
	public IReadOnlyCollection<PlaySession> PlayersJoined;

	public IReadOnlyCollection<PlaySession> PlayersLeft;

	public bool IsOutOfOrderUpdate;
}


}
