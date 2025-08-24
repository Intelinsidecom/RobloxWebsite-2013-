namespace Roblox.Platform.Assets;

/// <summary>
/// Internal interface for a factory producing <see cref="T:Roblox.Platform.Assets.IAssetVersion" />s
/// </summary>
internal interface IAssetVersionFactory_Internal : IAssetVersionFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> with the provided entity object
	/// </summary>
	IAssetVersion GetAssetVersion(Roblox.AssetVersion assetVersionEntity);
}
