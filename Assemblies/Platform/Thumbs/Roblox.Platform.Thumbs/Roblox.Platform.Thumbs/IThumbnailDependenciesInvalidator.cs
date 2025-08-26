namespace Roblox.Platform.Thumbspublic {
    interface IThumbnailDependenciesInvalidator

{
	ThumbnailDomainFactories DomainFactories { get; }

	void AddAssetIdToTemporaryThumbnailInvalidationSkipList(long assetId);

	void Register();
}


}
