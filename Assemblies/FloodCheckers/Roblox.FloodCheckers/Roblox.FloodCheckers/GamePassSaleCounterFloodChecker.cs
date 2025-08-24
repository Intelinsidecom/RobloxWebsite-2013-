using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GamePassSaleCounterFloodChecker : FloodChecker
{
	public GamePassSaleCounterFloodChecker(long userId, long gamePassId)
		: base($"ItemSaleCounterFloodChecker_UserID:{userId}_GamePassId:{gamePassId}", Settings.Default.AssetSaleCounterFloodCheckerLimit, Settings.Default.AssetSaleCounterFloodCheckerExpiry)
	{
	}
}
