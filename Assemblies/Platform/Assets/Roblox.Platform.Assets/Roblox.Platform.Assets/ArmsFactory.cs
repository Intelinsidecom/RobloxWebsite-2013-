namespace Roblox.Platform.Assets;

public class ArmsFactory : AssetFactoryBase<IArms>
{
	protected override int AssetTypeId => Roblox.AssetType.ArmsID;

	internal ArmsFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IArms BuildChildAsset(IAsset genericAsset)
	{
		return new Arms(base.DomainFactories, genericAsset);
	}

	internal IArms GetArms(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
