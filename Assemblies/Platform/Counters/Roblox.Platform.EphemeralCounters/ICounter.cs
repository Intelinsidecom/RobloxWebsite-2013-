using System;

namespace Roblox.EphemeralCounters;

public interface ICounter
{
	long GetCount();

	long FlushCount();

	void Increment(int amount = 1);

	void Decrement(int amount = 1);

	void IncrementInBackground(int value = 1, Action<Exception> exceptionHandler = null);

	void DecrementInBackground(int value = 1, Action<Exception> exceptionHandler = null);

	void Delete();
}
