using System.Threading;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

internal class AverageValueCounter : CounterBase, IAverageValueCounter
{
	private readonly object _Sync = new object();

	private double _Sum;

	private long _Count;

	private readonly GaugeWrapper _GaugeWrapper;

	public AverageValueCounter(string category, string name, string instance)
		: base(category, name, instance)
	{
		_GaugeWrapper = new GaugeWrapper(name, instance, category, "generic_average");
	}

	public void Sample(double value)
	{
		lock (_Sync)
		{
			_Sum += value;
			_Count++;
		}
	}

	internal override double Flush()
	{
		double sum;
		long count;
		lock (_Sync)
		{
			sum = _Sum;
			count = _Count;
			_Sum = 0.0;
			_Count = 0L;
		}
		double num = ((count == 0L) ? 0.0 : (sum / (double)count));
		Interlocked.Exchange(ref LastFlushValue, num);
		_GaugeWrapper.Set(num);
		return num;
	}

	internal override double Get()
	{
		lock (_Sync)
		{
			return (_Count == 0L) ? 0.0 : (_Sum / (double)_Count);
		}
	}
}
