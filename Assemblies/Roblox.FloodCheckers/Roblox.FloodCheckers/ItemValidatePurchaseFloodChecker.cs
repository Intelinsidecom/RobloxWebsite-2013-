using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ItemValidatePurchaseFloodChecker : FloodChecker
{
	public ItemValidatePurchaseFloodChecker(long userId, string productType, long productTargetId)
		: base($"ItemValidatePurchaseFloodChecker_UserID:{userId}_ProductType:{productType}_ProductTargetId:{productTargetId}", Settings.Default.ItemValidatePurchaseLimit, Settings.Default.ItemValidatePurchaseFloodCheckExpiry)
	{
	}
}
