using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AdjustUserCurrencyFloodChecker : FloodChecker
{
	public AdjustUserCurrencyFloodChecker(string ipAddress)
		: base($"AdjustUserCurrencyFloodChecker_IPAdress:{ipAddress}", Settings.Default.AdjustUserCurrencyFloodCheckerLimit, Settings.Default.AdjustUserCurrencyFloodCheckerExpiryTime)
	{
	}
}
