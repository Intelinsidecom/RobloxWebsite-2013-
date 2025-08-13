namespace Roblox.Platform.Assets;

/// <summary>
/// Represents a factory for <see cref="T:Roblox.Platform.Assets.TexturePack" /> assets.
/// </summary>
public class TexturePackFactory : AssetFactoryBase<ITexturePack>, ITexturePackFactory, IAssetFactoryBase<ITexturePack>
{
	protected override int AssetTypeId => Roblox.AssetType.TexturePackID;

	/// <summary>
	/// Constructor of <see cref="T:Roblox.Platform.Assets.TexturePackFactory" />.
	/// </summary>
	/// <param name="domainFactories"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null.</exception>
	public TexturePackFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	/// <inheritdoc />
	public ITexturePack GetTexturePack(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}

	protected override ITexturePack BuildChildAsset(IAsset genericAsset)
	{
		return new TexturePack(base.DomainFactories, genericAsset);
	}
}
