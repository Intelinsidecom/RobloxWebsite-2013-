namespace Roblox.Platform.Assets;

public class DeathAnimationFactory : AssetFactoryBase<IDeathAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.DeathAnimationID;

	internal DeathAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IDeathAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new DeathAnimation(base.DomainFactories, genericAsset);
	}

	internal IDeathAnimation GetDeathAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
