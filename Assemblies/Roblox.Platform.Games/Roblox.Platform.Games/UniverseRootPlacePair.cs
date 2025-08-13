using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

internal class UniverseRootPlacePair : IUniverseRootPlacePair
{
	public IUniverse Universe { get; set; }

	public IPlace RootPlace { get; set; }
}
