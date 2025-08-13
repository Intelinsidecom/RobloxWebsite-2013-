using System.Threading;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

internal class FractionCounter : CounterBase, IFractionCounter
{
	private readonly object _Sync = new object();

	private long _Value;

	private long _BaseValue;

	private readonly GaugeWrapper _GaugeWrapper;

	public FractionCounter(string category, string name, string instance)
		: base(category, name, instance)
	{
		_GaugeWrapper = new GaugeWrapper(name, instance, category, "generic_fraction");
	}

	public void Increment()
	{
		Interlocked.Increment(ref _Value);
	}

	public void IncrementBase()
	{
		Interlocked.Increment(ref _BaseValue);
	}

	internal override double Flush()
	{
		long value = _Value;
		long baseValue = _BaseValue;
		_BaseValue = 0L;
		_Value = 0L;
		double num = ((baseValue == 0L) ? 0.0 : ((double)value / (double)baseValue * 100.0));
		Interlocked.Exchange(ref LastFlushValue, num);
		_GaugeWrapper.Set(num);
		return num;
	}

	internal override double Get()
	{
		lock (_Sync)
		{
			return (_BaseValue == 0L) ? 0.0 : ((double)_Value / (double)_BaseValue * 100.0);
		}
	}
}
