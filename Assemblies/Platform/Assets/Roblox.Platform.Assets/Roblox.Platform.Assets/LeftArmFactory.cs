namespace Roblox.Platform.Assets;

public class LeftArmFactory : AssetFactoryBase<ILeftArm>
{
	protected override int AssetTypeId => Roblox.AssetType.LeftArmID;

	internal LeftArmFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ILeftArm BuildChildAsset(IAsset genericAsset)
	{
		return new LeftArm(base.DomainFactories, genericAsset);
	}

	internal ILeftArm GetLeftArm(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
