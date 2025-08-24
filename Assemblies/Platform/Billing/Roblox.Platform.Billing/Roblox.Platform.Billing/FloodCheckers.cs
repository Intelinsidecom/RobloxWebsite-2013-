using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Properties;

namespace Roblox.Platform.Billing;

public class FloodCheckers
{
	private const string _FloodCheckerCategoryPrefix = "Roblox.Platform.Billing";

	public static IFloodChecker GetPurchaseAttemptByIPFloodChecker(string ipAddress)
	{
		return new FloodChecker("Roblox.Platform.Billing.PurchaseAttemptByIP", $"PurchaseAttemptByIPFloodChecker_IpAddress:{ipAddress}", expiry: Settings.Default.PurchaseAttemptByIPFloodCheckExpiry, limit: Settings.Default.PurchaseAttemptByIPFloodCheckLimit, enabled: true);
	}

	public static IFloodChecker GetPurchaseAttemptByUserFloodChecker(long userId)
	{
		return new FloodChecker("Roblox.Platform.Billing.PurchaseAttemptByUser", $"PurchaseAttemptByUserFloodChecker_UserId:{userId}", expiry: Settings.Default.PurchaseAttemptByUserFloodCheckExpiry, limit: Settings.Default.PurchaseAttemptByUserFloodCheckLimit, enabled: true);
	}

	public static IFloodChecker GetDeclinedCardByUserFloodChecker(long userId)
	{
		return new FloodChecker("Roblox.Platform.Billing.DeclinedCardByUser", $"DeclinedCardByUserFloodChecker_UserId:{userId}", expiry: Settings.Default.DeclinedCardByUserFloodCheckExpiry, limit: Settings.Default.DeclinedCardByUserFloodCheckLimit, enabled: true);
	}

	public static IFloodChecker GetDeclinedCardByIPFloodChecker(string ipAddress)
	{
		return new FloodChecker("Roblox.Platform.Billing.DeclinedCardByIP", $"DeclinedCardByIPFloodChecker_IpAddress:{ipAddress}", expiry: Settings.Default.DeclinedCardByIPFloodCheckExpiry, limit: Settings.Default.DeclinedCardByIPFloodCheckLimit, enabled: true);
	}
}
