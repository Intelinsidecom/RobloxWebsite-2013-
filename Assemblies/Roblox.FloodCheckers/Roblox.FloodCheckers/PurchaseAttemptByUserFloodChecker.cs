using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class PurchaseAttemptByUserFloodChecker : FloodChecker
{
	public PurchaseAttemptByUserFloodChecker(long userId)
		: base($"PurchaseAttemptByUserFloodChecker_UserId:{userId}", Settings.Default.PurchaseAttemptByUserFloodCheckLimit, Settings.Default.PurchaseAttemptByUserFloodCheckExpiry)
	{
	}
}
