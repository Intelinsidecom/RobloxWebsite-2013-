using System;

namespace Roblox.Platform.Games.Counters.Properties;

public interface ISettings
{
	object this[string propertyName] { get; set; }

	bool AreAggregatedCounterTypesForPlaceVisitsEnabled { get; }

	TimeSpan BufferedAllTimeGameCounterCommitInterval { get; }

	int BufferedAllTimeGameCounterCommitMaxDegreeOfParallelism { get; }

	TimeSpan BufferedTimeBucketedGameCounterCommitInterval { get; }

	int BufferedTimeBucketedGameCounterCommitMaxDegreeOfParallelism { get; }

	TimeSpan CounterCommitInterval { get; }

	TimeSpan GameJoinFromVRCounterCommitInterval { get; }

	int GameJoinFromVRCounterMaxDegreeOfParallelism { get; }

	int MaxDegreeOfParallelism { get; }

	int MaxPlaySessionLength { get; }

	bool SkipRecordingMaxLengthPlaySessions { get; }

	TimeSpan TimeInGameCacheCorrectedExpirationTime { get; }

	string TimeInGameCounterPrefix { get; }

	string TimeInGameMonthlyCounterPrefix { get; }

	bool TimeInGameOverflowCorrectionEnabled { get; }

	DateTime TimeInGameOverflowCorrectStartDate { get; }
}
