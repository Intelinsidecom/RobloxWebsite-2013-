namespace Roblox.Platform.Assets;

public class LegsFactory : AssetFactoryBase<ILegs>
{
	protected override int AssetTypeId => Roblox.AssetType.LegsID;

	internal LegsFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ILegs BuildChildAsset(IAsset genericAsset)
	{
		return new Legs(base.DomainFactories, genericAsset);
	}

	internal ILegs GetLegs(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
