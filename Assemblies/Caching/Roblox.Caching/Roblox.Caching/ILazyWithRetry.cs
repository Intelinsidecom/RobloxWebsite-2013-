namespace Roblox.Caching;

public interface ILazyWithRetry<T>
{
	bool IsValueCreated { get; }

	T Value { get; }

	void Reset();
}
