namespace Roblox.Sentinels;

public class CircuitBreaker : CircuitBreakerBase
{
	protected internal override string Name { get; }

	public CircuitBreaker(string name)
	{
		Name = name;
	}
}
