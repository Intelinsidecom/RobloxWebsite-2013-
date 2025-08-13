using System;
using System.Threading;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

internal class MaximumValueCounter : CounterBase, IMaximumValueCounter
{
	private double _Value;

	private readonly GaugeWrapper _GaugeWrapper;

	public MaximumValueCounter(string category, string name, string instance)
		: base(category, name, instance)
	{
		_GaugeWrapper = new GaugeWrapper(name, instance, category, "generic_max");
	}

	public void Sample(double value)
	{
		double num = _Value;
		double num2;
		do
		{
			double value2 = Math.Max(value, num);
			num2 = num;
			num = Interlocked.CompareExchange(ref _Value, value2, num2);
		}
		while (num != num2);
	}

	internal override double Flush()
	{
		double num = Interlocked.Exchange(ref _Value, 0.0);
		Interlocked.Exchange(ref LastFlushValue, num);
		_GaugeWrapper.Set(num);
		return num;
	}

	internal override double Get()
	{
		return _Value;
	}
}
