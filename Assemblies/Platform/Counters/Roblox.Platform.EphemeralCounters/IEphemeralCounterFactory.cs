using System;
using System.Collections.Generic;

namespace Roblox.EphemeralCounters;

public interface IEphemeralCounterFactory
{
	ISequence GetSequence(string sequenceName);

	ICounter GetCounter(string counterName);

	void BatchIncrementCounters(IDictionary<string, long> entries);

	void BatchIncrementCounters(IEnumerable<string> counterNames);

	void BatchIncrementCountersInBackground(IDictionary<string, long> entries, Action<Exception> exceptionHandler = null);

	void BatchIncrementCountersInBackground(IEnumerable<string> counterNames, Action<Exception> exceptionHandler = null);

	void BatchAddToSequences(IDictionary<string, double> entries);

	void BatchAddToSequencesInBackground(IDictionary<string, double> entries, Action<Exception> exceptionHandler = null);
}
