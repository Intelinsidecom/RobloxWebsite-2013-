using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class PurchaseAttemptByIPFloodChecker : FloodChecker
{
	public PurchaseAttemptByIPFloodChecker(string ipAddress)
		: base($"PurchaseAttemptByIPFloodChecker_IpAddress:{ipAddress}", Settings.Default.PurchaseAttemptByIPFloodCheckLimit, Settings.Default.PurchaseAttemptByIPFloodCheckExpiry)
	{
	}
}
