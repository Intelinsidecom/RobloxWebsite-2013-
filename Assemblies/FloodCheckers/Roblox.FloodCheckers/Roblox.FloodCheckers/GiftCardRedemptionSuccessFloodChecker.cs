using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GiftCardRedemptionSuccessFloodChecker : FloodChecker
{
	public GiftCardRedemptionSuccessFloodChecker(long userId)
		: base($"GiftCardRedemptionSuccessFloodChecker_UserId:{userId}", Settings.Default.GiftCardRedemptionSuccessFloodCheckLimit, Settings.Default.GiftCardRedemptionSuccessFloodCheckExpiry)
	{
	}
}
