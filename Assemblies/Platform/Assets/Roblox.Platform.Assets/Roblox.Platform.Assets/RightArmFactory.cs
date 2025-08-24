namespace Roblox.Platform.Assets;

public class RightArmFactory : AssetFactoryBase<IRightArm>
{
	protected override int AssetTypeId => Roblox.AssetType.RightArmID;

	internal RightArmFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IRightArm BuildChildAsset(IAsset genericAsset)
	{
		return new RightArm(base.DomainFactories, genericAsset);
	}

	internal IRightArm GetRightArm(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
