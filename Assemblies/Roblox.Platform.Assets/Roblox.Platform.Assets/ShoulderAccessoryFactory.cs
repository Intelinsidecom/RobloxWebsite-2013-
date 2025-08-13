namespace Roblox.Platform.Assets;

public class ShoulderAccessoryFactory : AssetFactoryBase<IShoulderAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.ShoulderAccessoryID;

	internal ShoulderAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IShoulderAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new ShoulderAccessory(base.DomainFactories, genericAsset);
	}

	internal IShoulderAccessory GetShoulderAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
