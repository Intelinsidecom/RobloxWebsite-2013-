using System;
using System.Diagnostics;

namespace Roblox.Instrumentation;

public class DurationRecorder : IDurationRecorder
{
	private readonly Func<Stopwatch, double> _WatchReader;

	public DurationRecorder(Func<Stopwatch, double> watchReader)
	{
		_WatchReader = watchReader ?? throw new ArgumentNullException("watchReader");
	}

	public static DurationRecorder CreateWithMillisecondWatchReader()
	{
		return new DurationRecorder((Stopwatch watch) => watch.Elapsed.TotalMilliseconds);
	}

	public void RecordDuration(Action operation, IAverageValueCounter counter)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		operation();
		stopwatch.Stop();
		double value = _WatchReader(stopwatch);
		counter.Sample(value);
	}

	public T RecordDuration<T>(Func<T> operation, IAverageValueCounter counter)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		T result = operation();
		stopwatch.Stop();
		double value = _WatchReader(stopwatch);
		counter.Sample(value);
		return result;
	}

	public void RecordDuration(Action operation, IPercentileCounter counter)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		operation();
		stopwatch.Stop();
		double value = _WatchReader(stopwatch);
		counter.Sample(value);
	}

	public T RecordDuration<T>(Func<T> operation, IPercentileCounter counter)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		T result = operation();
		stopwatch.Stop();
		double value = _WatchReader(stopwatch);
		counter.Sample(value);
		return result;
	}
}
