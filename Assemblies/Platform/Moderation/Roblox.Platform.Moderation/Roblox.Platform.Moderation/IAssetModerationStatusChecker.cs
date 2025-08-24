using Roblox.Platform.Assets;

namespace Roblox.Platform.Moderation;

/// <summary>
/// Gets moderation status of an asset.
/// </summary>
public interface IAssetModerationStatusChecker
{
	/// <summary>
	/// Gets moderation status of an asset.
	/// </summary>
	AssetModerationStatus GetModerationStatus(IAsset asset);
}
