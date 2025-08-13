using System;
using System.Threading;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

internal class RateOfCountsPerSecondCounter : CounterBase, IRateOfCountsPerSecondCounter
{
	private long _NumberOfEvents;

	private DateTime _LastFlush;

	private readonly GaugeWrapper _GaugeWrapper;

	public RateOfCountsPerSecondCounter(string category, string name, string instance)
		: base(category, name, instance)
	{
		_LastFlush = DateTime.UtcNow;
		_GaugeWrapper = new GaugeWrapper(name, instance, category, "generic_rate");
	}

	public void IncrementBy(long eventCount)
	{
		Interlocked.Add(ref _NumberOfEvents, eventCount);
	}

	public void Increment()
	{
		IncrementBy(1L);
	}

	internal override double Flush()
	{
		DateTime utcNow = DateTime.UtcNow;
		long num = Interlocked.Exchange(ref _NumberOfEvents, 0L);
		double totalSeconds = (utcNow - _LastFlush).TotalSeconds;
		_LastFlush = utcNow;
		if (totalSeconds == 0.0)
		{
			_GaugeWrapper.Set(0.0);
			return 0.0;
		}
		double num2 = (double)num / totalSeconds;
		Interlocked.Exchange(ref LastFlushValue, num2);
		_GaugeWrapper.Set(num2);
		return num2;
	}

	internal override double Get()
	{
		double totalSeconds = (DateTime.UtcNow - _LastFlush).TotalSeconds;
		if (totalSeconds == 0.0)
		{
			return 0.0;
		}
		return (double)_NumberOfEvents / totalSeconds;
	}
}
