using Roblox.Platform.AssetsCore;
namespace Roblox.Moderation {
    /// <inheritdoc cref="T:Roblox.Platform.Moderation.IAssetModerationStatusChecker" />

public class AssetModerationStatusChecker : IAssetModerationStatusChecker, IModerationStatusChecker<IAssetIdentifier>
{
	/// <inheritdoc cref="T:Roblox.Platform.Moderation.IAssetModerationStatusChecker" />
	public AssetModerationStatus GetModerationStatus(IAssetIdentifier asset)
	{
		return asset.GetModerationStatus();
	}
}


}
