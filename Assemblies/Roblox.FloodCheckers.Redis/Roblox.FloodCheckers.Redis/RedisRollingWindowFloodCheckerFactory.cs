using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers.Redis;

/// <summary>
/// Implementation of <see cref="T:Roblox.FloodCheckers.Core.IFloodCheckerFactory`1" /> which will construct IFloodCheckers as <see cref="T:Roblox.FloodCheckers.Redis.RedisRollingWindowFloodChecker" />s
/// </summary>
public class RedisRollingWindowFloodCheckerFactory : IFloodCheckerFactory<RedisRollingWindowFloodChecker>
{
	private readonly IGlobalFloodCheckerEventLogger _GlobalFloodCheckerEventLogger;

	public RedisRollingWindowFloodCheckerFactory()
	{
		_GlobalFloodCheckerEventLogger = new GlobalFloodCheckerEventLogger();
	}

	public RedisRollingWindowFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger)
	{
		return new RedisRollingWindowFloodChecker(category, key, getLimit, getWindowPeriod, isEnabled, logger, recordGlobalFloodedEvents, _GlobalFloodCheckerEventLogger);
	}
}
