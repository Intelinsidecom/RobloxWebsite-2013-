using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class InCommFailedIpFloodChecker : FloodChecker
{
	public InCommFailedIpFloodChecker(string ipAddress)
		: base("GamecardRedemption", $"GamecardRedemptionFloodChecker_IP:{ipAddress}", Settings.Default.InCommFailedIPFloodCheckLimit, Settings.Default.InCommFailedIPFloodCheckExpiry, Settings.Default.InCommFailedIPFloodCheckEnabled)
	{
	}
}
