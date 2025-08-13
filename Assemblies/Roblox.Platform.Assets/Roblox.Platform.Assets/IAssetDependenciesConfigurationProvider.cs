namespace Roblox.Platform.Assets;

/// <summary>
/// Configuration related to publishing and serving asset versions.
/// </summary>
public interface IAssetDependenciesConfigurationProvider
{
	/// <summary>
	/// Whether the asset type is supported by the Asset Dependencies service.
	/// </summary>
	/// <param name="assetId">The asset id.</param>
	/// <returns>True if supported, false otherwise.</returns>
	bool IsCreateAssetDependencyAllowedForAsset(long assetId);
}
