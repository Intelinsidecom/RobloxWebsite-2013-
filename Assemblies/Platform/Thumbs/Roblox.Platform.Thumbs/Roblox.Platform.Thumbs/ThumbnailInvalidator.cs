using Roblox.Platform.Core;

namespace Roblox.Thumbs;

public class ThumbnailInvalidator : DomainObjectBase<ThumbnailDomainFactories>, IThumbnailInvalidator
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
