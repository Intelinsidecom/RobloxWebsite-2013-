using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class InCommFailedPartialIpFloodChecker : FloodChecker
{
	public InCommFailedPartialIpFloodChecker(string partialIP)
		: base("GamecardRedemption", $"GamecardRedemptionFloodChecker_PartialIP:{partialIP}", Settings.Default.InCommFailedPartialIPFloodCheckLimit, Settings.Default.InCommFailedPartialIPFloodCheckExpiry, Settings.Default.InCommFailedPartialIPFloodCheckEnabled)
	{
	}
}
