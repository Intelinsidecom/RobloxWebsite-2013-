using System.Collections.Generic;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public interface IGamePassFactory : IAssetFactoryBase<IGamePass>
{
	/// <summary>
	/// Creates a Game Pass for a given place
	/// </summary>
	IGamePass CreateGamePass(AssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IImage image, IPlace place, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Gets the total number of Game Passes for a given Place.
	/// </summary>
	/// <param name="placeId">The Id of a Place to get total for.</param>
	/// <returns>The total number of Game Passes for the given Place Id</returns>
	long GetTotalNumberOfGamePassesByPlaceId(long placeId);

	/// <summary>
	/// Gets all the Game Passes attached to a given Place.
	/// </summary>
	/// <param name="placeId">The Id of a Place to get Game Passes for.</param>
	/// <param name="startRowIndex">The starting index to fetch. One indexed.</param>
	/// <param name="maximumRows">The maximum number of items to fetch. One indexed.</param>
	/// <returns>A collection of <see cref="T:Roblox.Platform.Assets.IGamePass" />es.</returns>
	/// <exception cref="T:System.ArgumentException">Thrown if placeId is the default value.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if startRowIndex is less than 1.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if maximumRows is less than 1.</exception>
	ICollection<IGamePass> GetGamePassesByPlaceId_Paged(long placeId, int startRowIndex, int maximumRows);
}
