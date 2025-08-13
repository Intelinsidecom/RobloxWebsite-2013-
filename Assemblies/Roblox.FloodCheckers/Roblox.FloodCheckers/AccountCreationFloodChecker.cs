using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AccountCreationFloodChecker : FloodChecker
{
	public AccountCreationFloodChecker(string ipAddress)
		: base($"AccountCreationFloodChecker_IPAddress:{ipAddress}", Settings.Default.AccountCreationFloodCheckLimit, TimeSpan.FromHours(Settings.Default.AccountCreationFloodCheckTimeLimitInHours))
	{
	}
}
