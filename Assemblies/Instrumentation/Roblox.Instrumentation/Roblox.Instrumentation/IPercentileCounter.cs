namespace Roblox.Instrumentation;

public interface IPercentileCounter
{
	void Sample(double value);
}
