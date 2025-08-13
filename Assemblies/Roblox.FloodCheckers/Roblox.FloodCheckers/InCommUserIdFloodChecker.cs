using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class InCommUserIdFloodChecker : FloodChecker
{
	public InCommUserIdFloodChecker(long userId)
		: base("GamecardRedemption", $"GamecardRedemptionFloodChecker_UserID:{userId}", Settings.Default.InCommFailedUserIdFloodCheckLimit, Settings.Default.InCommFailedUserIdFloodCheckExpiry, Settings.Default.InCommFailedUserIdFloodCheckEnabled)
	{
	}
}
