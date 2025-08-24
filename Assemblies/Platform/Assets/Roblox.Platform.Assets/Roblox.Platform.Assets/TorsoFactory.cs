namespace Roblox.Platform.Assets;

public class TorsoFactory : AssetFactoryBase<ITorso>
{
	protected override int AssetTypeId => Roblox.AssetType.TorsoID;

	internal TorsoFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override ITorso BuildChildAsset(IAsset genericAsset)
	{
		return new Torso(base.DomainFactories, genericAsset);
	}

	internal ITorso GetTorso(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
