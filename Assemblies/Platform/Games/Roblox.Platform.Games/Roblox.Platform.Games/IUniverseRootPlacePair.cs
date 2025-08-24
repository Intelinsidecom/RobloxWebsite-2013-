using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// A read-only interface for games that support both the legacy concept of a game (place) and the new representation of a game (universe).
/// </summary>
internal interface IUniverseRootPlacePair
{
	/// <summary>
	/// A unique universe that is representative of the game. It will be null when the universe does not exist.
	/// </summary>
	IUniverse Universe { get; }

	/// <summary>
	/// A unique place that is used as the identifier of the game in many legacy syb-systems. It will be null when the universe does not have a root place or the root place does not exist.
	/// </summary>
	IPlace RootPlace { get; }
}
