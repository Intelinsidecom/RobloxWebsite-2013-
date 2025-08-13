using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Floodcheckers.Properties;
using Roblox.Platform.IpAddresses;

namespace Roblox.Platform.Floodcheckers;

public class FloodCheckerFactory
{
	private ISuspiciousIpChecker _SuspiciousIpChecker;

	private bool _AccountCreationWithIpDiscretionFloodCheckerEnabled => Settings.Default.AccountCreationWithIpDiscretionFloodCheckerEnabled;

	public FloodCheckerFactory(ISuspiciousIpChecker suspiciousIpChecker)
	{
		if (suspiciousIpChecker == null)
		{
			throw new PlatformArgumentNullException("suspiciousIpChecker");
		}
		_SuspiciousIpChecker = suspiciousIpChecker;
	}

	public IFloodChecker GetAccountCreationFloodChecker(string ipAddress)
	{
		if (_AccountCreationWithIpDiscretionFloodCheckerEnabled)
		{
			return new AccountCreationWithIpDiscretionFloodChecker(new AccountCreationFloodChecker(ipAddress), new AccountCreationFloodCheckerForSuspiciousIps(ipAddress), _SuspiciousIpChecker, ipAddress);
		}
		return new AccountCreationFloodChecker(ipAddress);
	}
}
