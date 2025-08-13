using System.Threading;
using Roblox.Instrumentation.PrometheusListener;

namespace Roblox.Instrumentation;

internal class RawValueCounter : CounterBase, IRawValueCounter
{
	private long _Value;

	private readonly GaugeWrapper _GaugeWrapper;

	public long RawValue => _Value;

	public RawValueCounter(string category, string name, string instance)
		: base(category, name, instance)
	{
		_GaugeWrapper = new GaugeWrapper(name, instance, category, "generic_raw");
	}

	public void Set(long value)
	{
		_Value = value;
	}

	public void IncrementBy(long value)
	{
		Interlocked.Add(ref _Value, value);
	}

	public void Increment()
	{
		Interlocked.Increment(ref _Value);
	}

	public void Decrement()
	{
		Interlocked.Decrement(ref _Value);
	}

	internal override double Flush()
	{
		Interlocked.Exchange(ref LastFlushValue, _Value);
		_GaugeWrapper.Set(_Value);
		return _Value;
	}

	internal override double Get()
	{
		return _Value;
	}
}
