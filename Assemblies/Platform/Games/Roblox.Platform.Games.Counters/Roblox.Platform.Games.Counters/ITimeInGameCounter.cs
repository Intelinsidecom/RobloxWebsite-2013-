using System;

namespace Roblox.Platform.Games.Counters;

public interface ITimeInGameCounter
{
	double GetTotalSecondsInGameByUserId(long userId);

	TimeSpan GetTotalTimeInGameByUserId(long userId);

	double GetSecondsInGameByUserIdForMonth(long userId, int month, int year);

	TimeSpan GetTimeInGameByUserIdForMonth(long userId, int month, int year);

	void IncrementSecondsInGameByUserId(long userId, double time);
}
