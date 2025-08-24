using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Platform.Games.Counters;

internal class PlaySessionUserPaymentDataCounter : PlaySessionCounterBase
{
	public PlaySessionUserPaymentDataCounter(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(ephemeralCounterFactory, logger)
	{
	}

	public void IncrementPaidUsers(int seconds)
	{
		string key = "PlaySessionEnded_PaidUser";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementIsAnyBC(int seconds)
	{
		string key = "PlaySessionEnded_IsAnyBC";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementIsBC(int seconds)
	{
		string key = "PlaySessionEnded_IsBC";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementIsTBC(int seconds)
	{
		string key = "PlaySessionEnded_IsTBC";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementIsOBC(int seconds)
	{
		string key = "PlaySessionEnded_IsOBC";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	/// <summary>
	/// digits in users robux balance.
	/// </summary>
	public void IncrementRobuxBalanceSignificantDigitsCount(int value, int seconds)
	{
		string key = $"PlaySessionEnded_RobuxBalanceSignificantDigits_{value}";
		IncrementCountAndTotalSeconds(key, seconds);
	}
}
