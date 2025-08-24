namespace Roblox.Platform.Assets;

public class BackAccessoryFactory : AssetFactoryBase<IBackAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.BackAccessoryID;

	internal BackAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IBackAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new BackAccessory(base.DomainFactories, genericAsset);
	}

	internal IBackAccessory GetBackAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
