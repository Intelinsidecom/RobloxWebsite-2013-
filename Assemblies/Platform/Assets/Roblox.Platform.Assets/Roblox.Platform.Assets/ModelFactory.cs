namespace Roblox.Platform.Assets;

public class ModelFactory : AssetFactoryBase<IModel>
{
	protected override int AssetTypeId => Roblox.AssetType.ModelID;

	internal ModelFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IModel BuildChildAsset(IAsset genericAsset)
	{
		return new Model(base.DomainFactories, genericAsset);
	}

	internal IModel GetModel(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
