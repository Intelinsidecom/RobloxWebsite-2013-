using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.FloodCheckers.Redis;

/// <summary>
/// A Redis-backed continuous rolling-window FloodChecker. To determine if it is flooded it will look at the number
/// of counts recorded in the specified window period, measuring from the current time when the check is performed.
/// Resolution of count times is the storage time as ticks rounded at the precision of a double float (approx.  1/10,000th of a second)
/// </summary>
public class RedisRollingWindowFloodChecker : BaseRedisFloodChecker, IFloodChecker, IBasicFloodChecker, IRetryAfterFloodChecker
{
	private readonly Func<DateTime> _NowProvider;

	private const long _BucketSizeWindowFactor = 5L;

	private string _LastBucketUpdated;

	/// <summary>
	/// Constructs a new Redis-backed Floodchecker
	/// </summary>
	/// <param name="category">A category for the floodchecker. This will be used for plotting floodchecker metrics and should be broad</param>
	/// <param name="key">The key for the individual action you wish to flood check, which may be much more specific than the category</param>
	/// <param name="getLimit">The threshold before a checker becomes flooded</param>
	/// <param name="getWindowPeriod">The window of time to consider counts towards the limit</param>
	/// <param name="isEnabled">Whether or not the floodchecker is enabled. If false it will never report itself as flooded</param>
	/// <param name="logger"></param>
	public RedisRollingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, ILogger logger)
		: this(category, key, getLimit, getWindowPeriod, isEnabled, logger, () => false, null)
	{
	}

	internal RedisRollingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, ILogger logger, Func<bool> recordGlobalFloodedEvents, IGlobalFloodCheckerEventLogger globalFloodCheckerEventLogger)
		: this(category, key, getLimit, getWindowPeriod, isEnabled, logger, recordGlobalFloodedEvents, globalFloodCheckerEventLogger, FloodCheckerRedisClient.GetInstance(), () => DateTime.UtcNow)
	{
	}

	internal RedisRollingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, ILogger logger, Func<bool> recordGlobalFloodedEvents, IGlobalFloodCheckerEventLogger globalFloodCheckerEventLogger, IRedisClient redisClient, Func<DateTime> nowProvider, ISettings settings = null)
		: base(category, key, getLimit, getWindowPeriod, isEnabled, logger, redisClient, recordGlobalFloodedEvents, globalFloodCheckerEventLogger, settings)
	{
		_NowProvider = nowProvider;
	}

	protected override void DoUpdateCount()
	{
		DateTime timeNow = _NowProvider();
		TimeSpan window = GetWindowPeriod();
		string bucketKey = GetBucketKey(timeNow, window);
		RedisClient.Execute(bucketKey, (IDatabase db) => db.SortedSetAdd(bucketKey, Guid.NewGuid().ToString(), timeNow.Ticks, CommandFlags.FireAndForget));
		if (bucketKey != _LastBucketUpdated)
		{
			RedisClient.Execute(bucketKey, (IDatabase db) => db.KeyExpire(bucketKey, GetBucketExpiryTimeSpan(window), CommandFlags.FireAndForget));
			_LastBucketUpdated = bucketKey;
		}
	}

	protected override void DoReset()
	{
		foreach (string key in GetCurrentBucketKeys(_NowProvider(), GetWindowPeriod()))
		{
			RedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
		}
	}

	protected override int DoGetCount()
	{
		int count = 0;
		TimeSpan window = GetWindowPeriod();
		DateTime timeNow = _NowProvider();
		DateTime intervalStartTime = timeNow - window;
		foreach (string key in GetCurrentBucketKeys(timeNow, window))
		{
			count += (int)RedisClient.Execute(key, (IDatabase db) => db.SortedSetLength(key, intervalStartTime.Ticks));
		}
		return count;
	}

	protected override TimeSpan? DoGetRetryAfter()
	{
		TimeSpan window = GetWindowPeriod();
		DateTime timeNow = _NowProvider();
		DateTime intervalStartTime = timeNow - window;
		int limit = GetLimit();
		foreach (string key in GetCurrentBucketKeys(timeNow, window))
		{
			int count = (int)RedisClient.Execute(key, (IDatabase db) => db.SortedSetLength(key, intervalStartTime.Ticks));
			if (count >= limit)
			{
				SortedSetEntry[] samples = RedisClient.Execute(key, (IDatabase db) => db.SortedSetRangeByRankWithScores(key, -limit, -limit));
				if (samples.Length == 0)
				{
					break;
				}
				long retryAfter = (long)samples[0].Score + window.Ticks - timeNow.Ticks;
				return (retryAfter < 0) ? TimeSpan.Zero : TimeSpan.FromTicks((retryAfter + 500) / 1000 * 1000);
			}
			limit -= count;
		}
		return TimeSpan.Zero;
	}

	private IEnumerable<string> GetCurrentBucketKeys(DateTime timeNow, TimeSpan window)
	{
		string endOfWindowBucketKey = GetBucketKey(timeNow, window);
		yield return endOfWindowBucketKey;
		string startOfWindowBucketKey = GetBucketKey(timeNow.Subtract(window), window);
		if (endOfWindowBucketKey != startOfWindowBucketKey)
		{
			yield return startOfWindowBucketKey;
		}
	}

	private string GetBucketKey(DateTime time, TimeSpan window)
	{
		long startOfBucket = time.Ticks - time.Ticks % GetBucketTicks(window);
		return $"FloodChecker_{Key}_{startOfBucket}";
	}

	private static long GetBucketTicks(TimeSpan window)
	{
		return window.Ticks * 5;
	}

	private TimeSpan GetBucketExpiryTimeSpan(TimeSpan window)
	{
		return new TimeSpan(window.Ticks * 6);
	}
}
