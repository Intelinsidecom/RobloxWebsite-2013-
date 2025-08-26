using Roblox.Platform.Core;
namespace Roblox.Platform.Thumbspublic {
    class ThumbnailInvalidator : DomainObjectBase<ThumbnailDomainFactories>, IThumbnailInvalidator

{
	public ThumbnailInvalidator(ThumbnailDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	public void InvalidateThumbnailsByAssetHashIds(params long[] assetHashIds)
	{
		base.DomainFactories.ThumbnailsClient.InvalidateThumbnails(assetHashIds);
	}
}


}
