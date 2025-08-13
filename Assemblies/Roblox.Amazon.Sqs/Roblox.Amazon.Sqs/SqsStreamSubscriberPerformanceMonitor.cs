using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

internal class SqsStreamSubscriberPerformanceMonitor : SqsPerformanceMonitor
{
	private const string _PerformanceCategoryname = "Roblox.SqsStreamSubscriberBaseV4";

	public SqsStreamSubscriberPerformanceMonitor(ICounterRegistry counterRegistry, string instanceName)
		: base(counterRegistry, "Roblox.SqsStreamSubscriberBaseV4", instanceName)
	{
	}
}
