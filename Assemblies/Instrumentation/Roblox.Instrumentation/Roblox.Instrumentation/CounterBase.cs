namespace Roblox.Instrumentation;

public abstract class CounterBase
{
	internal double LastFlushValue;

	public CounterKey Key { get; }

	protected CounterBase(string category, string name, string instance)
	{
		Key = new CounterKey(category, name, instance);
	}

	public double GetLastFlushValue()
	{
		return LastFlushValue;
	}

	internal abstract double Flush();

	internal abstract double Get();
}
