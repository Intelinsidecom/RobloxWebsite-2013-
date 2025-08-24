namespace Roblox.Platform.Assets;

public class WaistAccessoryFactory : AssetFactoryBase<IWaistAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.WaistAccessoryID;

	internal WaistAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IWaistAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new WaistAccessory(base.DomainFactories, genericAsset);
	}

	internal IWaistAccessory GetWaistAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
