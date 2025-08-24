namespace Roblox.Platform.Assets;

public class HairAccessoryFactory : AssetFactoryBase<IHairAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.HairAccessoryID;

	internal HairAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IHairAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new HairAccessory(base.DomainFactories, genericAsset);
	}

	internal IHairAccessory GetHairAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
