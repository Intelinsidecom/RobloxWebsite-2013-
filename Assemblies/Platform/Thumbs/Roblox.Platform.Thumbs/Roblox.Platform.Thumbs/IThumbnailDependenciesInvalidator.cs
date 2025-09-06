namespace Roblox.Platform.Thumbs
{
    public interface IThumbnailDependenciesInvalidator
    {
        void AddAssetIdToTemporaryThumbnailInvalidationSkipList(long assetId);
        void Register();
    }
}
