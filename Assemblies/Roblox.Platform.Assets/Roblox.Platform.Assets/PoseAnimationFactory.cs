namespace Roblox.Platform.Assets;

public class PoseAnimationFactory : AssetFactoryBase<IPoseAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.PoseAnimationID;

	internal PoseAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IPoseAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new PoseAnimation(base.DomainFactories, genericAsset);
	}

	internal IPoseAnimation GetPoseAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
