using System;
using System.Collections.Generic;

namespace Roblox.Instrumentation.LegacySupport;

public class SimpleCounterCategoryFactory : ISimpleCounterCategoryFactory
{
	private readonly ICounterRegistry _CounterRegistry;

	public SimpleCounterCategoryFactory(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	public ISimpleCounterCategory CreateSimpleCounterCategory(string categoryName, ICollection<string> counterNames)
	{
		return new SimpleCounterCategory(_CounterRegistry, categoryName, counterNames);
	}
}
