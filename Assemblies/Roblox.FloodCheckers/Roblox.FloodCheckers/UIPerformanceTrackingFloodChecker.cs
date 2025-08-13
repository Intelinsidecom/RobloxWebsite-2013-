using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class UIPerformanceTrackingFloodChecker : FloodChecker
{
	public UIPerformanceTrackingFloodChecker(string ipAddress)
		: base($"UIPerformanceTrackingByIPFloodChecker_IpAddress:{ipAddress}", Settings.Default.UIPerformanceTrackingByIPFloodCheckLimit, Settings.Default.UIPerformanceTrackingByIPFloodCheckExpiry)
	{
	}
}
