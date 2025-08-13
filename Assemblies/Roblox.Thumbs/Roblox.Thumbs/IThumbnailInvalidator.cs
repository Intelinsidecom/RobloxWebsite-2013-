namespace Roblox.Thumbs;

public interface IThumbnailInvalidator
{
	ThumbnailDomainFactories DomainFactories { get; }

	void InvalidateThumbnailsByAssetHashIds(params long[] assetHashIds);
}
