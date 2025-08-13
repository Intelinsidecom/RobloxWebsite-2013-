namespace Roblox.Platform.Assets;

public class IdleAnimationFactory : AssetFactoryBase<IIdleAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.IdleAnimationID;

	internal IdleAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IIdleAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new IdleAnimation(base.DomainFactories, genericAsset);
	}

	internal IIdleAnimation GetIdleAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
