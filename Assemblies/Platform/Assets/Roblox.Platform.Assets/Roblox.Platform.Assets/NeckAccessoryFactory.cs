namespace Roblox.Platform.Assets;

public class NeckAccessoryFactory : AssetFactoryBase<INeckAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.NeckAccessoryID;

	internal NeckAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override INeckAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new NeckAccessory(base.DomainFactories, genericAsset);
	}

	internal INeckAccessory GetNeckAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
