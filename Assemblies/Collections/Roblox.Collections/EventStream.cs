using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Roblox.EventLog;

namespace Roblox.Collections;

public class EventStream<T>
{
	private readonly BlockingCollection<T> _Events;

	protected readonly string Type = typeof(T).Name;

	protected readonly ILogger Logger;

	public event Action<int> EventQueueUpdated;

	public event Action EventAddedToQueue;

	public EventStream(ILogger logger, int maximumEventsToStore)
	{
		Logger = logger;
		_Events = new BlockingCollection<T>(maximumEventsToStore);
	}

	public virtual void AddEvent(T evt)
	{
		if (!_Events.TryAdd(evt))
		{
			Logger.Error("{0}: Unable to add an event. Internal queue is full!", Type);
		}
		else
		{
			this.EventAddedToQueue?.Invoke();
			this.EventQueueUpdated?.Invoke(_Events.Count);
		}
	}

	public IEnumerable<T> GetEvents(int count)
	{
		List<T> list = new List<T>();
		for (int i = 0; i < count; i++)
		{
			if (!_Events.TryTake(out var evt))
			{
				break;
			}
			list.Add(evt);
		}
		if (list.Count != 0)
		{
			this.EventQueueUpdated?.Invoke(_Events.Count);
		}
		return list;
	}

	public int GetNumberOfEvents()
	{
		return _Events.Count;
	}
}
