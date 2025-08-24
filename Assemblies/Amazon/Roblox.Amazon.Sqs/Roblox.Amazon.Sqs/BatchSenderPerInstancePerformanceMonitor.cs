using System;
using System.Linq;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

internal class BatchSenderPerInstancePerformanceMonitor
{
	private const string _PerformanceCategoryName = "Roblox.SqsBatchSenderBaseV1";

	private string _InstanceName;

	internal IRawValueCounter TotalSendersRunning { get; }

	internal IRateOfCountsPerSecondCounter BatchesSentPerSecond { get; }

	internal IRateOfCountsPerSecondCounter BatchedMessagesSentPerSecond { get; }

	internal IRateOfCountsPerSecondCounter BatchesFailedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter BatchedMessagesFailedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter MessagesAddedToBatchPerSecond { get; }

	internal IRateOfCountsPerSecondCounter SwitchesToBackupSqsClientPerSecond { get; }

	internal IAverageValueCounter BatchSendDurationAverage { get; }

	internal IAverageValueCounter BatchFailedDurationAverage { get; }

	internal IPercentileCounter BatchSendDurationPercentile { get; }

	public BatchSenderPerInstancePerformanceMonitor(ICounterRegistry counterRegistry, string instanceName)
	{
		if (string.IsNullOrWhiteSpace(instanceName))
		{
			throw new ArgumentNullException("instanceName");
		}
		_InstanceName = instanceName;
		TotalSendersRunning = counterRegistry.GetRawValueCounter("Roblox.SqsBatchSenderBaseV1", "TotalSendersRunning", _InstanceName);
		BatchesSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "BatchesSentPerSecond", _InstanceName);
		BatchedMessagesSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "BatchedMessagesSentPerSecond", _InstanceName);
		BatchesFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "BatchesFailedPerSecond", _InstanceName);
		BatchedMessagesFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "BatchedMessagesFailedPerSecond", _InstanceName);
		BatchesFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "BatchesFailedPerSecond", _InstanceName);
		MessagesAddedToBatchPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "MessagesAddedToBatchPerSecond", _InstanceName);
		SwitchesToBackupSqsClientPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.SqsBatchSenderBaseV1", "SwitchesToBackupSqsClientPerSecond", _InstanceName);
		BatchSendDurationAverage = counterRegistry.GetAverageValueCounter("Roblox.SqsBatchSenderBaseV1", "BatchSendDurationAverage", _InstanceName);
		BatchFailedDurationAverage = counterRegistry.GetAverageValueCounter("Roblox.SqsBatchSenderBaseV1", "BatchFailedDurationAverage", _InstanceName);
		BatchSendDurationPercentile = counterRegistry.GetPercentileCounter("Roblox.SqsBatchSenderBaseV1", "BatchSendDurationPercentile", _InstanceName, counterRegistry.GetDefaultPercentiles().ToArray());
	}

	public void LogSendMessage()
	{
		MessagesAddedToBatchPerSecond.Increment();
	}

	internal void LogBatchSenderCreated()
	{
		TotalSendersRunning.Increment();
	}

	internal void LogBatchSenderDestroyed()
	{
		TotalSendersRunning.Decrement();
	}

	internal void LogBatchSent(long sendTimeMilliseconds, int count)
	{
		BatchesSentPerSecond.Increment();
		BatchedMessagesSentPerSecond.IncrementBy(count);
		BatchSendDurationAverage.Sample(sendTimeMilliseconds);
		BatchSendDurationPercentile.Sample(sendTimeMilliseconds);
	}

	internal void LogBatchFailed(long sendTimeMilliseconds, int count)
	{
		BatchesFailedPerSecond.Increment();
		BatchFailedDurationAverage.Sample(sendTimeMilliseconds);
		BatchedMessagesFailedPerSecond.IncrementBy(count);
	}

	internal void LogSwitchToBackupSqsClient()
	{
		SwitchesToBackupSqsClientPerSecond.Increment();
	}
}
