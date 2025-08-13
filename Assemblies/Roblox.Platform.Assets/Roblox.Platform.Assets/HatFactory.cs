namespace Roblox.Platform.Assets;

public class HatFactory : AssetFactoryBase<IHat>
{
	protected override int AssetTypeId => Roblox.AssetType.HatID;

	internal HatFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IHat BuildChildAsset(IAsset genericAsset)
	{
		return new Hat(base.DomainFactories, genericAsset);
	}

	internal IHat GetHat(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
