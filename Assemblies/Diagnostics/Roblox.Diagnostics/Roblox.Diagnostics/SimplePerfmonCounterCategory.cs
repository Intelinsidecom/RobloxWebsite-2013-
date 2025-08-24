using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Roblox.Diagnostics;

internal class SimplePerfmonCounterCategory : ISimpleCounterCategory
{
	internal const string _TotalInstanceName = "_Total";

	private readonly string _CategoryName;

	private readonly Action<string, string, CounterDescriptorForICounter[]> _MultiInstanceCounterCategoryInitializer;

	private readonly object _CounterCreationLock = new object();

	private readonly Dictionary<string, Dictionary<string, IPerformanceCounter>> _CounterMultiInstanceLookup = new Dictionary<string, Dictionary<string, IPerformanceCounter>>();

	public SimplePerfmonCounterCategory(string categoryName, ICollection<string> counterNames)
		: this(categoryName, counterNames, CounterCreator.InitializeMultiInstance)
	{
	}

	internal SimplePerfmonCounterCategory(string categoryName, ICollection<string> counterNames, Action<string, string, CounterDescriptorForICounter[]> multiInstanceCounterCategoryInitializer)
	{
		if (counterNames == null || counterNames.Count == 0)
		{
			throw new NoCountersSpecifiedForCategoryException(categoryName);
		}
		_CategoryName = categoryName;
		_MultiInstanceCounterCategoryInitializer = multiInstanceCounterCategoryInitializer;
		CounterDescriptorForICounter[] descriptorCollection = counterNames.Select((string counter) => new CounterDescriptorForICounter(counter, delegate(IPerformanceCounter v)
		{
			_CounterMultiInstanceLookup.Add(counter, new Dictionary<string, IPerformanceCounter> { { "_Total", v } });
		}, PerformanceCounterType.RateOfCountsPerSecond32)).ToArray();
		_MultiInstanceCounterCategoryInitializer(categoryName, "_Total", descriptorCollection);
	}

	public void IncrementTotal(string counterName)
	{
		IncrementInstance(counterName, "_Total");
	}

	public void IncrementInstance(string counterName, string instanceName)
	{
		GetCounter(counterName, instanceName).Increment();
	}

	public void IncrementTotalAndInstance(string counterName, string instanceName)
	{
		IncrementTotal(counterName);
		IncrementInstance(counterName, instanceName);
	}

	private IPerformanceCounter GetCounter(string counterName, string instanceName)
	{
		if (!_CounterMultiInstanceLookup.ContainsKey(counterName))
		{
			throw new UnknownCounterException();
		}
		if (_CounterMultiInstanceLookup[counterName].TryGetValue(instanceName, out var notificationTypeCounter))
		{
			return notificationTypeCounter;
		}
		lock (_CounterCreationLock)
		{
			if (_CounterMultiInstanceLookup[counterName].TryGetValue(instanceName, out notificationTypeCounter))
			{
				return notificationTypeCounter;
			}
			CounterDescriptorForICounter[] collection = new CounterDescriptorForICounter[1]
			{
				new CounterDescriptorForICounter(counterName, delegate(IPerformanceCounter v)
				{
					notificationTypeCounter = v;
				}, PerformanceCounterType.RateOfCountsPerSecond32)
			};
			_MultiInstanceCounterCategoryInitializer(_CategoryName, instanceName, collection);
			_CounterMultiInstanceLookup[counterName].Add(instanceName, notificationTypeCounter);
			return notificationTypeCounter;
		}
	}
}
