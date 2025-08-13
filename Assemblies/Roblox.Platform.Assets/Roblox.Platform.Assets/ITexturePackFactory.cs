namespace Roblox.Platform.Assets;

/// <summary>
/// Represents the interface of factories for custom material assets.
/// </summary>
public interface ITexturePackFactory : IAssetFactoryBase<ITexturePack>
{
	/// <summary>
	/// Returns custom material by <see cref="T:Roblox.Platform.Assets.IAsset" />.
	/// </summary>
	/// <param name="genericAsset"></param>
	/// <returns><see cref="T:Roblox.Platform.Assets.ITexturePack" /></returns>
	ITexturePack GetTexturePack(IAsset genericAsset);
}
