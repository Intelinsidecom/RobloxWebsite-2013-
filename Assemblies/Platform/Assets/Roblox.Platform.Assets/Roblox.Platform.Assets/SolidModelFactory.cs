namespace Roblox.Platform.Assets;

public class SolidModelFactory : AssetFactoryBase<ISolidModel>
{
	protected override int AssetTypeId => Roblox.AssetType.SolidModelID;

	internal SolidModelFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ISolidModel BuildChildAsset(IAsset genericAsset)
	{
		return new SolidModel(base.DomainFactories, genericAsset);
	}

	internal ISolidModel GetSolidModel(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
