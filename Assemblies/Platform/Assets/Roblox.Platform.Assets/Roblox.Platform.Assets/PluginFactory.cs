namespace Roblox.Platform.Assets;

public class PluginFactory : AssetFactoryBase<IPlugin>
{
	protected override int AssetTypeId => Roblox.AssetType.PluginID;

	internal PluginFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IPlugin BuildChildAsset(IAsset genericAsset)
	{
		return new Plugin(base.DomainFactories, genericAsset);
	}

	internal IPlugin GetPlugin(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
