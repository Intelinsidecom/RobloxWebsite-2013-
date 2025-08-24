using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Counters;

public static class Extensions
{
	public static ITimeBucketedCounter GetPlatformTimePlayedCounter(this IDurableCounterFactory counterFactory, byte platformTypeId)
	{
		return counterFactory.GetTimeBucketedCounter("PlatformTimePlayed", string.Empty, platformTypeId);
	}

	public static ITimeBucketedCounter GetPlatformGameVisitsCounter(this IDurableCounterFactory counterFactory, byte platformTypeId)
	{
		return counterFactory.GetTimeBucketedCounter("PlatformGameVisits", string.Empty, platformTypeId);
	}

	/// <summary>
	/// Returns CounterValues aggregated by, e.g., month or day.
	/// </summary>
	/// <param name="hourBuckets"></param>
	/// <param name="dateTimeCoalescingFunction">For example, counterValue.Bucket.Date.</param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if dateTimeCoalescingFunction is null.</exception>
	public static IEnumerable<CounterValue> GroupCounterValuesByDateOrMonth(this IEnumerable<CounterValue> hourBuckets, Func<CounterValue, DateTime> dateTimeCoalescingFunction)
	{
		if (hourBuckets == null)
		{
			return null;
		}
		if (dateTimeCoalescingFunction == null)
		{
			throw new PlatformArgumentNullException("Attempted to aggregate counter values but had no idea what to aggregate by.");
		}
		DateTime currentDate = DateTime.UtcNow.Date;
		return from g in hourBuckets.GroupBy(dateTimeCoalescingFunction)
			where g.Key != currentDate
			select new CounterValue(g.Key, g.Sum((CounterValue x) => x.Value)) into d
			orderby d.Bucket
			select d;
	}

	/// <summary>
	/// Pads a list of counter values with hourly buckets of 0 between startTime and endTime.
	/// </summary>
	/// <param name="startTime"></param>
	/// <param name="endTime"></param>
	/// <param name="originalCounterValues"></param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if originalCounterValues is null.</exception>
	public static IEnumerable<CounterValue> PadHourlyCounterValues(this IEnumerable<CounterValue> originalCounterValues, DateTime startTime, DateTime endTime)
	{
		if (originalCounterValues == null)
		{
			throw new ArgumentNullException("originalCounterValues");
		}
		List<CounterValue> originalItemsAsList = originalCounterValues.ToList();
		List<CounterValue> paddedList = new List<CounterValue>();
		while (startTime <= endTime)
		{
			CounterValue actualValue = originalItemsAsList.FirstOrDefault((CounterValue item) => item.Bucket == startTime);
			paddedList.Add(new CounterValue(startTime, actualValue?.Value ?? 0.0));
			startTime = startTime.AddHours(1.0);
		}
		return paddedList;
	}

	/// <summary>
	/// Gets the dev stats user age group given a birthdate.
	/// </summary>
	/// <param name="birthdate">The birthdate.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Counters.DevStatsUserAgeGroup" /> that the user falls under.</returns>
	public static DevStatsUserAgeGroup GetDevStatsUserAgeGroup(this DateTime? birthdate)
	{
		return GetDevStatsUserAgeGroup(DateTime.Now, birthdate);
	}

	internal static DevStatsUserAgeGroup GetDevStatsUserAgeGroup(DateTime now, DateTime? birthdate)
	{
		if (!birthdate.HasValue)
		{
			return DevStatsUserAgeGroup.Unknown;
		}
		if (birthdate > now.AddYears(-7))
		{
			return DevStatsUserAgeGroup.SixOrUnder;
		}
		DateTime dateTime = now.AddYears(-7);
		DateTime? dateTime2 = birthdate;
		if (dateTime2.HasValue && dateTime >= dateTime2.GetValueOrDefault() && birthdate > now.AddYears(-9))
		{
			return DevStatsUserAgeGroup.SevenAndEight;
		}
		dateTime = now.AddYears(-9);
		dateTime2 = birthdate;
		if (dateTime2.HasValue && dateTime >= dateTime2.GetValueOrDefault() && birthdate > now.AddYears(-11))
		{
			return DevStatsUserAgeGroup.NineAndTen;
		}
		dateTime = now.AddYears(-11);
		dateTime2 = birthdate;
		if (dateTime2.HasValue && dateTime >= dateTime2.GetValueOrDefault() && birthdate > now.AddYears(-13))
		{
			return DevStatsUserAgeGroup.ElevenAndTwelve;
		}
		dateTime = now.AddYears(-13);
		dateTime2 = birthdate;
		if (dateTime2.HasValue && dateTime >= dateTime2.GetValueOrDefault() && birthdate > now.AddYears(-16))
		{
			return DevStatsUserAgeGroup.ThirteenToFifteen;
		}
		dateTime = now.AddYears(-16);
		dateTime2 = birthdate;
		if (dateTime2.HasValue && dateTime >= dateTime2.GetValueOrDefault() && birthdate > now.AddYears(-18))
		{
			return DevStatsUserAgeGroup.SixteenAndSeventeen;
		}
		return DevStatsUserAgeGroup.EighteenOrOver;
	}
}
