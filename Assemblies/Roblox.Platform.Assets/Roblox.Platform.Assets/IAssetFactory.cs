using System;
using System.Collections.Generic;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <summary>
/// A public interface for a factory producing <see cref="T:Roblox.Platform.Assets.IAsset" />s
/// </summary>
public interface IAssetFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAsset" /> of the specified id.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.IAsset" /> of the specified id.  Never returns null.</returns>
	/// <exception cref="T:Roblox.Platform.Assets.UnknownAssetException">If no asset exists corresponding to the specified id</exception>
	IAsset CheckedGetAsset(long? id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAsset" /> of the specified id.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.IAsset" /> of the specified id.  Null if no asset is found.</returns>
	IAsset GetAsset(long? id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAsset" />s for the specified ids.
	/// </summary>
	/// <param name="ids">The ids of the assets we are interested in.</param>
	/// <returns>The requested <see name="IAsset" />s.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="ids" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="ids" /> is empty.</exception>
	IEnumerable<IAsset> GetAssets(IReadOnlyCollection<long> ids);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAsset" />s of the specified <see cref="T:Roblox.Platform.Assets.ICreationScope" /> and universe id.
	/// </summary>
	IEnumerable<IAsset> GetAssetsByCreationScope(ICreationScope creationScope, long? creatingUniverseId, long offset, long count);

	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.IAsset" /> with the specified info.
	/// </summary>
	[Obsolete("Universal Asset creation is deprecated and can lead to runtime failures.  This function will throw for numerous AssetTypes, because more information is required.  Choose a type-specific creation method instead.")]
	IAsset Create(int assetTypeId, IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.IAsset" /> with the specified info.
	/// </summary>
	[Obsolete("Universal Asset creation is deprecated and can lead to runtime failures.  This function will throw for numerous AssetTypes, because more information is required.  Choose a type-specific creation method instead.")]
	IAsset Create(int assetTypeId, IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Get associated image asset of an asset, varies by asset type.
	/// </summary>
	/// <param name="asset">The original <see cref="T:Roblox.IAsset" /> that the image asset is associated with.</param>
	/// <returns>The image <see cref="T:Roblox.IAsset" /> associated with the input asset.</returns>
	Roblox.IAsset GetAssociatedImageAsset(Roblox.IAsset asset);

	/// <summary>
	/// Get associated image asset id of an asset, varies by asset type.
	/// </summary>
	/// <param name="assetHash">Md5 hash of requested asset.</param>
	/// <returns>id of dependent image if it exists</returns>
	long? GetDecalOrClothingImageAssetId(string assetHash);
}
