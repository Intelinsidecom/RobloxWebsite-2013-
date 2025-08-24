namespace Roblox.Platform.Assets;

/// <summary>
/// Configuration related to publishing and serving asset versions.
/// </summary>
public interface IAssetVersionsConfigurationProvider
{
	/// <summary>
	/// Whether the asset type is supported by Assets service's publish functionality.
	/// </summary>
	/// <param name="assetType">The asset type.</param>
	/// <returns>True if supported, false otherwise.</returns>
	bool IsPublishToAssetPublishedVersionsEnabledForAssetType(AssetType assetType);

	/// <summary>
	/// Whether published versions of the asset is served from Assets service.
	/// </summary>
	/// <param name="assetType">The asset type.</param>
	/// <param name="assetId">The asset ID.</param>
	/// <returns>True: the published versions will be served from Assets service. Otherwise false.</returns>
	bool IsServeFromAssetPublishedVersionsEnabledForAssetType(AssetType assetType, long assetId);
}
