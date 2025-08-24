namespace Roblox.Platform.Assets;

public class LeftLegFactory : AssetFactoryBase<ILeftLeg>
{
	protected override int AssetTypeId => Roblox.AssetType.LeftLegID;

	internal LeftLegFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ILeftLeg BuildChildAsset(IAsset genericAsset)
	{
		return new LeftLeg(base.DomainFactories, genericAsset);
	}

	internal ILeftLeg GetLeftLeg(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
