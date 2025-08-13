using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Collections;
using Roblox.EventLog;
using Roblox.Platform.Counters.Properties;

namespace Roblox.Platform.Counters;

public sealed class ImpressionsCounter : BufferedCounterBase<Item>
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly Action<Exception> _ExceptionHandler;

	public static Action<Item> ImpressionIncrementEvent;

	private const string ImpressionTargetType = "Impression";

	protected override TimeSpan CommitInterval => Settings.Default.ImpressionsCounterCommitInterval;

	public ImpressionsCounter(IDurableCounterFactory durableCounterFactory, ILogger logger, Action<Exception> exceptionHandler = null)
		: base(logger)
	{
		_DurableCounterFactory = durableCounterFactory;
		_ExceptionHandler = exceptionHandler;
	}

	public double GetCount(Item item, Frequency frequency)
	{
		return GetImpressionCounter(item).GetCount(frequency);
	}

	protected override void Commit(IEnumerable<KeyValuePair<Item, double>> committableDictionary)
	{
		try
		{
			Parallel.ForEach(committableDictionary, delegate(KeyValuePair<Item, double> imp)
			{
				GetImpressionCounter(imp.Key).Increment(DateTime.UtcNow, imp.Value);
				ImpressionIncrementEvent(imp.Key);
			});
		}
		catch (AggregateException ex)
		{
			try
			{
				_ExceptionHandler?.Invoke(ex.InnerException);
			}
			catch
			{
			}
		}
	}

	private ITimeBucketedCounter GetImpressionCounter(Item item)
	{
		return _DurableCounterFactory.GetTimeBucketedCounter(CounterType.Hourly, "Impression", item.Type.ToString(), item.TargetId);
	}
}
