using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

internal interface ISqsPerformanceMonitorFactory
{
	ISqsPerformanceMonitor GetRegionSqsConsumerWithReceiptPerformanceMonitor(ICounterRegistry counterRegistry, string performanceMonitorCategory, string systemName);
}
