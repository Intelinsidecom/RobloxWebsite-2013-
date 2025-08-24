namespace Roblox.Platform.Assets;

public class EmoteAnimationFactory : AssetFactoryBase<IEmoteAnimation>
{
	protected override int AssetTypeId { get; } = 61;


	internal EmoteAnimationFactory(AssetDomainFactories assetDomainFactories)
		: base(assetDomainFactories)
	{
	}

	protected override IEmoteAnimation BuildChildAsset(IAsset asset)
	{
		return new EmoteAnimation(base.DomainFactories, asset);
	}

	internal IEmoteAnimation GetEmoteAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
