using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// Public interface for a class that manages things related to places and games.
/// In particular, it is in charge of:
/// * Adding/Removing places from a universe, and adjusts the game's IsSecure attribute accordingly
/// * Setting the IsFilteringEnabled attribute for a place, and adjusts the game's IsSecure attribute accordingly
/// </summary>
public interface IGamePlacesManager
{
	/// <summary>
	/// Attempts to add a place to a game, and adjusts the game's IsSecure attribute where applicable.
	/// </summary>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <param name="isCreatedByUniverse">if set to <c>true</c>, then it means that <paramref name="place" /> was created by <paramref name="universe" /> (in game).</param>
	/// <returns><c>true</c> if the <paramref name="place" /> is a part of <paramref name="universe" /> after the method's completion, <c>false</c> otherwise.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universe" /></exception>
	/// <exception cref="T:System.ArgumentException">Thrown when <paramref name="place" /> is already the root place of a universe other than <paramref name="universe" />.</exception>
	void AddPlaceToUniverse(IPlace place, IUniverse universe, bool isCreatedByUniverse);

	/// <summary>
	/// Removes the place from universe, and adjusts the game's IsSecure attribute where applicable.
	/// </summary>
	/// <param name="place">An <see cref="T:Roblox.Platform.Assets.IPlace" /></param>
	/// <param name="universe">An <see cref="T:Roblox.Platform.Universes.IUniverse" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universe" /></exception>
	/// <exception cref="T:System.ArgumentException">Thrown when <paramref name="place" /> is not part of <paramref name="universe" />.</exception>
	/// <exception cref="T:System.ArgumentException">Thrown when <paramref name="place" /> is the root place of <paramref name="universe" />.</exception>
	void RemovePlaceFromUniverse(IPlace place, IUniverse universe);

	/// <summary>
	/// Sets a place's IsFilteringEnabled attribute, and adjusts the parent game's IsSecure attribute where applicable.
	/// </summary>
	/// <param name="place"></param>
	/// <param name="isFilteringEnabled"></param>
	void SetPlaceIsFilteringEnabled(IPlace place, bool isFilteringEnabled);

	/// <summary>
	/// Whether there exists any place in the universe that does not have filtering enabled
	/// </summary>
	/// <returns>[False] If all places in the universe has filtering enabled.  [True] Otherwise. </returns>
	bool IsAnyPlaceInUniverseNotFilteringEnabled(IUniverse universe);
}
