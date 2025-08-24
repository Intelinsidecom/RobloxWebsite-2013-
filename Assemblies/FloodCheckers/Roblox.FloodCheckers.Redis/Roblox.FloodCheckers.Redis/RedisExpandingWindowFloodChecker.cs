using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.FloodCheckers.Redis;

/// <summary>
/// A Redis-backed expanding window FloodChecker. Whenever a count is recorded against the floodchecker, the expiry of the current count will be
/// extended by the window period. The count will only increase until a full window period elapses without any counts recorded, at which point
/// it will reset to zero. Useful in situations where you want a particular activity to completely cease before allowing it to continue.
/// Resolution of the expiry time is approx. 1 millisecond.
/// </summary>
public class RedisExpandingWindowFloodChecker : BaseRedisFloodChecker, IExpiringFloodChecker, IFloodChecker, IBasicFloodChecker
{
	/// <summary>
	/// Constructs a new Redis-backed Expanding Window FloodChecker
	/// </summary>
	/// <param name="category">A category for the floodchecker. This will be used for plotting floodchecker metrics and should be broad</param>
	/// <param name="key">The key for the individual action you wish to flood check, which may be much more specific than the category</param>
	/// <param name="getLimit">The threshold before a checker becomes flooded</param>
	/// <param name="getWindowPeriod">The lifespan of the floodchecker before the count is reset</param>
	/// <param name="isEnabled">Whether or not the floodchecker is enabled. If false it will never report itself as flooded</param>
	/// <param name="recordGlobalFloodedEvents">Whether or not the floodchecker should record global events when the floodchecker is flooded</param>
	/// <param name="logger"></param>
	/// <param name="redisClient"></param>
	/// <param name="globalFloodCheckerEventLogger"></param>
	/// <param name="settings"></param>
	internal RedisExpandingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger, IRedisClient redisClient, IGlobalFloodCheckerEventLogger globalFloodCheckerEventLogger, ISettings settings = null)
		: base(category, key, getLimit, getWindowPeriod, isEnabled, logger, redisClient, recordGlobalFloodedEvents, globalFloodCheckerEventLogger, settings)
	{
	}

	protected override void DoUpdateCount()
	{
		string key = GetKey();
		RedisClient.Execute(key, (IDatabase db) => db.StringIncrement(key, 1L));
		RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, GetWindowPeriod()));
	}

	protected override void DoReset()
	{
		string key = GetKey();
		RedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
	}

	protected override int DoGetCount()
	{
		string key = GetKey();
		return (int)RedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
	}

	private string GetKey()
	{
		return $"REWFC_{Key}";
	}

	public TimeSpan? TimeToExpiry()
	{
		if (!IsEnabled())
		{
			return null;
		}
		try
		{
			string key = GetKey();
			return RedisClient.Execute(key, (IDatabase db) => db.KeyTimeToLive(key));
		}
		catch (Exception exception)
		{
			Logger.Error(exception);
			return null;
		}
	}
}
