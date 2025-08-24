namespace Roblox.Platform.Games;

public enum PlayabilityResultEnum
{
	/// <summary>
	/// Place is playable.  No problems.
	/// </summary>
	Playable,
	/// <summary>
	/// Asset provided is not a place, thus is not playable.
	/// </summary>
	NotAPlace,
	/// <summary>
	/// The place provided does not have a universe.
	/// </summary>
	PlaceHasNoUniverse,
	/// <summary>
	/// The place is part of a universe, but there is no root place for the universe.
	/// </summary>
	UniverseDoesNotHaveARootPlace,
	/// <summary>
	/// The place is part of a universe, but the "root place" of the universe is not a place.
	/// </summary>
	UniverseRootPlaceIsNotAPlace,
	/// <summary>
	/// The root place of the universe is not active.
	/// </summary>
	UniverseRootPlaceIsNotActive
}
