using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Platform.Games.Counters;

internal class PlaySessionUserCharacteristicCounter : PlaySessionCounterBase
{
	public PlaySessionUserCharacteristicCounter(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(ephemeralCounterFactory, logger)
	{
	}

	public void IncrementPlaySessionEnded(int seconds)
	{
		string key = "PlaySessionEnded";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementGuestPlaySessionEnded(int seconds)
	{
		string key = "PlaySessionEnded_Guest";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementLoggedInUserPlaySessionEnded(int seconds)
	{
		string key = "PlaySessionEnded_LoggedInUser";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementGenderAndGuestCount(string gender, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"PlaySessionEnded{guestStr}_{gender}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementPlayerAgeCount(string value, int seconds)
	{
		string key = $"PlaySessionEnded_Age_{value}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementAccountAgeInYearsCount(int value, int seconds)
	{
		string key = $"PlaySessionEnded_AccountAgeInYears_{value}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementHasVerifiedEmail(int seconds)
	{
		string key = "PlaySessionEnded_HasVerifiedEmail";
		IncrementCountAndTotalSeconds(key, seconds);
	}
}
