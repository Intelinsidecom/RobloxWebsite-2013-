namespace Roblox.Platform.Assets;

public class FaceAccessoryFactory : AssetFactoryBase<IFaceAccessory>
{
	protected override int AssetTypeId => Roblox.AssetType.FaceAccessoryID;

	internal FaceAccessoryFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IFaceAccessory BuildChildAsset(IAsset genericAsset)
	{
		return new FaceAccessory(base.DomainFactories, genericAsset);
	}

	internal IFaceAccessory GetFaceAccessory(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
