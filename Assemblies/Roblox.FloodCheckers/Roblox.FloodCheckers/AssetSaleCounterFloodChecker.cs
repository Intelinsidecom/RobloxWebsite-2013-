using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AssetSaleCounterFloodChecker : FloodChecker
{
	public AssetSaleCounterFloodChecker(long userId, long assetId)
		: base($"ItemSaleCounterFloodChecker_UserID:{userId}_AssetID:{assetId}", Settings.Default.AssetSaleCounterFloodCheckerLimit, Settings.Default.AssetSaleCounterFloodCheckerExpiry)
	{
	}
}
