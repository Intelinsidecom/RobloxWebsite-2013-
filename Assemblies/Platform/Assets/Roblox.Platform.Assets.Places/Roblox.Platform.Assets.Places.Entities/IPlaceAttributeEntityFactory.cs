using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Places.Entities;

internal interface IPlaceAttributeEntityFactory : IDomainFactory<PlaceAttributesDomainFactories>, IDomainObject<PlaceAttributesDomainFactories>
{
	/// <summary>
	/// Gets or creates <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" /> with the given placeId.
	/// </summary>
	IPlaceAttributeEntity GetOrCreate(long placeId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" />s by their universeId and whether FilteringEnabled is on.
	/// </summary>
	/// <param name="universeId">The universe id</param>
	/// <param name="isFilteringEnabled">whether FilteringEnabled is on</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.  Defaults to 0 for the first page of results, must not be null.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" />s.</returns>
	IEnumerable<IPlaceAttributeEntity> GetByUniverseIdAndIsFilteringEnabledEnumerative(long? universeId, bool? isFilteringEnabled, int count, long exclusiveStartId = 0L);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" /> by its Id.
	/// </summary>
	IPlaceAttributeEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.Places.Entities.IPlaceAttributeEntity" /> with the given placeId
	/// </summary>
	IPlaceAttributeEntity GetByPlaceId(long placeId);
}
