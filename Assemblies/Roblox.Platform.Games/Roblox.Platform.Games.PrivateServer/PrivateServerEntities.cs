using Roblox.FloodCheckers;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerEntities
{
	public FloodChecker FloodChecker { get; set; }

	public Roblox.Platform.Games.Entities.PrivateServer PrivateServer { get; set; }

	public IUniverse Universe { get; set; }
}
