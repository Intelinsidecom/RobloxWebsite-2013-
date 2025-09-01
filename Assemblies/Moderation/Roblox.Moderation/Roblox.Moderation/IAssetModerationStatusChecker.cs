using Roblox.Platform.AssetsCore;
namespace Roblox.Moderation {
    /// <summary>

/// Gets moderation status of an asset.
/// </summary>
public interface IAssetModerationStatusChecker
{
	/// <summary>
	/// Gets moderation status of an asset.
	/// </summary>
	AssetModerationStatus GetModerationStatus(IAssetIdentifier asset);
}


}
