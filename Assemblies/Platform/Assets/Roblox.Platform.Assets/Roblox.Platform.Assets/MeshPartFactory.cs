namespace Roblox.Platform.Assets;

public class MeshPartFactory : AssetFactoryBase<IMeshPart>
{
	protected override int AssetTypeId => Roblox.AssetType.MeshPartID;

	internal MeshPartFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IMeshPart BuildChildAsset(IAsset genericAsset)
	{
		return new MeshPart(base.DomainFactories, genericAsset);
	}

	internal IMeshPart GetMeshPart(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
