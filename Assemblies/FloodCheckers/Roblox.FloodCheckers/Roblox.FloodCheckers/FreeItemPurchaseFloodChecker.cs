using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class FreeItemPurchaseFloodChecker : FloodChecker
{
	public FreeItemPurchaseFloodChecker(long userId, long assetId)
		: base($"FreeItemPurchaseFloodChecker_UserID:{userId}_AssetID:{assetId}", Settings.Default.FreeItemPurchaseLimit, Settings.Default.FreeItemPurchaseFloodCheckExpiry)
	{
	}
}
