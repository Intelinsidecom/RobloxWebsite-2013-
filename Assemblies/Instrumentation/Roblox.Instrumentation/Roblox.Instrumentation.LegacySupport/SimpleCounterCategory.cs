using System;
using System.Collections.Generic;

namespace Roblox.Instrumentation.LegacySupport;

internal class SimpleCounterCategory : ISimpleCounterCategory
{
	private const string _TotalInstanceName = "_Total";

	private readonly string _CategoryName;

	private readonly ICounterRegistry _CounterRegistry;

	internal SimpleCounterCategory(ICounterRegistry counterRegistry, string categoryName, ICollection<string> counterNames)
	{
		if (counterNames == null || counterNames.Count == 0)
		{
			throw new NoCountersSpecifiedForCategoryException(categoryName);
		}
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_CategoryName = categoryName ?? throw new ArgumentNullException("categoryName");
	}

	public void IncrementTotal(string counterName)
	{
		IncrementInstance(counterName, "_Total");
	}

	public void IncrementInstance(string counterName, string instanceName)
	{
		_CounterRegistry.GetRateOfCountsPerSecondCounter(_CategoryName, counterName, instanceName).Increment();
	}

	public void IncrementTotalAndInstance(string counterName, string instanceName)
	{
		IncrementTotal(counterName);
		IncrementInstance(counterName, instanceName);
	}
}
