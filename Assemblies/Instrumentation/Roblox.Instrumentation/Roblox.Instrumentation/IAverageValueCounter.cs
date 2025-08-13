namespace Roblox.Instrumentation;

public interface IAverageValueCounter
{
	void Sample(double value);
}
