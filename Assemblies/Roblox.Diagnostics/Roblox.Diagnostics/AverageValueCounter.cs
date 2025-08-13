using System;
using System.Diagnostics;
using System.Threading;

namespace Roblox.Diagnostics;

public class AverageValueCounter : IAverageValueCounter, IDisposable
{
	private readonly PerformanceCounter _Counter;

	private readonly Timer _Timer;

	private long _TotalValue;

	private long _SampleCount;

	public AverageValueCounter(PerformanceCounter counter, TimeSpan updateInterval)
	{
		_Counter = counter;
		_Timer = new Timer(UpdateCounter);
		_Timer.Change(updateInterval, updateInterval);
	}

	public void Sample(long value)
	{
		Interlocked.Add(ref _TotalValue, value);
		Interlocked.Increment(ref _SampleCount);
	}

	public void Dispose()
	{
		_Timer?.Dispose();
	}

	private void UpdateCounter(object o)
	{
		long totalValue = Interlocked.Exchange(ref _TotalValue, 0L);
		long sampleCount = Interlocked.Exchange(ref _SampleCount, 0L);
		if (sampleCount == 0L)
		{
			_Counter.RawValue = 0L;
			return;
		}
		long averageValue = totalValue / sampleCount;
		_Counter.RawValue = averageValue;
	}
}
