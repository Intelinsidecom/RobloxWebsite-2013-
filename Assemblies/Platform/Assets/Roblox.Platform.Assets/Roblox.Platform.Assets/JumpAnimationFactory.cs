namespace Roblox.Platform.Assets;

public class JumpAnimationFactory : AssetFactoryBase<IJumpAnimation>
{
	protected override int AssetTypeId => Roblox.AssetType.JumpAnimationID;

	internal JumpAnimationFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IJumpAnimation BuildChildAsset(IAsset genericAsset)
	{
		return new JumpAnimation(base.DomainFactories, genericAsset);
	}

	internal IJumpAnimation GetJumpAnimation(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
