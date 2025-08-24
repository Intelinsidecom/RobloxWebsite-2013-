namespace Roblox.Thumbs;

public interface IThumbnailDependenciesInvalidator
{
	ThumbnailDomainFactories DomainFactories { get; }

	void AddAssetIdToTemporaryThumbnailInvalidationSkipList(long assetId);

	void Register();
}
