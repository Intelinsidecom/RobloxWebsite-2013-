using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Collections;
using Roblox.EventLog;
using Roblox.Platform.Counters.Properties;

namespace Roblox.Platform.Counters;

public sealed class PointsCounter : BufferedCounterBase<Tuple<long, long>>
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly Action<Exception> _ExceptionHandler;

	private readonly Func<string> _PointsTimeBucketedCounterPrefixGetter;

	protected override TimeSpan CommitInterval => Settings.Default.PointsCounterCommitInterval;

	public PointsCounter(IDurableCounterFactory durableCounterFactory, Func<string> counterPrefixGetter, ILogger logger, Action<Exception> exceptionHandler = null)
		: base(logger)
	{
		_DurableCounterFactory = durableCounterFactory;
		_PointsTimeBucketedCounterPrefixGetter = counterPrefixGetter;
		_ExceptionHandler = exceptionHandler;
	}

	protected override void Commit(IEnumerable<KeyValuePair<Tuple<long, long>, double>> committableDictionary)
	{
		try
		{
			Parallel.ForEach(committableDictionary, delegate(KeyValuePair<Tuple<long, long>, double> imp)
			{
				GetPointsCounter(imp.Key.Item1, imp.Key.Item2).Increment(DateTime.UtcNow, imp.Value);
			});
		}
		catch (AggregateException ex)
		{
			try
			{
				if (_ExceptionHandler != null)
				{
					_ExceptionHandler(ex.InnerException);
				}
			}
			catch
			{
			}
		}
	}

	private ITimeBucketedCounter GetPointsCounter(long recipientId, long distributorId)
	{
		return _DurableCounterFactory.GetTimeBucketedCounter(_PointsTimeBucketedCounterPrefixGetter() + "_", recipientId.ToString(), distributorId);
	}
}
