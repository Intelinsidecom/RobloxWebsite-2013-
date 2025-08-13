using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

/// <summary>
/// Represents a <see cref="T:Roblox.FloodCheckers.FloodChecker" /> that flood checks commenting on a per-user per-asset basis.
/// </summary>
public class UserCommentPerAssetFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.FloodCheckers.UserCommentPerAssetFloodChecker" /> class
	/// for user with the given user ID commenting on an asset with the given asset ID.
	/// </summary>
	/// <param name="userId">The ID of the user doing the commenting.</param>
	/// <param name="assetId">The ID of the asset being commented on.</param>
	public UserCommentPerAssetFloodChecker(long userId, long assetId)
		: base($"CommentFloodCheck_UserID:{userId}_AssetID:{assetId}", Settings.Default.UserCommentPerAssetFloodCheckerLimit, Settings.Default.UserCommentPerAssetFloodCheckerExpiry, Settings.Default.UserCommentPerAssetFloodCheckerEnabled)
	{
	}
}
