namespace Roblox.Platform.Assets;

public class ClimbAnimationFactory : AssetFactoryBase<IClimbAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.ClimbAnimationID;

	internal ClimbAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IClimbAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new ClimbAnimation(base.DomainFactories, genericAsset);
	}

	internal IClimbAnimation GetClimbAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
