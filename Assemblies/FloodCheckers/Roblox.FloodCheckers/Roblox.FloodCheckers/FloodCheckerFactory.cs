using System;
using System.Configuration;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Properties;
using Roblox.Platform.Core;

namespace Roblox.FloodCheckers;

public class FloodCheckerFactory : IFloodCheckerFactory<IFloodChecker>
{
    private ISuspiciousIpChecker _SuspiciousIpChecker;

    private bool _AccountCreationWithIpDiscretionFloodCheckerEnabled 
    {
        get 
        {
            try
            {
                return (bool)Settings.Default["AccountCreationWithIpDiscretionFloodCheckerEnabled"];
            }
            catch (SettingsPropertyNotFoundException)
            {
                return false; // Default value when setting is missing
            }
        }
    }

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
            return new AccountCreationWithIpDiscretionFloodChecker(
                new AccountCreationFloodChecker(ipAddress),
                new AccountCreationFloodCheckerForSuspiciousIps(ipAddress),
                _SuspiciousIpChecker,
                ipAddress);
        }
        return new AccountCreationFloodChecker(ipAddress);
    }
}
