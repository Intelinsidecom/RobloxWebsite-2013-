using Roblox.Platform.Assets;

namespace Roblox.Platform.Moderation;

/// <inheritdoc cref="T:Roblox.Platform.Moderation.IAssetModerationStatusChecker" />
public class AssetModerationStatusChecker : IAssetModerationStatusChecker
{
	/// <inheritdoc cref="T:Roblox.Platform.Moderation.IAssetModerationStatusChecker" />
	public AssetModerationStatus GetModerationStatus(IAsset asset)
	{
		return asset.GetModerationStatus();
	}
}
