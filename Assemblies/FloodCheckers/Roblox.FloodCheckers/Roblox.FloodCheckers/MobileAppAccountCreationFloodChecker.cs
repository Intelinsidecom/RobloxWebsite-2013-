using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class MobileAppAccountCreationFloodChecker : FloodChecker
{
	public MobileAppAccountCreationFloodChecker(string ipAddress)
		: base($"MobileAppAccountCreationFloodChecker_IPAddress:{ipAddress}", Settings.Default.MobileAppAccountCreationFloodCheckLimit, TimeSpan.FromHours(Settings.Default.MobileAppAccountCreationFloodCheckTimeLimitInHours))
	{
	}
}
