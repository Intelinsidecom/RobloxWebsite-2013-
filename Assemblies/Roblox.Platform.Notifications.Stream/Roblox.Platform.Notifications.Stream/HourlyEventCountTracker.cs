using System;
using Roblox.Platform.Notifications.Core;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Notifications.Stream;

public class HourlyEventCountTracker : IHourlyEventCountTracker
{
	private readonly IRedisClient _RedisClient;

	private readonly TimeSpan _ExpirationDelay;

	public HourlyEventCountTracker(IRedisClient redisClient, TimeSpan expirationDelay)
	{
		_RedisClient = redisClient;
		_ExpirationDelay = expirationDelay;
	}

	public void Increment(IReceiver receiver, NotificationSourceType sourceType, DateTime eventDateTime)
	{
		int hourBucket = GetHourBucket(eventDateTime);
		DateTime dayBucket = GetDayBucket(eventDateTime);
		string key = HourlyEventCountCacheKey(receiver, sourceType, dayBucket);
		_RedisClient.Execute(key, (IDatabase db) => db.SortedSetIncrement(key, hourBucket, 1.0));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, _ExpirationDelay, CommandFlags.FireAndForget));
	}

	public void Decrement(IReceiver receiver, NotificationSourceType sourceType, DateTime eventDateTime)
	{
		int hourBucket = GetHourBucket(eventDateTime);
		DateTime dayBucket = GetDayBucket(eventDateTime);
		string key = HourlyEventCountCacheKey(receiver, sourceType, dayBucket);
		_RedisClient.Execute(key, (IDatabase db) => db.SortedSetDecrement(key, hourBucket, 1.0));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, _ExpirationDelay, CommandFlags.FireAndForget));
	}

	public long GetCount(IReceiver receiver, NotificationSourceType sourceType, DateTime startDateTime, int numOfHoursToCount)
	{
		if (numOfHoursToCount < 0)
		{
			throw new ArgumentException("Cannot Count Negative number of Hours", "numOfHoursToCount");
		}
		long totalCount = 0L;
		DateTime dayBucket = GetDayBucket(startDateTime);
		int startHour = startDateTime.Hour;
		while (numOfHoursToCount > 0)
		{
			int numOfHoursFromThisDay = Math.Min(numOfHoursToCount, 24 - startHour);
			totalCount += GetCountForTheDay(receiver, sourceType, dayBucket, startHour, numOfHoursFromThisDay);
			numOfHoursToCount -= numOfHoursFromThisDay;
			startHour = 0;
			dayBucket = dayBucket.AddDays(1.0);
		}
		return totalCount;
	}

	private long GetCountForTheDay(IReceiver receiver, NotificationSourceType sourceType, DateTime dayBucket, long startHour, long numOfHours)
	{
		string key = HourlyEventCountCacheKey(receiver, sourceType, dayBucket);
		SortedSetEntry[] array = _RedisClient.Execute(key, (IDatabase db) => db.SortedSetRangeByScoreWithScores(key, double.NegativeInfinity, double.PositiveInfinity, Exclude.None, Order.Ascending, 0L, -1L));
		long endHour = startHour + numOfHours;
		long total = 0L;
		SortedSetEntry[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			SortedSetEntry entry = array2[i];
			if (startHour <= long.Parse(entry.Element) && long.Parse(entry.Element) < endHour)
			{
				total += (long)entry.Score;
			}
		}
		return total;
	}

	private static int GetHourBucket(DateTime dateTime)
	{
		return dateTime.Hour;
	}

	private static DateTime GetDayBucket(DateTime dateTime)
	{
		return dateTime.Date;
	}

	private static string HourlyEventCountCacheKey(IReceiver receiver, NotificationSourceType sourceType, DateTime eventBucketDateTime)
	{
		return $"HrCount_RID:{receiver.Id}_ST:{sourceType}_Date:{eventBucketDateTime}";
	}
}
