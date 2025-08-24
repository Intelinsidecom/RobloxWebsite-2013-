using System;
using Roblox.EventLog;

namespace Roblox.Collections;

public class DebouncingEventStream<TEvent, TKey> : EventStream<TEvent>, IDisposable
{
	private readonly ExpirableDictionary<TKey, string> _Debouncer;

	public DebouncingEventStream(ILogger logger, int maximumEventsToStore, TimeSpan debunceWindow)
		: base(logger, maximumEventsToStore)
	{
		_Debouncer = new ExpirableDictionary<TKey, string>(debunceWindow);
		_Debouncer.ExceptionOccurred += delegate(Exception ex)
		{
			Logger.Error("Error in DebouncingEventStream: " + ex);
		};
	}

	public bool ShouldDebounce(TKey key)
	{
		return _Debouncer.ContainsKey(key);
	}

	public void AddToDebouncer(TKey key)
	{
		_Debouncer.Set(key, string.Empty);
	}

	public void Dispose()
	{
		_Debouncer.Dispose();
	}
}
