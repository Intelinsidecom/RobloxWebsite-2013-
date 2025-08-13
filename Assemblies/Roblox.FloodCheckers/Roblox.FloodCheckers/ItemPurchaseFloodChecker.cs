using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ItemPurchaseFloodChecker : FloodChecker
{
	public ItemPurchaseFloodChecker(long userId, string productType, long productTargetId)
		: base($"ItemPurchaseFloodChecker_UserID:{userId}_ProductType:{productType}_ProductTargetId:{productTargetId}", Settings.Default.ItemPurchaseLimit, Settings.Default.ItemPurchaseFloodCheckExpiry)
	{
	}
}
