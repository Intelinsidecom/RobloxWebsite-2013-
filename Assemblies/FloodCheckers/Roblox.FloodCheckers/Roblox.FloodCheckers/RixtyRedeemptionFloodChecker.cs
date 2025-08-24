using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class RixtyRedeemptionFloodChecker : FloodChecker
{
	public RixtyRedeemptionFloodChecker(long userId)
		: base($"RixtyGamecardRedemptionFloodChecker_UserID:{userId}", Settings.Default.RixtyFailedFloodCheckLimit, Settings.Default.RixtyFailedFloodCheckExpiry, Settings.Default.IsRixtyFloodCheckEnabled)
	{
	}
}
