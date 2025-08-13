using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers.Redis;

/// <summary>
/// Implementation of <see cref="T:Roblox.FloodCheckers.Core.IFloodCheckerFactory`1" /> which will construct IFloodCheckers as <see cref="T:Roblox.FloodCheckers.Redis.RedisRollingWindowFloodChecker" />s
/// </summary>
public class RedisExpandingWindowFloodCheckerFactory : IFloodCheckerFactory<RedisExpandingWindowFloodChecker>
{
	private readonly IGlobalFloodCheckerEventLogger _GlobalFloodCheckerEventLogger;

	public RedisExpandingWindowFloodCheckerFactory()
	{
		_GlobalFloodCheckerEventLogger = new GlobalFloodCheckerEventLogger();
	}

	public RedisExpandingWindowFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger)
	{
		return new RedisExpandingWindowFloodChecker(category, key, getLimit, getWindowPeriod, isEnabled, recordGlobalFloodedEvents, logger, FloodCheckerRedisClient.GetInstance(), _GlobalFloodCheckerEventLogger);
	}
}
