using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.Instrumentation;
using Roblox.Instrumentation.LegacySupport;

namespace Roblox.Diagnostics;

internal class SimplePerfmonCounterCategory : ISimpleCounterCategory
{
    private readonly Roblox.Instrumentation.LegacySupport.ISimpleCounterCategory _inner;

    public SimplePerfmonCounterCategory(string categoryName, ICollection<string> counterNames)
    {
        if (counterNames == null || counterNames.Count == 0)
        {
            throw new NoCountersSpecifiedForCategoryException(categoryName);
        }
        var factory = new Roblox.Instrumentation.LegacySupport.SimpleCounterCategoryFactory(StaticCounterRegistry.Instance);
        _inner = factory.CreateSimpleCounterCategory(categoryName, counterNames);
    }

    public void IncrementTotal(string counterName)
    {
        _inner.IncrementTotal(counterName);
    }

    public void IncrementInstance(string counterName, string instanceName)
    {
        _inner.IncrementInstance(counterName, instanceName);
    }

    public void IncrementTotalAndInstance(string counterName, string instanceName)
    {
        _inner.IncrementTotalAndInstance(counterName, instanceName);
    }
}
