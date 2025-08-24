using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers.Redis;

/// <summary>
/// Implementation of <see cref="T:Roblox.FloodCheckers.Core.IFloodCheckerFactory`1" /> which will construct IFloodCheckers as <see cref="T:Roblox.FloodCheckers.Redis.RedisApproximateRollingWindowFloodChecker" />s
/// </summary>
public class RedisApproximateRollingWindowFloodCheckerFactory : IFloodCheckerFactory<RedisApproximateRollingWindowFloodChecker>
{
	private readonly IGlobalFloodCheckerEventLogger _GlobalFloodCheckerEventLogger;

	public RedisApproximateRollingWindowFloodCheckerFactory()
	{
		_GlobalFloodCheckerEventLogger = new GlobalFloodCheckerEventLogger();
	}

	public RedisApproximateRollingWindowFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger)
	{
		return new RedisApproximateRollingWindowFloodChecker(category, key, getLimit, getWindowPeriod, isEnabled, logger, recordGlobalFloodedEvents, _GlobalFloodCheckerEventLogger);
	}
}
