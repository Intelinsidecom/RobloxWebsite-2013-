namespace Roblox.Platform.Assets;

public class RunAnimationFactory : AssetFactoryBase<IRunAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.RunAnimationID;

	internal RunAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IRunAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new RunAnimation(base.DomainFactories, genericAsset);
	}

	internal IRunAnimation GetRunAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
