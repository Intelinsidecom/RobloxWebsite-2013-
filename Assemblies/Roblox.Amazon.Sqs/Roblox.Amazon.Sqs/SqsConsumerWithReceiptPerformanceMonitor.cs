using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

[ExcludeFromCodeCoverage]
internal class SqsConsumerWithReceiptPerformanceMonitor : SqsPerformanceMonitor
{
	private const string _PerformanceCategoryname = "Roblox.SqsConsumerWithReceiptBase";

	public SqsConsumerWithReceiptPerformanceMonitor(ICounterRegistry counterRegistry, string instanceName)
		: base(counterRegistry, "Roblox.SqsConsumerWithReceiptBase", instanceName)
	{
	}
}
