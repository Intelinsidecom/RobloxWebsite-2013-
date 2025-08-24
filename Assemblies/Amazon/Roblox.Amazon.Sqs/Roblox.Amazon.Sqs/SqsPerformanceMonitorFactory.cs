using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

[ExcludeFromCodeCoverage]
internal class SqsPerformanceMonitorFactory : ISqsPerformanceMonitorFactory
{
	public ISqsPerformanceMonitor GetRegionSqsConsumerWithReceiptPerformanceMonitor(ICounterRegistry counterRegistry, string performanceMonitorCategory, string systemName)
	{
		string regionPerfmonInstanceName = $"{performanceMonitorCategory}.{systemName}";
		return new SqsConsumerWithReceiptPerformanceMonitor(counterRegistry, regionPerfmonInstanceName);
	}
}
