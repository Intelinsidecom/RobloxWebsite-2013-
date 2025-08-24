using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.IpAddresses;
using Roblox.FloodCheckers.Properties;
using Roblox.Platform.Core;

namespace Roblox.FloodCheckers;

public class FloodCheckerFactory : IFloodCheckerFactory<IFloodChecker>
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

    public IFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger)
    {
        return new FloodChecker(category, key, getLimit(), getWindowPeriod(), isEnabled());
    }

    public IFloodChecker GetAccountCreationFloodChecker(string ipAddress)
    {
        if (_AccountCreationWithIpDiscretionFloodCheckerEnabled)
        {
            return new Roblox.Platform.Floodcheckers.AccountCreationWithIpDiscretionFloodChecker(
                new AccountCreationFloodChecker(ipAddress),
                new AccountCreationFloodCheckerForSuspiciousIps(ipAddress),
                _SuspiciousIpChecker,
                ipAddress);
        }
        return new AccountCreationFloodChecker(ipAddress);
    }
}
