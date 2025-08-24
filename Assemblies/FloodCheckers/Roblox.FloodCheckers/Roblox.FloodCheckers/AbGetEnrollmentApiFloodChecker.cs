using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AbGetEnrollmentApiFloodChecker : FloodChecker
{
	public AbGetEnrollmentApiFloodChecker(string ipAddress)
		: base($"AbGetEnrollmentApiFloodChecker_IpAddress:{ipAddress}", Settings.Default.AbGetEnrollmentApiFloodCheckLimit, Settings.Default.AbGetEnrollmentApiFloodCheckExpiry)
	{
	}
}
