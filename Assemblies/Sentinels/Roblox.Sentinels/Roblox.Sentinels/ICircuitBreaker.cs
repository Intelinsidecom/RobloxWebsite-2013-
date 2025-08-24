namespace Roblox.Sentinels;

public interface ICircuitBreaker
{
	bool IsTripped { get; }

	bool Reset();

	void Test();

	bool Trip();
}
