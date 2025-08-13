using Roblox.Instrumentation;

namespace Roblox.Amazon.Sns;

internal class PerInstancePerformanceMonitor
{
	private static readonly byte[] _DefaultPercentiles = new byte[9] { 1, 5, 10, 25, 50, 75, 90, 95, 99 };

	internal IPercentileCounter PublishSuccessDurationPercentile { get; }

	internal IPercentileCounter PublishCancelledDurationPercentile { get; }

	internal IPercentileCounter PublishFailedDurationPercentile { get; }

	internal IPercentileCounter PublishToCompletionSuccessDurationPercentile { get; }

	internal IPercentileCounter PublishToCompletionFailureDurationPercentile { get; }

	internal IAverageValueCounter PublishSuccessDurationAverage { get; }

	internal IAverageValueCounter PublishCancelledDurationAverage { get; }

	internal IAverageValueCounter PublishFailedDurationAverage { get; }

	internal IAverageValueCounter PublishToCompletionSuccessDurationAverage { get; }

	internal IAverageValueCounter PublishToCompletionFailureDurationAverage { get; }

	internal IRateOfCountsPerSecondCounter PublishOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PublishOperationsSuccessfulPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PublishOperationsCancelledPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PublishOperationsFailedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PublishOperationsCompletelyFailedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter RetriesPerSecond { get; }

	internal IRateOfCountsPerSecondCounter SwitchToDifferentRegionPerSecond { get; }

	internal IRawValueCounter RunningSnsPublishRequests { get; }

	internal PerInstancePerformanceMonitor(ICounterRegistry counterRegistry, string totalCategoryName, string perTopicCategoryName, string instanceName)
	{
		PublishSuccessDurationPercentile = counterRegistry.GetPercentileCounter(totalCategoryName, string.Format("{0}.Percentile.{{0}}", "PublishSuccessDurationPercentile"), _DefaultPercentiles);
		PublishCancelledDurationPercentile = counterRegistry.GetPercentileCounter(totalCategoryName, string.Format("{0}.Percentile.{{0}}", "PublishCancelledDurationPercentile"), _DefaultPercentiles);
		PublishFailedDurationPercentile = counterRegistry.GetPercentileCounter(totalCategoryName, string.Format("{0}.Percentile.{{0}}", "PublishFailedDurationPercentile"), _DefaultPercentiles);
		PublishToCompletionSuccessDurationPercentile = counterRegistry.GetPercentileCounter(totalCategoryName, string.Format("{0}.Percentile.{{0}}", "PublishToCompletionSuccessDurationPercentile"), _DefaultPercentiles);
		PublishToCompletionFailureDurationPercentile = counterRegistry.GetPercentileCounter(totalCategoryName, string.Format("{0}.Percentile.{{0}}", "PublishToCompletionFailureDurationPercentile"), _DefaultPercentiles);
		PublishSuccessDurationAverage = counterRegistry.GetAverageValueCounter(totalCategoryName, "PublishSuccessDurationAverage");
		PublishCancelledDurationAverage = counterRegistry.GetAverageValueCounter(totalCategoryName, "PublishCancelledDurationAverage");
		PublishFailedDurationAverage = counterRegistry.GetAverageValueCounter(totalCategoryName, "PublishFailedDurationAverage");
		PublishToCompletionSuccessDurationAverage = counterRegistry.GetAverageValueCounter(totalCategoryName, "PublishToCompletionSuccessDurationAverage");
		PublishToCompletionFailureDurationAverage = counterRegistry.GetAverageValueCounter(totalCategoryName, "PublishToCompletionFailureDurationAverage");
		PublishOperationsSuccessfulPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(totalCategoryName, "PublishOperationsSuccessfulPerSecond");
		PublishOperationsCancelledPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(totalCategoryName, "PublishOperationsCancelledPerSecond");
		PublishOperationsFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(totalCategoryName, "PublishOperationsFailedPerSecond");
		PublishOperationsCompletelyFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(totalCategoryName, "PublishOperationsCompletelyFailedPerSecond");
		RetriesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(totalCategoryName, "RetriesPerSecond");
		SwitchToDifferentRegionPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(totalCategoryName, "SwitchToDifferentRegionPerSecond");
		RunningSnsPublishRequests = counterRegistry.GetRawValueCounter(totalCategoryName, "RunningSnsPublishRequests");
		PublishOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter(perTopicCategoryName, "PublishOperationsPerSecond", instanceName);
	}
}
