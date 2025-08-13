using System;
using Roblox.EphemeralCounters.Client;

namespace Roblox.EphemeralCounters;

internal class Sequence : ISequence
{
	private readonly EphemeralCountersClient _Client;

	private readonly string _SequenceName;

	public Sequence(EphemeralCountersClient client, string sequenceName)
	{
		_Client = client;
		_SequenceName = sequenceName;
	}

	public void Add(double value)
	{
		_Client.AddToSequence(_SequenceName, value);
	}

	public void AddInBackground(double value, Action<Exception> exceptionHandler = null)
	{
		BackgroundWorker.RunInBackground(delegate
		{
			Add(value);
		}, exceptionHandler);
	}

	public ISequenceStatistics GetStatistics()
	{
		return new SequenceStatistics(_Client.GetSequenceStatistics(_SequenceName));
	}

	public ISequenceStatistics FlushStatistics()
	{
		return new SequenceStatistics(_Client.FlushSequenceStatistics(_SequenceName));
	}
}
