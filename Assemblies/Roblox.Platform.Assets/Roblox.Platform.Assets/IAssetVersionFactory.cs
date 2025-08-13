using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Roblox.DataV2.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.Platform.Assets;

/// <summary>
/// A public interface for the factory producing <see cref="T:Roblox.Platform.Assets.IAssetVersion" />s
/// </summary>
public interface IAssetVersionFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> with the specified id, guaranteed to not be null
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:Roblox.Platform.Assets.UnknownAssetVersionException">If there is no AssetVersion matching the id</exception>
	IAssetVersion CheckedGet(long? id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> with the specified id.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IAssetVersion Get(long? id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> for the specified asset and version number.
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="versionNumber">The version number.</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IAssetVersion GetByAssetAndVersionNumber(IAsset asset, int versionNumber);

	/// <summary>
	/// Gets the current <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> for the specified asset.
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="asset" /></exception>
	[Obsolete("Use GetCurrentAssetPublishedVersion or GetCurrentAssetSavedVersion instead")]
	IAssetVersion GetCurrentAssetVersion(IAsset asset);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> for the specified asset id and version number.
	/// </summary>
	/// <param name="assetId">The asset identifier.</param>
	/// <param name="versionNumber">The version number.</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IAssetVersion GetByAssetIdAndVersionNumber(long assetId, int versionNumber);

	/// <summary>
	/// Gets the collection of <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> for the specified rawContent, startRowIndex and and maximumRows.
	/// </summary>
	/// <param name="rawContent"><see cref="T:Roblox.Platform.Assets.IRawContent" /></param>
	/// <param name="startRowIndex">The start row index.</param>
	/// <param name="maximumRows">The maximum rows number.</param>
	/// <returns><see cref="!:ICollection" /> of <see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	ICollection<IAssetVersion> GetAssetVersionsByRawContent(IRawContent rawContent, int startRowIndex, int maximumRows);

	/// <summary>
	/// Gets the enumerable of <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> for the specified  offset and and count.
	/// </summary>
	/// <param name="asset"><see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="offset">The start row index.</param>
	/// <param name="count">The maximum rows number.</param>
	/// <returns><see cref="!:IEnumerable" /> of <see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IEnumerable<IAssetVersion> GetAssetVersionsPaged(IAsset asset, long offset, long count);

	/// <summary>
	/// Gets the enumerable of published <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> for the specified  offset and and count.
	/// </summary>
	/// <param name="asset"><see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="startRowIndex">The start row index.</param>
	/// <param name="count">The maximum rows number.</param>
	/// <param name="catchClientExceptions">setting this to true catches and logs all client exceptions</param>
	/// <returns><see cref="!:IEnumerable" /> of <see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="asset" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="startRowIndex" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="count" /></exception>
	IEnumerable<IAssetVersion> GetAssetPublishedVersionsPaged(IAsset asset, long startRowIndex, long count, bool catchClientExceptions = false);

	/// <summary>
	/// Get saved versions off an asset, with exclusive start paging.
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="exclusiveStartKeyInfo">Container for pagination parameters.</param>
	/// <returns>A page of asset versions.</returns>
	/// <exception cref="T:System.ArgumentNullException">All parameters required.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="exclusiveStartKeyInfo" /> contains invalid values.</exception>
	IPlatformPageResponse<string, IAssetVersion> GetAssetSavedVersionsPaged(IAsset asset, IExclusiveStartKeyInfo<string> exclusiveStartKeyInfo);

	ICollection<IAssetVersion> GetAssetSavedVersionsPaged(IAsset asset, int? exclusiveStartVersionNumber, int count, SortOrder sortOrder);

	/// <summary>
	/// Get published versions off an asset, with exclusive start paging.
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="exclusiveStartKeyInfo">Container for pagination parameters.</param>
	/// <returns>A page of asset versions.</returns>
	/// <exception cref="T:System.ArgumentNullException">All parameters required.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="exclusiveStartKeyInfo" /> contains invalid values.</exception>
	/// <exception cref="T:System.ApplicationException">Cannot translate <see cref="T:Roblox.Platform.Assets.AssetType" /> to <see cref="T:Roblox.Assets.Client.AssetType" /></exception>
	IPlatformPageResponse<string, IAssetVersion> GetAssetPublishedVersionsPaged(IAsset asset, IExclusiveStartKeyInfo<string> exclusiveStartKeyInfo);

	/// <summary>
	/// Gets the current <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> of an asset. Not to be used for <see cref="T:Roblox.Platform.Assets.IPlace" />.
	/// </summary>
	/// <param name="asset"><see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="asset" /></exception>
	IAssetVersion GetCurrentAssetPublishedVersion(IAsset asset);

	/// <summary>
	/// Gets the current published <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> of a place
	/// </summary>
	/// <param name="place"><see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	IAssetVersion GetCurrentPlacePublishedVersion(IAsset place);

	/// <summary>
	/// Gets the current saved <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> of a place
	/// </summary>
	/// <param name="place"><see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	IAssetVersion GetCurrentPlaceSavedVersion(IAsset place);

	/// <summary>
	/// Get Current Place Published <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> of a place
	/// </summary>
	/// <param name="place"><see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="isJvRequest">specified if the request for JV users</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="place" /></exception>
	IAssetVersion GetCurrentPlacePublishedVersion(IAsset place, bool isJvRequest);

	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> with the provided info
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <param name="parentAssetVersion">The parent asset version.</param>
	/// <param name="content">The content.</param>
	/// <param name="decompressionMethod">The decompression method.</param>
	/// <param name="expectedContentSize">Expected size of the content.</param>
	/// <param name="expectedContentHash">The expected content hash.</param>
	/// <param name="creatingUniverseId">The creating universe identifier.</param>
	/// <param name="creationContext">The creation context.</param>
	/// <param name="mimeType">Type of the MIME.</param>
	/// <param name="isSavedVersionOnly"> determines if the created version is saved only</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IAssetVersion Create(IAsset asset, CreatorType creatorType, long creatorTargetId, IAssetVersion parentAssetVersion, Stream content, DecompressionMethods decompressionMethod = DecompressionMethods.None, int? expectedContentSize = null, string expectedContentHash = null, long? creatingUniverseId = null, CreationContextType? creationContext = null, string mimeType = null, bool isSavedVersionOnly = false);

	/// <summary>
	/// Returns saved Asset versions with an is published flag
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="offset">The start row index.</param>
	/// <param name="count">The maximum rows number.</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.PlatformAssetPublishedVersionsResponse" /></returns>
	ICollection<PlatformAssetPublishedVersionsResponse> GetAssetSavedVersionsWithPublishedFlagPaged(IAsset asset, int offset, int count);

	/// <summary>
	/// Returns saved Asset versions with an is published flag
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="versionNumberExclusiveStartKey">start version number</param>
	/// <param name="count">number of requested elements</param>
	/// <param name="sortOrder">sort order</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.PlatformAssetPublishedVersionsResponse" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="asset" /> </exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="count" /> is less than 0</exception>
	ICollection<PlatformAssetPublishedVersionsResponse> GetAssetSavedVersionsWithPublishedFlagPaged(IAsset asset, int? versionNumberExclusiveStartKey, int count, SortOrder sortOrder);

	/// <summary>
	/// returns the total number of asset versions
	/// </summary>
	/// <param name="assetId"></param>
	/// <returns></returns>
	int GetTotalNumberOfAssetVersionsByAssetID(long assetId);

	/// <summary>
	/// returns the total number of asset versions based on a specific hash
	/// </summary>
	/// <param name="assetHashId"></param>
	/// <returns></returns>
	int GetTotalNumberOfAssetVersionsByAssetHashID(long assetHashId);

	/// <summary>
	/// Returns the current saved version of an asset.
	/// </summary>
	/// <param name="asset"></param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IAssetVersion GetCurrentAssetSavedVersion(IAsset asset);

	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> with the provided info
	/// </summary>
	/// <param name="asset">The asset.</param>
	/// <param name="creatorType">Type of the creator.</param>
	/// <param name="creatorTargetId">The creator target identifier.</param>
	/// <param name="rawContent">Content of the raw.</param>
	/// <param name="parentAssetVersion">The parent asset version.</param>
	/// <param name="creatingUniverseId">The creating universe identifier.</param>
	/// <param name="creationContext">The creation context.</param>
	/// <param name="isSavedVersionOnly"> determines if the created version is saved only</param>
	/// <param name="localeCodeOverride">The locale code for moderation review task</param>
	/// <returns><see cref="T:Roblox.Platform.Assets.IAssetVersion" /></returns>
	IAssetVersion Create(IAsset asset, CreatorType creatorType, long creatorTargetId, IRawContent rawContent, IAssetVersion parentAssetVersion, long? creatingUniverseId, CreationContextType? creationContext = null, bool isSavedVersionOnly = false, string localeCodeOverride = null);
}
