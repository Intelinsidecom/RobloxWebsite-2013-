using System.Linq;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// If you modify this, also modify RP.Observation.Custom.SqsPerformanceDatasetCollector,
/// which is in charge of charting them.
/// </summary>
internal class PerInstancePerformanceMonitor
{
	internal IRateOfCountsPerSecondCounter BatchDeletesSuccessfulPerSecond { get; }

	internal IRateOfCountsPerSecondCounter BatchDeletesCancelledPerSecond { get; }

	internal IRateOfCountsPerSecondCounter BatchDeletesFailedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter MessagesFetchedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter MessagesThrottledPerSecond { get; }

	internal IRateOfCountsPerSecondCounter MessagesProcessedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter MessagesDeletedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ProcessMessageFailuresPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ConsumersCreatedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ConsumersDestroyedPerSecond { get; }

	internal IRawValueCounter TotalConsumersRunning { get; }

	internal IRawValueCounter MessagesBeingProcessed { get; }

	internal IAverageValueCounter ProcessMessageDurationAverage { get; }

	internal IAverageValueCounter BatchDeleteDurationAverage { get; }

	internal IAverageValueCounter FetchMessagesDurationAverage { get; }

	internal IPercentileCounter ProcessMessageDurationPercentile { get; }

	internal IPercentileCounter BatchDeleteDurationPercentile { get; }

	internal IPercentileCounter FetchMessagesDurationPercentile { get; }

	protected PerInstancePerformanceMonitor(ICounterRegistry counterRegistry, string categoryName, string instanceName)
	{
		BatchDeletesSuccessfulPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "BatchDeletesSuccessfulPerSecond", instanceName);
		BatchDeletesCancelledPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "BatchDeletesCancelledPerSecond", instanceName);
		BatchDeletesFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "BatchDeletesFailedPerSecond", instanceName);
		MessagesFetchedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "MessagesFetchedPerSecond", instanceName);
		MessagesThrottledPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "MessagesThrottledPerSecond", instanceName);
		MessagesProcessedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "MessagesProcessedPerSecond", instanceName);
		MessagesDeletedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "MessagesDeletedPerSecond", instanceName);
		ProcessMessageFailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "ProcessMessageFailuresPerSecond", instanceName);
		ConsumersCreatedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "ConsumersCreatedPerSecond", instanceName);
		ConsumersDestroyedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(categoryName, "ConsumersDestroyedPerSecond", instanceName);
		TotalConsumersRunning = counterRegistry.GetRawValueCounter(categoryName, "TotalConsumersRunning", instanceName);
		MessagesBeingProcessed = counterRegistry.GetRawValueCounter(categoryName, "MessagesBeingProcessed", instanceName);
		ProcessMessageDurationAverage = counterRegistry.GetAverageValueCounter(categoryName, "ProcessMessageDurationAverage", instanceName);
		BatchDeleteDurationAverage = counterRegistry.GetAverageValueCounter(categoryName, "BatchDeleteDurationAverage", instanceName);
		FetchMessagesDurationAverage = counterRegistry.GetAverageValueCounter(categoryName, "FetchMessagesDurationAverage", instanceName);
		byte[] percentiles = counterRegistry.GetDefaultPercentiles().ToArray();
		ProcessMessageDurationPercentile = counterRegistry.GetPercentileCounter(categoryName, "ProcessMessageDurationPercentile", $"{instanceName}.Percentile.{{0}}", percentiles);
		BatchDeleteDurationPercentile = counterRegistry.GetPercentileCounter(categoryName, "BatchDeleteDurationPercentile", $"{instanceName}.Percentile.{{0}}", percentiles);
		FetchMessagesDurationPercentile = counterRegistry.GetPercentileCounter(categoryName, "FetchMessagesDurationPercentile", $"{instanceName}.Percentile.{{0}}", percentiles);
	}
}
