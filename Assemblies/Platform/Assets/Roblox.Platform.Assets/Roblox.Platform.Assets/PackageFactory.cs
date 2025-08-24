namespace Roblox.Platform.Assets;

public class PackageFactory : AssetFactoryBase<IPackage>
{
	protected override int AssetTypeId => Roblox.AssetType.PackageID;

	internal PackageFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IPackage BuildChildAsset(IAsset genericAsset)
	{
		return new Package(base.DomainFactories, genericAsset);
	}

	internal IPackage GetPackage(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
