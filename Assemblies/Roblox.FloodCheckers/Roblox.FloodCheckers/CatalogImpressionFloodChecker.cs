using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class CatalogImpressionFloodChecker : FloodChecker
{
	public CatalogImpressionFloodChecker(long userId)
		: base($"CatalogImpressionFloodChecker_UserId:{userId}", Settings.Default.CatalogImpressionLimit, Settings.Default.CatalogImpressionFloodCheckExpiry, Settings.Default.CatalogImpressionFloodCheckEnabled)
	{
	}
}
