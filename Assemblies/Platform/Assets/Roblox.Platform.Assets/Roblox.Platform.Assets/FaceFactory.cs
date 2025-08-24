namespace Roblox.Platform.Assets;

public class FaceFactory : AssetFactoryBase<IFace>
{
	protected override int AssetTypeId => Roblox.AssetType.FaceID;

	internal FaceFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IFace BuildChildAsset(IAsset genericAsset)
	{
		return new Face(base.DomainFactories, genericAsset);
	}

	internal IFace GetFace(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
