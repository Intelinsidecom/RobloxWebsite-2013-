namespace Roblox.Platform.Assets;

public class WalkAnimationFactory : AssetFactoryBase<IWalkAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.WalkAnimationID;

	internal WalkAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IWalkAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new WalkAnimation(base.DomainFactories, genericAsset);
	}

	internal IWalkAnimation GetWalkAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
