using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AdImpressionUserFloodCheckLimit : FloodChecker
{
	public AdImpressionUserFloodCheckLimit(long userId)
		: base($"AdImpressionByUserFloodChecker_UserID:{userId}", Settings.Default.AdImpressionUserFloodCheck, Settings.Default.AdImpressionFloodCheckExpiry)
	{
	}
}
