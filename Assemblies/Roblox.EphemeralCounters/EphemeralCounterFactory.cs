using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EphemeralCounters.Client;

namespace Roblox.EphemeralCounters;

public class EphemeralCounterFactory : IEphemeralCounterFactory
{
	private readonly EphemeralCountersClient _Client;

	public EphemeralCounterFactory(EphemeralCountersClient client)
	{
		_Client = client;
	}

	public ISequence GetSequence(string sequenceName)
	{
		return new Sequence(_Client, sequenceName);
	}

	public ICounter GetCounter(string counterName)
	{
		return new Counter(_Client, counterName);
	}

	public IDictionary<string, long> BatchFlushCounters(IEnumerable<string> counterNames)
	{
		return _Client.BatchFlush(counterNames);
	}

	public void BatchIncrementCounters(IDictionary<string, long> entries)
	{
		_Client.BatchIncrement(entries);
	}

	public void BatchIncrementCounters(IEnumerable<string> counterNames)
	{
		Dictionary<string, long> entries = counterNames.ToDictionary((string c) => c, (string c) => 1L);
		BatchIncrementCounters(entries);
	}

	public void BatchIncrementCountersInBackground(IDictionary<string, long> entries, Action<Exception> exceptionHandler = null)
	{
		BackgroundWorker.RunInBackground(delegate
		{
			BatchIncrementCounters(entries);
		}, exceptionHandler);
	}

	public void BatchIncrementCountersInBackground(IEnumerable<string> counterNames, Action<Exception> exceptionHandler = null)
	{
		BackgroundWorker.RunInBackground(delegate
		{
			BatchIncrementCounters(counterNames);
		}, exceptionHandler);
	}

	public void BatchAddToSequences(IDictionary<string, double> entries)
	{
		_Client.BatchAddToSequences(entries);
	}

	public void BatchAddToSequencesInBackground(IDictionary<string, double> entries, Action<Exception> exceptionHandler = null)
	{
		BackgroundWorker.RunInBackground(delegate
		{
			BatchAddToSequences(entries);
		});
	}
}
