namespace Roblox.Platform.Assets;

public class GearFactory : AssetFactoryBase<IGear>
{
	protected override int AssetTypeId => Roblox.AssetType.GearID;

	internal GearFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IGear BuildChildAsset(IAsset genericAsset)
	{
		return new Gear(base.DomainFactories, genericAsset);
	}

	internal IGear GetGear(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
