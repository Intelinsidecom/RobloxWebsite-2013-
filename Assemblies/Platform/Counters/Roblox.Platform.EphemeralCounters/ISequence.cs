using System;

namespace Roblox.EphemeralCounters;

public interface ISequence
{
	void Add(double value);

	void AddInBackground(double value, Action<Exception> exceptionHandler = null);

	ISequenceStatistics GetStatistics();

	ISequenceStatistics FlushStatistics();
}
