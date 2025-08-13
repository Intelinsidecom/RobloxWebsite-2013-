using System;
using Roblox.EphemeralCounters.Client;

namespace Roblox.EphemeralCounters;

internal class Counter : EphemeralCounterBase, ICounter
{
	private readonly string _CounterName;

	public Counter(EphemeralCountersClient client, string counterName)
		: base(client)
	{
		_CounterName = counterName;
	}

	public long GetCount()
	{
		return Client.Get(_CounterName);
	}

	public long FlushCount()
	{
		return Client.Flush(_CounterName);
	}

	public void Increment(int amount = 1)
	{
		Client.Increment(_CounterName, amount);
	}

	public void Decrement(int amount = 1)
	{
		Client.Decrement(_CounterName, amount);
	}

	public void IncrementInBackground(int value = 1, Action<Exception> exceptionHandler = null)
	{
		BackgroundWorker.RunInBackground(delegate
		{
			Increment(value);
		}, exceptionHandler);
	}

	public void DecrementInBackground(int value = 1, Action<Exception> exceptionHandler = null)
	{
		BackgroundWorker.RunInBackground(delegate
		{
			Decrement(value);
		}, exceptionHandler);
	}

	public void Delete()
	{
		Client.Delete(_CounterName);
	}
}
