using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class RedeemPromoCodeFloodChecker : FloodChecker
{
	public RedeemPromoCodeFloodChecker(long userId)
		: base($"RedeemPromoCodeFloodChecker_UserId:{userId}", Settings.Default.RedeemPromoCodeFloodCheckLimit, Settings.Default.RedeemPromoCodeFloodCheckExpiry, Settings.Default.RedeemPromoCodeFloodCheckEnabled)
	{
	}
}
