namespace Roblox.Platform.Assets;

public class AnimationFactory : AssetFactoryBase<IAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.AnimationID;

	internal AnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new Animation(base.DomainFactories, genericAsset);
	}

	internal IAnimation GetAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
