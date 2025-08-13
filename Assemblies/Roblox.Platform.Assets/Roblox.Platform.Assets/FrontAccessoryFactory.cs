namespace Roblox.Platform.Assets;

public class FrontAccessoryFactory : AssetFactoryBase<IFrontAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.FrontAccessoryID;

	internal FrontAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IFrontAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new FrontAccessory(base.DomainFactories, genericAsset);
	}

	internal IFrontAccessory GetFrontAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
