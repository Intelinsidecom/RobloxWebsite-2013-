using System.Collections.Generic;
namespace Roblox.Platform.GameInstances.Clientpublic {
    struct UpdateResult

{
	public IReadOnlyCollection<PlaySession> PlayersJoined;

	public IReadOnlyCollection<PlaySession> PlayersLeft;

	public bool IsOutOfOrderUpdate;
}


}
