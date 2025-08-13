using System;
using Roblox.ApiClientBase;
using Roblox.Caching.Shared;
using Roblox.EphemeralCounters;
using Roblox.Platform.Core;
using Roblox.Platform.Counters;
using Roblox.Platform.Games.Counters.Properties;

namespace Roblox.Platform.Games.Counters;

/// <summary>
/// This class contains methods used to increment and retrieve the value of a user's time in game counter.
/// The counts returned in this class correspond to the amount of time a user has spent playing any game
/// in the Roblox client on any device - the counts are not specific to certain games.
/// </summary>
public class TimeInGameCounter : ITimeInGameCounter
{
	private const string _OverflowCorrectedCounterName = "TimeInGame_OverflowCorrected";

	private readonly IDurableCounterFactory _CounterFactory;

	private readonly ISettings _Settings;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly ISharedCacheClient _SharedCacheClient;

	public TimeInGameCounter(IDurableCounterFactory counterFactory, IEphemeralCounterFactory ephemeralCounterFactory = null, ISharedCacheClient sharedCacheClient = null)
	{
		_CounterFactory = counterFactory;
		_Settings = Settings.Default;
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_SharedCacheClient = sharedCacheClient;
	}

	/// <summary>
	/// Internal constructor used for faking settings in unit tests.
	/// </summary>
	/// <param name="durableCounterFactory"></param>
	/// <param name="settings"></param>
	/// <param name="sharedCacheClient"></param>
	internal TimeInGameCounter(IDurableCounterFactory durableCounterFactory, ISettings settings, ISharedCacheClient sharedCacheClient)
	{
		_CounterFactory = durableCounterFactory;
		_Settings = settings;
		_SharedCacheClient = sharedCacheClient;
	}

	/// <summary>
	/// Returns the total amount of time the user has spent playing games in the Roblox
	/// client since September 2017
	/// </summary>
	/// <param name="userId"></param>
	/// <returns>Total seconds spent in-game</returns>
	public double GetTotalSecondsInGameByUserId(long userId)
	{
		try
		{
			return _CounterFactory.GetCounter(GetCounterName(userId)).GetCount();
		}
		catch (ApiClientException ex)
		{
			throw new PlatformException("Unable to connect to DurableCounters service.", ex);
		}
	}

	/// <summary>
	/// A wrapper for GetTotalSecondsInGameByUserId that returns a TimeSpan object
	/// rather than a double value
	/// </summary>
	/// <param name="userId"></param>
	/// <returns>TimeSpan total time in-game</returns>
	public TimeSpan GetTotalTimeInGameByUserId(long userId)
	{
		double seconds = GetTotalSecondsInGameByUserId(userId);
		try
		{
			return TimeSpan.FromSeconds(seconds);
		}
		catch (OverflowException ex2)
		{
			throw new PlatformException("Seconds count was too large to convert to timespan.", ex2);
		}
		catch (ArgumentException ex)
		{
			throw new PlatformException("Seconds count was invalid.", ex);
		}
	}

	/// <summary>
	/// Returns the time a user has spent playing games on the Roblox client
	/// for a given month/year combination
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="month"></param>
	/// <param name="year"></param>
	/// <returns>Seconds in-game for the month</returns>
	public double GetSecondsInGameByUserIdForMonth(long userId, int month, int year)
	{
		try
		{
			return _CounterFactory.GetCounter(GetMonthlyCounterName(userId, month, year)).GetCount();
		}
		catch (ApiClientException ex)
		{
			throw new PlatformException("Unable to connect to DurableCounters service.", ex);
		}
	}

	/// <summary>
	/// Wrapper for GetSecondsInGameByUserIdForMonth that returns a TimeSpan
	/// object rather than double seconds count
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="month"></param>
	/// <param name="year"></param>
	/// <returns>TimeSpan seconds in-game for month</returns>
	public TimeSpan GetTimeInGameByUserIdForMonth(long userId, int month, int year)
	{
		double seconds = GetSecondsInGameByUserIdForMonth(userId, month, year);
		try
		{
			return TimeSpan.FromSeconds(seconds);
		}
		catch (OverflowException ex2)
		{
			throw new PlatformException("Seconds count was too large to convert to timespan.", ex2);
		}
		catch (ArgumentException ex)
		{
			throw new PlatformException("Seconds count was invalid.", ex);
		}
	}

	/// <summary>
	/// Increments a user's total and current monthly time in game
	/// counters by the provided seconds count. This is used by the
	/// GameInstances processor and called when a successful playsession is ended.
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="seconds"></param>
	public void IncrementSecondsInGameByUserId(long userId, double seconds)
	{
		Roblox.Platform.Counters.ICounter timeInGameCounter = _CounterFactory.GetCounter(GetCounterName(userId));
		CheckAndCorrectOverflowTimeInGame(userId, timeInGameCounter);
		timeInGameCounter.Increment(seconds);
		_CounterFactory.GetCounter(GetMonthlyCounterName(userId, DateTime.UtcNow.Month, DateTime.UtcNow.Year)).Increment(seconds);
	}

	/// <summary>
	/// Internal method used to store and retrieve the all-time counter from the DurableCounters service.
	/// The returned value is also the key under which the count is stored in DynamoDB
	/// </summary>
	/// <param name="userId"></param>
	/// <returns>all-time counter name</returns>
	internal string GetCounterName(long userId)
	{
		return $"{_Settings.TimeInGameCounterPrefix}_{userId}";
	}

	/// <summary>
	/// Internal method for determining the name of the durable counter that will store the per-user monthly count.
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="month"></param>
	/// <param name="year"></param>
	/// <returns>monthly counter name</returns>
	internal string GetMonthlyCounterName(long userId, int month, int year)
	{
		if (month < 1 || month > 12)
		{
			throw new PlatformArgumentException("Invalid month: should be an integer between 1 and 12.");
		}
		return $"{_Settings.TimeInGameMonthlyCounterPrefix}_{year}{month:D2}_{userId}";
	}

	private void CheckAndCorrectOverflowTimeInGame(long userId, Roblox.Platform.Counters.ICounter globalCounter)
	{
		string userTimeCorrectedCacheKey = GetUserTimeInGameCorrectedCacheKey(userId);
		if (_Settings.TimeInGameOverflowCorrectionEnabled && _SharedCacheClient != null && !_SharedCacheClient.Query(userTimeCorrectedCacheKey, out var _, out var unique))
		{
			DateTime now = DateTime.UtcNow;
			double overflowThreshold = now.Subtract(_Settings.TimeInGameOverflowCorrectStartDate).TotalSeconds;
			double totalSeconds = globalCounter.GetCount();
			if (totalSeconds > overflowThreshold && overflowThreshold > 0.0 && _SharedCacheClient.CheckAndSet(userTimeCorrectedCacheKey, userId.ToString(), _Settings.TimeInGameCacheCorrectedExpirationTime, unique) == SharedCacheClient.CasResult.Stored)
			{
				globalCounter.Decrement(totalSeconds);
				globalCounter.Increment(GetTotalSecondsInGameFromMonthlyCountersBetweenDates(userId, _Settings.TimeInGameOverflowCorrectStartDate, now));
				(_EphemeralCounterFactory?.GetCounter("TimeInGame_OverflowCorrected"))?.IncrementInBackground();
			}
		}
	}

	private double GetTotalSecondsInGameFromMonthlyCountersBetweenDates(long userId, DateTime startDate, DateTime endDate)
	{
		double totalSeconds = 0.0;
		DateTime monthDate = startDate;
		while (monthDate < endDate.AddMonths(1))
		{
			totalSeconds += GetSecondsInGameByUserIdForMonth(userId, monthDate.Month, monthDate.Year);
			monthDate = monthDate.AddMonths(1);
		}
		return totalSeconds;
	}

	private string GetUserTimeInGameCorrectedCacheKey(long userId)
	{
		return $"Roblox.Platform.Games.Counters_TimeInGameOverFlowCorrectedForUserId_{userId}";
	}
}
