namespace Roblox.Instrumentation;

public sealed class NoOpCounter : IRateOfCountsPerSecondCounter, IAverageValueCounter, IMaximumValueCounter, IRawValueCounter, IFractionCounter, IPercentileCounter
{
	public long RawValue { get; }

	public void Set(long value)
	{
	}

	public void IncrementBy(long eventCount)
	{
	}

	public void Increment()
	{
	}

	public void IncrementBase()
	{
	}

	public void Decrement()
	{
	}

	public void Sample(double value)
	{
	}
}
