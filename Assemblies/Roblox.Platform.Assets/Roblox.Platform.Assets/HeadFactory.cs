namespace Roblox.Platform.Assets;

public class HeadFactory : AssetFactoryBase<IHead>
{
	protected override int AssetTypeId => Roblox.AssetType.HeadID;

	internal HeadFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IHead BuildChildAsset(IAsset genericAsset)
	{
		return new Head(base.DomainFactories, genericAsset);
	}

	internal IHead GetHead(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
