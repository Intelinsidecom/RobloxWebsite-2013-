using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class MobileDFPAdsFloodChecker : FloodChecker
{
	public MobileDFPAdsFloodChecker(long userId)
		: base($"MobileDFPAdsFloodChecker_UserId:{userId}", Settings.Default.MobileDFPAdsFloodCheckLimit, Settings.Default.MobileDFPAdsFloodCheckExpiry)
	{
	}
}
