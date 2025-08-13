using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AbEnrollApiFloodChecker : FloodChecker
{
	public AbEnrollApiFloodChecker(string ipAddress)
		: base($"AbEnrollApiFloodChecker_IpAddress:{ipAddress}", Settings.Default.AbEnrollApiFloodCheckLimit, Settings.Default.AbEnrollApiFloodCheckExpiry)
	{
	}
}
