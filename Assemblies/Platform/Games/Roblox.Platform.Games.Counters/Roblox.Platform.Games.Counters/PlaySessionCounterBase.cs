using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Games.Counters.Properties;

namespace Roblox.Platform.Games.Counters;

public class PlaySessionCounterBase : BufferedEphemeralCounterBase
{
	protected override TimeSpan CommitInterval => Settings.Default.CounterCommitInterval;

	protected override int MaxDegreeOfParallelism => Settings.Default.MaxDegreeOfParallelism;

	public PlaySessionCounterBase(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(ephemeralCounterFactory, logger)
	{
	}

	/// <summary>
	/// Increments counts in all cases; increments totalSeconds if settings allow.
	/// </summary>
	internal void IncrementCountAndTotalSeconds(string baseKey, int seconds)
	{
		if (Settings.Default.MaxPlaySessionLength > 0)
		{
			seconds = Math.Min(seconds, Settings.Default.MaxPlaySessionLength);
		}
		if (!Settings.Default.SkipRecordingMaxLengthPlaySessions || Settings.Default.MaxPlaySessionLength <= 0 || seconds != Settings.Default.MaxPlaySessionLength)
		{
			string countKey = $"{baseKey}_Count";
			Increment(countKey);
			if (seconds > 0)
			{
				string totalSecondsKey = $"{baseKey}_Seconds";
				Increment(totalSecondsKey, seconds);
			}
		}
	}
}
