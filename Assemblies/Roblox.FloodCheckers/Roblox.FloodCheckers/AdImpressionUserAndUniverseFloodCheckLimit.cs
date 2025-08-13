using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AdImpressionUserAndUniverseFloodCheckLimit : FloodChecker
{
	public AdImpressionUserAndUniverseFloodCheckLimit(long userId, long universeId)
		: base($"AdImpressionByUserAndUniverseFloodCheckLimit_UserID:{userId}_UniverseID:{universeId}", Settings.Default.AdImpressionUserAndUniverseFloodCheckLimit, Settings.Default.AdImpressionFloodCheckExpiry)
	{
	}
}
