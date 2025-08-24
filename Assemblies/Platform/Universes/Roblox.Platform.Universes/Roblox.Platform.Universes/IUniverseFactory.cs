using System;
using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Universes;

/// <summary>
/// Creates/Gets universe <see cref="T:Roblox.Platform.Universes.IUniverse" />.
/// Exposes helper methods for working with universes.
/// </summary>
public interface IUniverseFactory
{
	/// <summary>
	/// Gets the universe.
	/// </summary>
	/// <param name="universeId">The universe identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Universes.IUniverse" />.</returns>
	IUniverse GetUniverse(long universeId);

	/// <summary>
	/// Gets a number of universes.
	/// </summary>
	/// <param name="universeIds">All universes to get.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of all requested universes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// Thrown if <paramref name="universeIds" /> is null.
	/// </exception>
	IEnumerable<IUniverse> GetUniverses(IEnumerable<long> universeIds);

	/// <summary>
	/// Gets the universe for specified place identifier.
	/// </summary>
	/// <param name="placeId">The place identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Universes.IUniverse" />.</returns>
	[Obsolete("Should use GetPlaceUniverse(IPlace) instead.")]
	IUniverse GetPlaceUniverse(long placeId);

	/// <summary>
	/// Gets universe for specified place.
	/// </summary>
	/// <param name="place">The place <see cref="T:Roblox.Platform.Assets.IPlace" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Universes.IUniverse" /></returns>
	IUniverse GetPlaceUniverse(IPlace place);

	/// <summary>
	/// Gets the universe for each <see cref="T:Roblox.Platform.Assets.IPlace" />.
	/// </summary>
	/// <param name="placeIds">The <see cref="T:Roblox.Platform.Assets.IPlace" />s to fetch universes for, identified by it's id.</param>
	/// <returns>A lookup containing the universe for each place.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="placeIds" /></exception>
	[Obsolete("Should use GetUniverseByPlaces(IReadOnlyCOllection<IPlace>) instead.")]
	IDictionary<long, IUniverse> GetUniverseByPlaces(IReadOnlyCollection<long> placeIds);

	/// <summary>
	/// Gets the universe for each <see cref="T:Roblox.Platform.Assets.IPlace" />.
	/// </summary>
	/// <param name="places">The <see cref="T:Roblox.Platform.Assets.IPlace" />s to fetch universes for.</param>
	/// <returns>A lookup containing the universe for each place.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="places" /></exception>
	/// <exception cref="T:System.ArgumentException">Any <paramref name="places" /> entry is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="places" /> contains entries with duplicate IDs.</exception>
	IDictionary<IPlace, IUniverse> GetUniverseByPlaces(IReadOnlyCollection<IPlace> places);

	/// <summary>
	/// Gets the universe places paged.
	/// </summary>
	/// <param name="universeId">The universe identifier.</param>
	/// <param name="page">The page number.</param>
	/// <param name="totalCount">The total count of places in specified Universe.</param>
	/// <param name="isUniverseCreation">if set to true then returns places which are created by Universe, 
	/// otherwise returns places which are created by user.</param>
	/// <returns>IEnumerable collection of <see cref="T:Roblox.Platform.Assets.IPlace" /> entities.</returns>
	[Obsolete("Please use GetUniversePlaces, or GetUniverseCreationPlaces instead.")]
	IEnumerable<IPlace> GetUniversePlacesPaged(long universeId, int page, out long totalCount, bool isUniverseCreation);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.Assets.IPlace" />s in a universe with the given <paramref name="universeId" />
	/// </summary>
	/// <param name="universeId">The universe id.</param>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.Assets.IPlace" />s</returns>
	IPlatformPageResponse<long, IPlace> GetUniversePlaces(long universeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of universe creation <see cref="T:Roblox.Platform.Assets.IPlace" />s in a universe with the given <paramref name="universeId" />
	/// </summary>
	/// <param name="universeId">The universe id.</param>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.Assets.IPlace" />s</returns>
	IPlatformPageResponse<long, IPlace> GetUniverseCreationPlaces(long universeId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Creates a new universe with a given root <see cref="T:Roblox.Platform.Assets.IPlace" />.
	/// </summary>
	/// <param name="rootPlace">An orphan <see cref="T:Roblox.Platform.Assets.IPlace" /> that will be the root place of the created universe.</param>
	/// <param name="shopId">The ID of the shop for the universe..</param>
	/// <param name="privacyType">The initial privacy type of the universe.</param>
	/// <returns>ID of the new universe.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// Thrown if <paramref name="rootPlace" /> is null.
	/// </exception>
	/// <exception cref="T:System.ArgumentException">Thrown if:
	/// - <paramref name="rootPlace" /> has an invalid creator type.
	/// - the place referenced by <paramref name="rootPlace" /> is the root place of an existing universe.
	/// - the privacy type provided in <paramref name="privacyType" /> is not Public, Private, or Draft.
	/// </exception>
	/// <exception cref="T:System.Net.WebException">Thrown for any unexpected result from the service.</exception>
	long CreateUniverse(IPlace rootPlace, long shopId, string privacyType = null);

	/// <summary>
	/// Gets universes for specified creator.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <param name="page">The page number.</param>
	/// <param name="totalCount">The total count of universes which are created by specified creator.</param>
	/// <returns>IEnumerable collection of IUniverse entities.</returns>
	[Obsolete("Please use GetCreatorUniverses instead.")]
	IEnumerable<IUniverse> GetCreatorUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int page, out long totalCount);

	/// <summary>
	/// Gets universes for specified creator.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <param name="startIndex">The start index.</param>
	/// <param name="count">Amount of results.</param>
	/// <param name="totalCount">The total count of universes which are created by specified creator.</param>
	/// <returns>
	/// IEnumerable collection of IUniverse entities.
	/// </returns>
	[Obsolete("Please use GetCreatorUniverses instead.")]
	IEnumerable<IUniverse> GetCreatorUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int startIndex, int count, out long totalCount);

	/// <summary>
	/// Gets public universes for specified creator.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <param name="page">The page number.</param>
	/// <param name="totalCount">The total count of universes which are created by specified creator.</param>
	/// <returns>IEnumerable collection of IUniverse entities.</returns>
	IEnumerable<IUniverse> GetCreatorPublicUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int page, out long totalCount);

	/// <summary>
	/// Gets public universes for specified creator.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <param name="startIndex">The start index.</param>
	/// <param name="count">Amount of results.</param>
	/// <param name="totalCount">The total count of universes which are created by specified creator.</param>
	/// <returns>IEnumerable collection of IUniverse entities.</returns>
	IEnumerable<IUniverse> GetCreatorPublicUniversesPaged(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, int startIndex, int count, out long totalCount);

	/// <summary>
	/// Gets universes made by the specified creator.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target id.</param>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.Universes.IUniverse" />s</returns>
	IPlatformPageResponse<long, IUniverse> GetCreatorUniverses(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets universes made by the specified creator.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target id.</param>
	/// <param name="exclusiveStartKeyInfo">The <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo`1" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.PlatformPageResponse`2" /> of <see cref="T:Roblox.Platform.Universes.IUniverse" />s</returns>
	IPlatformPageResponse<long, IUniverse> GetCreatorPublicUniverses(Roblox.Platform.Core.CreatorType creatorType, long creatorTargetId, IExclusiveStartKeyInfo<long> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets the universe shop identifier.
	/// </summary>
	/// <param name="universeId">The universe identifier.</param>
	/// <returns>Universe shop identifier. </returns>
	long? GetUniverseShopId(long universeId);

	/// <summary>
	/// Gets the universe by shop identifier.
	/// </summary>
	/// <param name="shopId">The shop identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Universes.IUniverse" /></returns>
	IUniverse GetUniverseByShopId(long shopId);

	/// <summary>
	/// Sets the universe creator.
	/// </summary>
	/// <param name="universeId">The universe identifier.</param>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	void SetUniverseCreator(long universeId, string creatorType, long creatorTargetId);

	/// <summary>
	/// Gets the universe places ids paged.
	/// </summary>
	/// <param name="universeId">The universe identifier.</param>
	/// <param name="page">The page number.</param>
	/// <param name="totalCount">The total count of places in specified Universe.</param>
	/// <param name="isUniverseCreation">if set to true then returns places which are created by Universe, 
	/// otherwise returns places which are created by user.</param>
	/// <returns>IEnumerable collection of place ids.</returns>
	[Obsolete("Please use GetUniversePlaces, or GetUniverseCreationPlaces instead.")]
	IEnumerable<long> GetUniversePlaceIdsPaged(long universeId, int page, out long totalCount, bool isUniverseCreation);

	/// <summary>
	/// Get the total number of public universes a creator has.
	/// </summary>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <returns>The total number of public universes a creator has</returns>
	int GetCreatorPublicUniverseCount(string creatorType, long creatorTargetId);
}
