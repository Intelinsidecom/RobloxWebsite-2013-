using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.FloodCheckers.Redis;

/// <summary>
/// This flood checker is similar to <see cref="T:Roblox.FloodCheckers.Redis.RedisRollingWindowFloodChecker" />. It uses a linear approximation of the
/// rate of events and therefore is not as precise as <see cref="T:Roblox.FloodCheckers.Redis.RedisRollingWindowFloodChecker" />. On the other hand,
/// it uses very little memory (two numbers), which makes it suitable for rate limiting at high rates.
/// Inspired by https://blog.cloudflare.com/counting-things-a-lot-of-different-things/.
/// </summary>
public class RedisApproximateRollingWindowFloodChecker : BaseRedisFloodChecker, IFloodChecker, IBasicFloodChecker, IRetryAfterFloodChecker
{
	private readonly Func<DateTime> _NowProvider;

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
	public RedisApproximateRollingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, ILogger logger)
		: this(category, key, getLimit, getWindowPeriod, isEnabled, logger, () => false, null)
	{
	}

	internal RedisApproximateRollingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, ILogger logger, Func<bool> recordGlobalFloodedEvents, IGlobalFloodCheckerEventLogger globalFloodCheckerEventLogger)
		: this(category, key, getLimit, getWindowPeriod, isEnabled, logger, recordGlobalFloodedEvents, globalFloodCheckerEventLogger, FloodCheckerRedisClient.GetInstance(), () => DateTime.UtcNow)
	{
	}

	internal RedisApproximateRollingWindowFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, ILogger logger, Func<bool> recordGlobalFloodedEvents, IGlobalFloodCheckerEventLogger globalFloodCheckerEventLogger, IRedisClient redisClient, Func<DateTime> nowProvider, ISettings settings = null)
		: base(category, key, getLimit, getWindowPeriod, isEnabled, logger, redisClient, recordGlobalFloodedEvents, globalFloodCheckerEventLogger, settings)
	{
		_NowProvider = nowProvider;
	}

	protected override void DoUpdateCount()
	{
		DateTime timeNow = _NowProvider();
		TimeSpan window = GetWindowPeriod();
		string bucketKey = GetBucketKey(timeNow, window);
		RedisClient.Execute(bucketKey, (IDatabase db) => db.StringIncrement(bucketKey, 1L));
		if (bucketKey != _LastBucketUpdated)
		{
			RedisClient.Execute(bucketKey, (IDatabase db) => db.KeyExpire(bucketKey, GetBucketExpiryTimeSpan(window), CommandFlags.FireAndForget));
			_LastBucketUpdated = bucketKey;
		}
	}

	protected override void DoReset()
	{
		TimeSpan window = GetWindowPeriod();
		DateTime timeNow = _NowProvider();
		string currentBucketKey = GetBucketKey(timeNow, window);
		RedisClient.Execute(currentBucketKey, (IDatabase db) => db.KeyDelete(currentBucketKey));
		string previousBucketKey = GetBucketKey(timeNow - window, window);
		if (previousBucketKey != currentBucketKey)
		{
			RedisClient.Execute(previousBucketKey, (IDatabase db) => db.KeyDelete(previousBucketKey));
		}
	}

	protected override int DoGetCount()
	{
		TimeSpan window = GetWindowPeriod();
		DateTime timeNow = _NowProvider();
		string currentBucketKey = GetBucketKey(timeNow, window);
		int count = (int)RedisClient.Execute(currentBucketKey, (IDatabase db) => db.StringGet(currentBucketKey));
		string previousBucketKey = GetBucketKey(timeNow - window, window);
		if (previousBucketKey != currentBucketKey)
		{
			int previousBucketCount = (int)RedisClient.Execute(previousBucketKey, (IDatabase db) => db.StringGet(previousBucketKey));
			DateTime intervalStartTime = timeNow - window;
			long bucketStartTime = GetBucketStart(timeNow - window, window);
			count += (int)((double)previousBucketCount * (1.0 - (double)(intervalStartTime.Ticks - bucketStartTime) / (double)window.Ticks));
		}
		return count;
	}

	protected override TimeSpan? DoGetRetryAfter()
	{
		TimeSpan window = GetWindowPeriod();
		DateTime timeNow = _NowProvider();
		int limit = GetLimit();
		string currentBucketKey = GetBucketKey(timeNow, window);
		int count = (int)RedisClient.Execute(currentBucketKey, (IDatabase db) => db.StringGet(currentBucketKey));
		if (count >= limit)
		{
			double factor2 = 1.0 - (double)limit / (double)count;
			long retryAfter2 = GetBucketStart(timeNow, window) + (long)Math.Round((double)window.Ticks * factor2) + window.Ticks;
			return (retryAfter2 >= timeNow.Ticks) ? TimeSpan.FromTicks(retryAfter2 - timeNow.Ticks) : TimeSpan.Zero;
		}
		limit -= count;
		string previousBucketKey = GetBucketKey(timeNow - window, window);
		if (previousBucketKey != currentBucketKey)
		{
			count = (int)RedisClient.Execute(previousBucketKey, (IDatabase db) => db.StringGet(previousBucketKey));
			if (count >= limit)
			{
				double factor = 1.0 - (double)limit / (double)count;
				long retryAfter = GetBucketStart(timeNow - window, window) + (long)Math.Round((double)window.Ticks * factor) + window.Ticks;
				return (retryAfter >= timeNow.Ticks) ? TimeSpan.FromTicks(retryAfter - timeNow.Ticks) : TimeSpan.Zero;
			}
		}
		return TimeSpan.Zero;
	}

	private long GetBucketStart(DateTime time, TimeSpan window)
	{
		return time.Ticks - time.Ticks % window.Ticks;
	}

	private string GetBucketKey(DateTime time, TimeSpan window)
	{
		return $"FloodChecker_{Key}_{GetBucketStart(time, window)}";
	}

	private TimeSpan GetBucketExpiryTimeSpan(TimeSpan window)
	{
		return new TimeSpan(window.Ticks * 2);
	}
}
