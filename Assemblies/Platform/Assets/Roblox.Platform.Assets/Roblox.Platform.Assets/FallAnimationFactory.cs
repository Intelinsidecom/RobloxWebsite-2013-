namespace Roblox.Platform.Assets;

public class FallAnimationFactory : AssetFactoryBase<IFallAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.FallAnimationID;

	internal FallAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IFallAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new FallAnimation(base.DomainFactories, genericAsset);
	}

	internal IFallAnimation GetFallAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
