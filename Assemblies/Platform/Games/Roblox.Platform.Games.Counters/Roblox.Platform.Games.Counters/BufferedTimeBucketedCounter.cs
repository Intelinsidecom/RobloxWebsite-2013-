using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Collections;
using Roblox.EventLog;
using Roblox.Platform.Counters;
using Roblox.Platform.Games.Counters.Properties;

namespace Roblox.Platform.Games.Counters;

internal class BufferedTimeBucketedCounter : BufferedCounterBase<Tuple<string, DateTime>>
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly ILogger _Logger;

	protected override TimeSpan CommitInterval => Settings.Default.BufferedTimeBucketedGameCounterCommitInterval;

	public BufferedTimeBucketedCounter(IDurableCounterFactory durableCounterFactory, ILogger logger)
		: base(logger)
	{
		_DurableCounterFactory = durableCounterFactory;
		_Logger = logger;
	}

	public void Increment(ITimeBucketedCounter counter, DateTime incrementTime, double amount = 1.0)
	{
		Tuple<string, DateTime> key = new Tuple<string, DateTime>(counter.GetKey(), incrementTime);
		Increment(key, amount);
	}

	protected override void Commit(IEnumerable<KeyValuePair<Tuple<string, DateTime>, double>> committableDictionary)
	{
		try
		{
			ParallelOptions parallelOptions = new ParallelOptions
			{
				MaxDegreeOfParallelism = Settings.Default.BufferedTimeBucketedGameCounterCommitMaxDegreeOfParallelism
			};
			Parallel.ForEach(committableDictionary, parallelOptions, delegate(KeyValuePair<Tuple<string, DateTime>, double> kvp)
			{
				ITimeBucketedCounter timeBucketedCounter = _DurableCounterFactory.GetTimeBucketedCounter(kvp.Key.Item1);
				DateTime item = kvp.Key.Item2;
				timeBucketedCounter.Increment(item, kvp.Value);
			});
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
