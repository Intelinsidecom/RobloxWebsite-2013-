using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class DeclinedCardByIPFloodChecker : FloodChecker
{
	public DeclinedCardByIPFloodChecker(string ipAddress)
		: base($"DeclinedCardByIPFloodChecker_IpAddress:{ipAddress}", Settings.Default.DeclinedCardByIPFloodCheckLimit, Settings.Default.DeclinedCardByIPFloodCheckExpiry)
	{
	}
}
