using System.Diagnostics;
using Roblox.Diagnostics;

namespace Roblox.Platform.Counters;

internal class PerformanceCollector
{
	public PerformanceCounter NumberOfTimeBucketedCounterReferences;

	public PerformanceCounter NumberOfCounterReferences;

	public PerformanceCollector(string performanceCategory)
	{
		CounterDescriptor[] counters = new CounterDescriptor[2]
		{
			new CounterDescriptor(() => NumberOfTimeBucketedCounterReferences, delegate(PerformanceCounter v)
			{
				NumberOfTimeBucketedCounterReferences = v;
			}, PerformanceCounterType.NumberOfItems64),
			new CounterDescriptor(() => NumberOfCounterReferences, delegate(PerformanceCounter v)
			{
				NumberOfCounterReferences = v;
			}, PerformanceCounterType.NumberOfItems64)
		};
		CounterCreator.InitializeSingleInstance(performanceCategory, counters);
	}
}
