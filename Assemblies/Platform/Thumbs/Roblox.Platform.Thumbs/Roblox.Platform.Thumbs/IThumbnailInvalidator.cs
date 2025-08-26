namespace Roblox.Platform.Thumbspublic {
    interface IThumbnailInvalidator

{
	ThumbnailDomainFactories DomainFactories { get; }

	void InvalidateThumbnailsByAssetHashIds(params long[] assetHashIds);
}


}
