using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AccountCreationFloodCheckerForSuspiciousIps : FloodChecker
{
	public AccountCreationFloodCheckerForSuspiciousIps(string ipAddress)
		: base($"AccountCreationFloodCheckerForSuspiciousIps_IpAddress:{ipAddress}", Settings.Default.AccountCreationLimitForSuspiciousIps, Settings.Default.AccountCreationExpiryForSuspiciousIps)
	{
	}
}
