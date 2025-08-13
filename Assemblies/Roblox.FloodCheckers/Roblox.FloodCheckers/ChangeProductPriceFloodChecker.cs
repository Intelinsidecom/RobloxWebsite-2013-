using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ChangeProductPriceFloodChecker : FloodChecker
{
	public ChangeProductPriceFloodChecker(long userId, long assetId)
		: base($"ChangeProductPriceFloodChecker_UserID:{userId}_AssetID:{assetId}", Settings.Default.ChangeProductPriceFloodCheckLimit, Settings.Default.ChangeProductPriceFloodCheckExpiry)
	{
	}
}
