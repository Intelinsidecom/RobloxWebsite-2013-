using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class FreeItemValidatePurchaseFloodChecker : FloodChecker
{
	public FreeItemValidatePurchaseFloodChecker(long userId, long assetId)
		: base($"FreeItemValidatePurchaseFloodChecker_UserID:{userId}_AssetID:{assetId}", Settings.Default.FreeItemValidatePurchaseLimit, Settings.Default.FreeItemValidatePurchaseFloodCheckExpiry)
	{
	}
}
