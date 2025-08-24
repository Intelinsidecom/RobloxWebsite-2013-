using System;
using Roblox.RealTimeNotifications.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.RealTimeNotifications;

public class UserRealTimeActivityMonitor : IUserRealTimeActivityMonitor
{
	private readonly IRedisClient _RedisClient;

	private readonly IUpdateDebouncer<long> _UpdateDebouncer;

	public UserRealTimeActivityMonitor(IRedisClient redisClient, IUpdateDebouncer<long> updateDebouncer = null)
	{
		_RedisClient = redisClient;
		_UpdateDebouncer = updateDebouncer;
	}

	public void RecordUserRealTimeConnectionActive(long userId)
	{
		if (!Settings.Default.IsUserActivityTrackingEnabled)
		{
			return;
		}
		if (_UpdateDebouncer == null)
		{
			UpdateRedisForActiveUserConnection(userId);
			return;
		}
		_UpdateDebouncer.ExecuteWithDebounce(userId, delegate
		{
			UpdateRedisForActiveUserConnection(userId);
		});
	}

	public bool IsUserActiveNow(long userId)
	{
		if (Settings.Default.IsUserActivityTrackingEnabled)
		{
			string key = GetKey(userId);
			RedisValue lastActiveTicks = _RedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
			DateTime lastActive = new DateTime((long)lastActiveTicks, DateTimeKind.Utc);
			return GetTime().Subtract(lastActive) < Settings.Default.UserActivityActiveNowThreshold;
		}
		return true;
	}

	public bool HasUserBeenActiveRecently(long userId)
	{
		if (Settings.Default.IsUserActivityTrackingEnabled)
		{
			string key = GetKey(userId);
			return _RedisClient.Execute(key, (IDatabase db) => db.KeyExists(key));
		}
		return true;
	}

	private void UpdateRedisForActiveUserConnection(long userId)
	{
		string key = GetKey(userId);
		_RedisClient.Execute(key, (IDatabase db) => db.StringSet(key, GetTime().Ticks, Settings.Default.UserActivityExpiry, When.Always, CommandFlags.FireAndForget));
	}

	private DateTime GetTime()
	{
		return DateTime.UtcNow;
	}

	private string GetKey(long userId)
	{
		return "LastConnActivity_U:" + userId;
	}
}
