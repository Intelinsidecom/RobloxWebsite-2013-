using System;
using System.Diagnostics;

namespace Roblox.Diagnostics;

public class CounterDescriptorForICounter : ICounterDescriptor
{
	public Action<IPerformanceCounter> Setter { get; private set; }

	public CounterCreationData CounterCreationData { get; private set; }

	public CounterDescriptorForICounter(string counterName, Action<IPerformanceCounter> setter, PerformanceCounterType counterType, string counterHelp = "")
	{
		CounterCreationData = new CounterCreationData(counterName, counterHelp, counterType);
		Setter = setter;
	}
}
