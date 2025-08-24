using System;
using System.Collections.Concurrent;

namespace Roblox.RealTimeNotifications;

public class UpdateDebouncer<T> : IUpdateDebouncer<T>
{
	private readonly int _NumberOfAttemptsToDebounce;

	private readonly ConcurrentDictionary<T, long> _UpdateDebouncer = new ConcurrentDictionary<T, long>();

	public UpdateDebouncer(int numberOfAttemptsToDebounce)
	{
		_NumberOfAttemptsToDebounce = numberOfAttemptsToDebounce;
	}

	public void AddToDebouncedSet(T updateIdentifier)
	{
		_UpdateDebouncer.AddOrUpdate(updateIdentifier, (T s) => 0L, (T s, long val) => 0L);
	}

	public void RemoveFromDebouncedSet(T updateIdentifier)
	{
		_UpdateDebouncer.TryRemove(updateIdentifier, out var _);
	}

	public void ExecuteWithDebounce(T updateIdentifier, Action actionToExecute)
	{
		long executionCount = 0L;
		executionCount = _UpdateDebouncer.AddOrUpdate(updateIdentifier, (T s) => executionCount, (T s, long val) => val + 1);
		if (executionCount % _NumberOfAttemptsToDebounce == 0L)
		{
			actionToExecute();
		}
	}

	public long GetNumberOfAttemptsToDebounce()
	{
		return _NumberOfAttemptsToDebounce;
	}
}
