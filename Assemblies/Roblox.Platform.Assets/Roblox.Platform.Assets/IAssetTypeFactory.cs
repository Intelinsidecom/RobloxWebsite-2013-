using System.Collections.Generic;
using Roblox.Assets.Client;

namespace Roblox.Platform.Assets;

/// <summary>
/// Public interface for the factory for <see cref="T:Roblox.Platform.Assets.AssetType" />s
/// </summary>
public interface IAssetTypeFactory
{
	/// <summary>
	/// This method returns an <see cref="T:Roblox.Platform.Assets.AssetType" /> object based off AssetType ID provided 
	/// This method returns null if the AssetType is not found
	/// </summary>
	/// <param name="id"></param>
	AssetType? GetAssetType(int id);

	/// <summary>
	/// This method returns an <see cref="T:Roblox.Platform.Assets.AssetType" /> object based off the legacy AssetType value provided 
	/// This method returns null if the AssetType is not found
	/// </summary>
	/// <param name="assetTypeValue"></param>
	AssetType? GetAssetTypeByValue(string assetTypeValue);

	/// <summary>
	/// Return assetType associated ID from DB 
	/// </summary>
	/// <param name="assetType"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if assetType could not be found.</exception>
	int ToId(AssetType assetType);

	/// <summary>
	/// Return the legacy asset type value given the asset type.  
	/// </summary>
	/// <param name="assetType"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if assetType could not be found.</exception>
	string ToLegacyValue(AssetType assetType);

	/// <summary>
	/// Gets <see cref="T:Roblox.Platform.Assets.AssetCategory" /> for a given <see cref="T:Roblox.Platform.Assets.AssetType" />
	/// </summary>
	/// <param name="assetType">An <see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.AssetCategory" /> for the given <see cref="T:Roblox.Platform.Assets.AssetType" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if the provided <see cref="T:Roblox.Platform.Assets.AssetType" /> could not be found.</exception>
	AssetCategory GetAssetTypeCategory(AssetType assetType);

	/// <summary>
	/// Returns review requirement for asset type.
	/// </summary>
	/// <param name="assetType">An <see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <returns>requires review status</returns>
	bool DoesAssetTypeRequireReview(AssetType assetType);

	/// <summary>
	/// Helper to translate <see cref="T:Roblox.Platform.Assets.AssetType" /> to <see cref="T:Roblox.Assets.Client.AssetType" />.
	/// </summary>
	/// <param name="platformAssetType">The platform asset type enum.</param>
	/// <returns>Assets service client's asset type enum.</returns>
	AssetType ToAssetsClientAssetType(AssetType platformAssetType);

	/// <summary>
	/// function to determine if a archival is enabled for a type
	/// </summary>
	/// <param name="assetType"><see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <returns>If Archival is enabled for type</returns>
	bool IsArchivalEnabledForType(AssetType assetType);

	/// <summary>
	/// Returns a enumerable of asset types that are allowed to be archived.
	/// </summary>
	/// <returns><see cref="T:System.Collections.Generic.IEnumerable`1" /></returns>
	IEnumerable<AssetType> GetArchivalEnabledTypes();

	/// <summary>
	/// Returns if an asset type supports versioning
	/// </summary>
	/// <param name="assetType"><see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <returns>True if versioning is supported</returns>
	bool IsAssetTypeVersioningEnabled(AssetType assetType);

	/// <summary>
	/// Returns if an asset type is on marketplace
	/// </summary>
	/// <param name="assetType"><see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <returns>True if the asset type is on marketplace</returns>
	bool IsAssetTypeOnMarketplace(AssetType assetType);

	/// <summary>
	/// Returns if an asset type can have a thumbnail
	/// </summary>
	/// <param name="assetType"><see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <returns>True if the asset type can have a thumbnail</returns>
	bool CanAssetTypeHaveThumbnail(AssetType assetType);
}
