using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Collections;
using Roblox.EventLog;

namespace Roblox.EphemeralCounters;

public abstract class BufferedEphemeralCounterBase : BufferedCounterBase<string>
{
	private readonly ILogger _Logger;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	protected virtual int MaxDegreeOfParallelism { get; set; }

	protected BufferedEphemeralCounterBase(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(logger)
	{
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_Logger = logger;
	}

	protected override void Commit(IEnumerable<KeyValuePair<string, double>> committableDictionary)
	{
		try
		{
			ParallelOptions parallelOptions = new ParallelOptions
			{
				MaxDegreeOfParallelism = MaxDegreeOfParallelism
			};
			Parallel.ForEach(committableDictionary, parallelOptions, delegate(KeyValuePair<string, double> kvp)
			{
				_EphemeralCounterFactory.GetCounter(kvp.Key).Increment((int)kvp.Value);
			});
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
