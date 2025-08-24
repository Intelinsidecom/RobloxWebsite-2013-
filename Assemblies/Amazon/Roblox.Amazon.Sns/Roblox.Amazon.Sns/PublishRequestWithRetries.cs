using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Amazon.SimpleNotificationService.Model;

namespace Roblox.Amazon.Sns;

public class PublishRequestWithRetries
{
	/// <summary>
	/// All instances of this class manipulate this shared value, and update the related performance counter.
	/// </summary>
	private static int _RunningSnsPublishRequestCount;

	internal PerInstancePerformanceMonitor TotalPerformanceMonitor;

	public string Message { get; }

	internal Queue<SnsRegionPublisher> BackupSnsRegionPublishers { get; }

	internal Stopwatch TotalTimer { get; }

	internal SnsRegionPublisher SnsRegionPublisher { get; set; }

	internal int TotalNumberOfAttemptsLeft { get; set; }

	internal PublishRequestWithRetries(string message, SnsRegionPublisher snsClient, Queue<SnsRegionPublisher> backupSnsClients, int numberOfRetries, PerInstancePerformanceMonitor totalPerformanceMonitor)
	{
		Message = message;
		SnsRegionPublisher = snsClient;
		BackupSnsRegionPublishers = backupSnsClients;
		TotalNumberOfAttemptsLeft = numberOfRetries;
		TotalPerformanceMonitor = totalPerformanceMonitor;
		TotalTimer = new Stopwatch();
		TotalTimer.Start();
	}

	internal Task PublishAsync(PublishRequest publishRequest, CancellationToken ct)
	{
		SafelyModifyRunningRequestCountBy(1);
		TotalPerformanceMonitor.PublishOperationsPerSecond.Increment();
		return SnsRegionPublisher.SnsClient.PublishAsync(publishRequest, ct);
	}

	internal void CleanUpRunningRequestsCount()
	{
		SafelyModifyRunningRequestCountBy(-1);
	}

	internal void LogSuccessfulPublish(long durationInMilliseconds, long publishToCompletionDurationInMilliseconds)
	{
		TotalPerformanceMonitor.PublishOperationsSuccessfulPerSecond.Increment();
		TotalPerformanceMonitor.PublishSuccessDurationPercentile.Sample(durationInMilliseconds);
		TotalPerformanceMonitor.PublishSuccessDurationAverage.Sample(durationInMilliseconds);
		TotalPerformanceMonitor.PublishToCompletionSuccessDurationPercentile.Sample(publishToCompletionDurationInMilliseconds);
		TotalPerformanceMonitor.PublishToCompletionSuccessDurationAverage.Sample(publishToCompletionDurationInMilliseconds);
	}

	internal void LogCancelledRequest(long durationInMilliseconds)
	{
		TotalPerformanceMonitor.PublishOperationsCancelledPerSecond.Increment();
		TotalPerformanceMonitor.PublishCancelledDurationPercentile.Sample(durationInMilliseconds);
		TotalPerformanceMonitor.PublishCancelledDurationAverage.Sample(durationInMilliseconds);
	}

	internal void LogFailedRequest(long durationInMilliseconds)
	{
		TotalPerformanceMonitor.PublishOperationsFailedPerSecond.Increment();
		TotalPerformanceMonitor.PublishFailedDurationPercentile.Sample(durationInMilliseconds);
		TotalPerformanceMonitor.PublishFailedDurationAverage.Sample(durationInMilliseconds);
	}

	internal void LogRepublishRequest()
	{
		TotalPerformanceMonitor.RetriesPerSecond.Increment();
	}

	internal void LogSwitchToDifferentRegion()
	{
		TotalPerformanceMonitor.SwitchToDifferentRegionPerSecond.Increment();
	}

	internal void LogCompletePublishFailure(long durationInMilliseconds)
	{
		TotalPerformanceMonitor.PublishOperationsCompletelyFailedPerSecond.Increment();
		TotalPerformanceMonitor.PublishToCompletionFailureDurationPercentile.Sample(durationInMilliseconds);
		TotalPerformanceMonitor.PublishToCompletionFailureDurationAverage.Sample(durationInMilliseconds);
	}

	/// <summary>
	/// This is necessary to prevent performance counters from overflowing when decremented below zero.
	/// There is a potential issue where currentValue becomes very negative (if somehow we have extra decrements)
	/// TODO: Add logging to at least detect this case.
	/// </summary>
	private void SafelyModifyRunningRequestCountBy(int amount)
	{
		int currentValue = Interlocked.Add(ref _RunningSnsPublishRequestCount, amount);
		TotalPerformanceMonitor.RunningSnsPublishRequests.Set(Math.Max(0, currentValue));
	}
}
