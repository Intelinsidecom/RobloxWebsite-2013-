using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Counters;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Games;

public static class Extensions
{
	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> of the number of place visits by device type.
	/// </summary>
	/// <param name="placeId">The ID of the place that was visited</param>
	/// <param name="deviceType">The device that the player used</param>
	/// <param name="counterFactory">A DurableCounterFactory</param>
	public static ITimeBucketedCounter GetPlaceVisitsByDeviceTypeTimeBucketedCounter(this IDurableCounterFactory counterFactory, long placeId, DeviceType? deviceType, CounterType counterType = CounterType.Hourly)
	{
		string counterGroup = string.Empty;
		if (deviceType.HasValue)
		{
			counterGroup = "DeviceType:" + deviceType.Value;
		}
		return counterFactory.GetTimeBucketedCounter(counterType, "PlaceVisits", counterGroup, placeId);
	}

	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> of the number of place visits by age group.
	/// </summary>
	/// <param name="counterFactory">The <see cref="T:Roblox.Platform.Counters.IDurableCounterFactory" />.</param>
	/// <param name="placeId">The place identifier.</param>
	/// <param name="devStatsUserAgeGroup">The <see cref="T:Roblox.Platform.Counters.DevStatsUserAgeGroup" />.</param>
	/// <returns>
	/// An <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> for the provided configuration.
	/// </returns>
	public static ITimeBucketedCounter GetPlaceVisitsByAgeGroupTimeBucketedCounter(this IDurableCounterFactory counterFactory, long placeId, DevStatsUserAgeGroup? devStatsUserAgeGroup, CounterType counterType = CounterType.Hourly)
	{
		string counterGroup = string.Empty;
		if (devStatsUserAgeGroup.HasValue)
		{
			counterGroup = "AgeGroup:" + devStatsUserAgeGroup.Value;
		}
		return counterFactory.GetTimeBucketedCounter(counterType, "PlaceVisitsByAge", counterGroup, placeId);
	}

	/// <summary>
	/// Returns an ITimeBucketedCounter that stores the number of minutes spent in a place
	/// </summary>
	/// <param name="placeId">The ID of the place that was visited</param>
	/// <param name="deviceType">The device that the player used</param>
	/// <param name="counterFactory">A DurableCounterFactory</param>
	public static ITimeBucketedCounter GetPlaceTimePlayedTimeBucketedCounter(this IDurableCounterFactory counterFactory, long placeId, DeviceType? deviceType, CounterType counterType = CounterType.Hourly)
	{
		string counterGroup = string.Empty;
		if (deviceType.HasValue)
		{
			counterGroup = "DeviceType:" + deviceType.Value;
		}
		return counterFactory.GetTimeBucketedCounter(counterType, "PlaceTimePlayed", counterGroup, placeId);
	}

	/// <summary>
	/// Returns a <see cref="T:Roblox.Platform.Counters.ICounter" /> that stores the total number of place visits, all time for that device
	/// </summary>
	/// <param name="placeId">The ID of the place that was visited</param>
	/// <param name="deviceType">The device that the player used</param>
	/// <param name="counterFactory">A DurableCounterFactory</param>
	public static ICounter GetPlaceVisitsByDeviceTypeCounter(this IDurableCounterFactory counterFactory, long placeId, DeviceType? deviceType)
	{
		string counterGroup = string.Empty;
		if (deviceType.HasValue)
		{
			counterGroup = "DeviceType:" + deviceType.Value;
		}
		return counterFactory.GetCounter("PlaceVisits", counterGroup, placeId);
	}

	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Counters.ICounter" /> of the number of place visits, all time for that age group.
	/// </summary>
	/// <param name="counterFactory">The <see cref="T:Roblox.Platform.Counters.IDurableCounterFactory" />.</param>
	/// <param name="placeId">The place identifier.</param>
	/// <param name="devStatsUserAgeGroup"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Counters.ICounter" /> for the provided configuration.</returns>
	public static ICounter GetPlaceVisitsByAgeGroupCounter(this IDurableCounterFactory counterFactory, long placeId, DevStatsUserAgeGroup? devStatsUserAgeGroup, CounterType counterType = CounterType.Hourly)
	{
		string counterGroup = string.Empty;
		if (devStatsUserAgeGroup.HasValue)
		{
			counterGroup = "AgeGroup:" + devStatsUserAgeGroup.Value;
		}
		return counterFactory.GetCounter("PlaceVisitsByAge", counterGroup, placeId);
	}

	public static long GetPlaceVisitCount(this IPlace place, Frequency aggregationFrequency, IDurableCounterFactory durableCounterFactory, Action<Exception> exceptionHandler, bool throwOnError = false)
	{
		try
		{
			if (place == null)
			{
				throw new ArgumentNullException("place");
			}
			if (durableCounterFactory == null)
			{
				throw new ArgumentNullException("durableCounterFactory");
			}
			if (aggregationFrequency == Frequency.AllTime)
			{
				return (long)durableCounterFactory.GetCounter("PlaceVisits", string.Empty, place.Id).GetCount();
			}
			return (long)durableCounterFactory.GetTimeBucketedCounter(CounterType.Hourly, "PlaceVisits", string.Empty, place.Id).GetCount(aggregationFrequency);
		}
		catch (Exception ex)
		{
			if (throwOnError || exceptionHandler == null)
			{
				throw;
			}
			exceptionHandler(ex);
			return 0L;
		}
	}
}
