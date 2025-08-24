using System;
using Roblox.Platform.Notifications.Core;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Notifications.Stream;

public class UnreadCountTracker : IUnreadCountTracker
{
	private readonly IRedisClient _RedisClient;

	private readonly TimeSpan notificationTimeStampExpiry = TimeSpan.FromDays(30.0);

	private readonly Func<DateTime> _GetUtcNow;

	public UnreadCountTracker(IRedisClient redisClient, Func<DateTime> getUtcNow)
	{
		_RedisClient = redisClient;
		_GetUtcNow = getUtcNow;
	}

	public void Reset(IReceiver receiver)
	{
		string unreadNotificationsCountkey = UnreadNotificationsCacheKey(receiver);
		string readNotificationsTimeStampKey = ReadAllNotificationsTimeStampCacheKey(receiver);
		_RedisClient.Execute(unreadNotificationsCountkey, (IDatabase db) => db.StringSet(unreadNotificationsCountkey, 0));
		_RedisClient.Execute(readNotificationsTimeStampKey, (IDatabase db) => db.StringSet(readNotificationsTimeStampKey, _GetUtcNow().Ticks, notificationTimeStampExpiry));
	}

	public long GetCount(IReceiver receiver)
	{
		string key = UnreadNotificationsCacheKey(receiver);
		return (long)_RedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
	}

	public void Increment(IReceiver receiver)
	{
		string key = UnreadNotificationsCacheKey(receiver);
		_RedisClient.Execute(key, (IDatabase db) => db.StringIncrement(key, 1L));
	}

	public bool DecrementIfNotificationWasUnread(IReceiver receiver, long notificationEventTicks)
	{
		string readNotificationsTimeStampKey = ReadAllNotificationsTimeStampCacheKey(receiver);
		if (new DateTime((long)_RedisClient.Execute(readNotificationsTimeStampKey, (IDatabase db) => db.StringGet(readNotificationsTimeStampKey))).ToUniversalTime().Ticks >= new DateTime(notificationEventTicks).ToUniversalTime().Ticks)
		{
			return false;
		}
		string key = UnreadNotificationsCacheKey(receiver);
		_RedisClient.Execute(key, (IDatabase db) => db.StringDecrement(key, 1L));
		return true;
	}

	private string UnreadNotificationsCacheKey(IReceiver receiver)
	{
		return $"UnreadNotificationStreamCount_ReceiverID:{receiver.Id}";
	}

	private string ReadAllNotificationsTimeStampCacheKey(IReceiver receiver)
	{
		return $"ReadAllNotificationsStreamTimeStamp_ReceiverID:{receiver.Id}";
	}
}
