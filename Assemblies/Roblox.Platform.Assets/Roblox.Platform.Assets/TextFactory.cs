namespace Roblox.Platform.Assets;

public class TextFactory : AssetFactoryBase<IText>
{
	protected override int AssetTypeId => Roblox.AssetType.TextID;

	internal TextFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IText BuildChildAsset(IAsset genericAsset)
	{
		return new Text(base.DomainFactories, genericAsset);
	}

	internal IText GetText(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
