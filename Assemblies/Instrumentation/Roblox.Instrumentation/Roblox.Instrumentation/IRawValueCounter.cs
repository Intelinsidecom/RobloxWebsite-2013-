namespace Roblox.Instrumentation;

public interface IRawValueCounter
{
	long RawValue { get; }

	void Set(long value);

	void IncrementBy(long value);

	void Increment();

	void Decrement();
}
