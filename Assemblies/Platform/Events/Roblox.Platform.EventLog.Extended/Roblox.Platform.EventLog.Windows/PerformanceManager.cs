using System.Diagnostics;
using Roblox.Diagnostics;

namespace Roblox.EventLog.Windows;

internal class PerformanceManager
{
	private const string _PeformanceCategory = "Roblox.EventLog.Metrics";

	public PerformanceCounter ErrorsLoggedPerSecond { get; set; }

	public PerformanceCounter WarningsLoggedPerSecond { get; set; }

	public PerformanceCounter InformationLoggedPerSecond { get; set; }

	public PerformanceCounter TrimmedEventsLoggedPerSecond { get; set; }

	public PerformanceManager(string logName)
	{
		CounterDescriptor[] counters = new CounterDescriptor[4]
		{
			new CounterDescriptor(() => ErrorsLoggedPerSecond, delegate(PerformanceCounter v)
			{
				ErrorsLoggedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32, "Errors logged per second to event log"),
			new CounterDescriptor(() => WarningsLoggedPerSecond, delegate(PerformanceCounter v)
			{
				WarningsLoggedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32, "Warnings logged per second to event log"),
			new CounterDescriptor(() => InformationLoggedPerSecond, delegate(PerformanceCounter v)
			{
				InformationLoggedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32, "Information logged per second to event log"),
			new CounterDescriptor(() => TrimmedEventsLoggedPerSecond, delegate(PerformanceCounter v)
			{
				TrimmedEventsLoggedPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32, "Event logs per second that needed to be trimmed")
		};
		CounterCreator.InitializeMultiInstance("Roblox.EventLog.Metrics", logName, counters);
	}
}
