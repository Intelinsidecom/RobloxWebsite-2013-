namespace Roblox.Platform.Assets;

public class HtmlFactory : AssetFactoryBase<IHtml>
{
	protected override int AssetTypeId => Roblox.AssetType.HtmlID;

	internal HtmlFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	protected override IHtml BuildChildAsset(IAsset genericAsset)
	{
		return new Html(base.DomainFactories, genericAsset);
	}

	internal IHtml GetHtml(IAsset genericAsset)
	{
		return BuildChildAsset(genericAsset);
	}
}
