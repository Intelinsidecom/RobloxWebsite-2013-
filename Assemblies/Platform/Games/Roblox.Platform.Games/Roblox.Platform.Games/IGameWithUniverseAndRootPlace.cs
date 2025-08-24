using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// A read-only interface for games that support both the legacy concept of a game (place) and the new representation of a game (universe).
///
/// Neither "a universe without a root place" or "a place without a universe" should be supported by implementations of this interface.
/// </summary>
public interface IGameWithUniverseAndRootPlace
{
	/// <summary>
	/// The universe entity's id. The universe id will be null if there is no corresponding universe.
	/// </summary>
	long? UniverseId { get; }

	/// <summary>
	/// The universe's root place id. The root place id will be null if there is no corresponding universe or there is no root place with the universe.
	/// </summary>
	long? RootPlaceId { get; }

	/// <summary>
	/// The related place id, just in case that we get a place without a universe
	/// </summary>
	long PlaceId { get; }

	/// <summary>
	/// Player count of the game.
	/// </summary>
	int? PlayerCount { get; set; }

	/// <summary>
	/// A unique universe that is representative of the game, is never null.
	/// </summary>
	IUniverse Universe { get; }

	/// <summary>
	/// A unique place that is used as the identifier of the game in many legacy syb-systems.  This is never null for a IGameWithUniverseAndRootPlace.
	/// </summary>
	IPlace RootPlace { get; }

	/// <summary>
	/// The name of the game as surfaced to the developers on the Develope page.
	/// </summary>
	string DeveloperFacingName { get; }

	/// <summary>
	/// The name of the game as surfaced to players.
	/// </summary>
	string PlayerFacingName { get; }

	/// <summary>
	/// Checks if this game is secure.
	/// </summary>
	bool IsSecure();
}
