namespace Roblox.Platform.Assets;

public class RightLegFactory : AssetFactoryBase<IRightLeg>
{
	protected override int AssetTypeId => Roblox.AssetType.RightLegID;

	internal RightLegFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IRightLeg BuildChildAsset(IAsset genericAsset)
	{
		return new RightLeg(base.DomainFactories, genericAsset);
	}

	internal IRightLeg GetRightLeg(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
