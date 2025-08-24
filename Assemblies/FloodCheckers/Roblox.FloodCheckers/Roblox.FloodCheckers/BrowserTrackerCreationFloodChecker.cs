using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class BrowserTrackerCreationFloodChecker : FloodChecker
{
	public BrowserTrackerCreationFloodChecker(string ipAddress)
		: base($"BrowserTrackerCreationFloodChecker_IPAddress:{ipAddress}", Settings.Default.BrowserTrackerCreationFloodCheckLimit, Settings.Default.BrowserTrackerCreationFloodCheckExpiry)
	{
	}
}
