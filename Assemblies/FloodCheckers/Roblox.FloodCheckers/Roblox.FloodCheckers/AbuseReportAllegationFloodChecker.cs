using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AbuseReportAllegationFloodChecker : FloodChecker
{
	public AbuseReportAllegationFloodChecker(string cacheKey)
		: base($"AbuseReportAllegationFloodChecker:{cacheKey}", Settings.Default.AbuseReportAllegationFloodCheckLimit, Settings.Default.AbuseReportAllegationFloodCheckTimeSpan)
	{
	}
}
