using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.Counters;

namespace Roblox.Platform.Games.Counters;

public class GamePerformanceMetricsRecorder
{
	/// <summary>
	/// Represents a delegate for the <see cref="E:Roblox.Platform.Games.Counters.GamePerformanceMetricsRecorder.OnRecord" /> event.
	/// </summary>
	/// <param name="counterKey">The counter key containing the record.</param>
	public delegate void OnRecordHandler(string counterKey);

	private readonly BufferedAllTimeCounter _GamePerformanceMetricsBufferedCounter;

	/// <summary>
	/// Occurs after game performance metric is recorded.
	/// </summary>
	/// <remarks>
	/// Note that this event is not guaranteed to occur directly after a metric is recorded.
	/// </remarks>
	public event OnRecordHandler OnRecord;

	public GamePerformanceMetricsRecorder(IDurableCounterFactory durableCounterFactory, ILogger logger)
	{
		_GamePerformanceMetricsBufferedCounter = new BufferedAllTimeCounter(durableCounterFactory, logger);
		_GamePerformanceMetricsBufferedCounter.OnCommit += OnCommit_SendOnRecordEvents;
	}

	private void OnCommit_SendOnRecordEvents(IEnumerable<string> counterKeys)
	{
		if (this.OnRecord == null)
		{
			return;
		}
		foreach (string counterKey in counterKeys)
		{
			this.OnRecord(counterKey);
		}
	}

	public void Increment(string counterKey)
	{
		_GamePerformanceMetricsBufferedCounter.Increment(counterKey);
	}
}
