using System;
using System.Diagnostics;
using System.Threading;

namespace Roblox.Diagnostics;

public class AverageTimeIntervalCounter : IDisposable
{
	private readonly PerformanceCounter _Counter;

	private readonly Timer _Timer;

	private long _Ticks;

	private long _Count;

	public AverageTimeIntervalCounter(PerformanceCounter counter)
	{
		_Counter = counter;
		TimeSpan twoSeconds = TimeSpan.FromSeconds(2.0);
		_Timer = new Timer(delegate
		{
			UpdateCounter();
		}, null, twoSeconds, twoSeconds);
	}

	public void Sample(Stopwatch stopwatch)
	{
		Interlocked.Add(ref _Ticks, stopwatch.ElapsedTicks);
		Interlocked.Increment(ref _Count);
	}

	private void UpdateCounter()
	{
		long t = Interlocked.Exchange(ref _Ticks, 0L);
		long c = Interlocked.Exchange(ref _Count, 0L);
		if (c == 0L)
		{
			_Counter.RawValue = 0L;
			return;
		}
		long averageMilliseconds = t / c * 1000 / Stopwatch.Frequency;
		_Counter.RawValue = averageMilliseconds;
	}

	public void Dispose()
	{
		_Timer?.Dispose();
	}
}
