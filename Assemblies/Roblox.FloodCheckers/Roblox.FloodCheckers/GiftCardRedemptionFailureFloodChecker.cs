using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GiftCardRedemptionFailureFloodChecker : FloodChecker
{
	public GiftCardRedemptionFailureFloodChecker(long userId)
		: base($"GiftCardRedemptionFailureFloodChecker_UserId:{userId}", Settings.Default.GiftCardRedemptionFailureFloodCheckLimit, Settings.Default.GiftCardRedemptionFailureFloodCheckExpiry)
	{
	}
}
