using Roblox.Platform.Assets;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

/// <summary>
/// A factory producing <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" />.
/// </summary>
public interface IGameWithUniverseAndRootPlaceFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> by its <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> of the universe, or null if the game does not have a root place.</returns>
	IGameWithUniverseAndRootPlace Get(IUniverse universe);

	/// <summary>
	/// Gets an  <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> by its <see cref="T:Roblox.Platform.Assets.IPlace">root place</see>.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> of the place, or null if the place is not the root place of a game.</returns>
	IGameWithUniverseAndRootPlace GetByRootPlace(IPlace rootPlace);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> by any of its <see cref="T:Roblox.Platform.Assets.IPlace">places</see>.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> containing the place, or null if the place does not belong to a well-defined <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" />.</returns>
	IGameWithUniverseAndRootPlace GetByPlace(IPlace place);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> by a place id.
	/// </summary>
	/// <param name="placeId"></param>
	/// <param name="name"></param>
	/// <returns></returns>
	IGameWithUniverseAndRootPlace GetByPlaceId(long placeId, string name = null);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Games.IGameWithUniverseAndRootPlace" /> by a universe id.
	/// </summary>
	/// <param name="universeId"></param>
	/// <returns></returns>
	IGameWithUniverseAndRootPlace GetByUniverseId(long universeId);
}
