namespace Roblox.Platform.Assets;

public class SwimAnimationFactory : AssetFactoryBase<ISwimAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.SwimAnimationID;

	internal SwimAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ISwimAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new SwimAnimation(base.DomainFactories, genericAsset);
	}

	internal ISwimAnimation GetSwimAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
