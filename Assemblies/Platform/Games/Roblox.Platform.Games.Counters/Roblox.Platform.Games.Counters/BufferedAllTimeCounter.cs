using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Collections;
using Roblox.EventLog;
using Roblox.Platform.Counters;
using Roblox.Platform.Games.Counters.Properties;

namespace Roblox.Platform.Games.Counters;

internal class BufferedAllTimeCounter : BufferedCounterBase<string>
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly ILogger _Logger;

	protected override TimeSpan CommitInterval => Settings.Default.BufferedAllTimeGameCounterCommitInterval;

	public BufferedAllTimeCounter(IDurableCounterFactory durableCounterFactory, ILogger logger)
		: base(logger)
	{
		_DurableCounterFactory = durableCounterFactory;
		_Logger = logger;
	}

	protected override void Commit(IEnumerable<KeyValuePair<string, double>> committableDictionary)
	{
		try
		{
			ParallelOptions parallelOptions = new ParallelOptions
			{
				MaxDegreeOfParallelism = Settings.Default.BufferedAllTimeGameCounterCommitMaxDegreeOfParallelism
			};
			Parallel.ForEach(committableDictionary, parallelOptions, delegate(KeyValuePair<string, double> kvp)
			{
				_DurableCounterFactory.GetCounter(kvp.Key).Increment(kvp.Value);
			});
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
