using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

public class CreatorAssetTypeUploadFloodChecker : FloodChecker, IRetryAfterFloodChecker, IFloodChecker, IBasicFloodChecker
{
	public CreatorAssetTypeUploadFloodChecker(CreatorType creatorType, long creatorTargetId, AssetType assetType)
		: base($"CreatorAssetTypeUploadFloodChecker_CreatorType:{creatorType}_CreatorTargetId:{creatorTargetId}_AssetType:{assetType}", Settings.Default.CreatorAssetTypeUploadFloodCheckerLimit, Settings.Default.CreatorAssetTypeUploadFloodCheckerExpiry)
	{
	}

	/// <inheritdoc cref="T:Roblox.FloodCheckers.Core.IRetryAfterFloodChecker" />
	public int? RetryAfter()
	{
		return RetryAfterInternal();
	}
}
