using Roblox.Instrumentation;

namespace Roblox.Amazon.Sqs;

internal abstract class SqsPerformanceMonitor : PerInstancePerformanceMonitor, ISqsPerformanceMonitor
{
	protected SqsPerformanceMonitor(ICounterRegistry counterRegistry, string performanceCategoryname, string instanceName)
		: base(counterRegistry, performanceCategoryname, instanceName)
	{
	}

	public void LogParallelismDecreasedBy(int amountOfParallelismChange)
	{
		base.ConsumersDestroyedPerSecond.IncrementBy(amountOfParallelismChange);
		if (base.TotalConsumersRunning.RawValue < amountOfParallelismChange)
		{
			base.TotalConsumersRunning.Set(0L);
		}
		else
		{
			base.TotalConsumersRunning.IncrementBy(-amountOfParallelismChange);
		}
	}

	public void LogParallelismIncreasedBy(int amountOfParallelismChange)
	{
		base.ConsumersCreatedPerSecond.IncrementBy(amountOfParallelismChange);
		base.TotalConsumersRunning.IncrementBy(amountOfParallelismChange);
	}

	public void LogStop()
	{
		base.TotalConsumersRunning.Set(0L);
	}

	public void LogSetCurrentThreads(int numberOfThreads)
	{
		base.TotalConsumersRunning.Set(numberOfThreads);
	}

	public void LogThreadsIncreased(int numberOfThreads)
	{
		base.TotalConsumersRunning.IncrementBy(numberOfThreads);
	}

	public void LogThreadsDecreased(int numberOfThreads)
	{
		if (base.TotalConsumersRunning.RawValue < numberOfThreads)
		{
			base.TotalConsumersRunning.Set(0L);
		}
		else
		{
			base.TotalConsumersRunning.IncrementBy(-1 * numberOfThreads);
		}
	}

	public void LogSuccessfulBatchDelete(long deleteMs, int deleteCount)
	{
		base.BatchDeletesSuccessfulPerSecond.Increment();
		base.MessagesDeletedPerSecond.IncrementBy(deleteCount);
		base.BatchDeleteDurationAverage.Sample(deleteMs);
		base.BatchDeleteDurationPercentile.Sample(deleteMs);
	}

	public void LogCancelledBatchDelete()
	{
		base.BatchDeletesCancelledPerSecond.Increment();
	}

	public void LogFailedBatchDelete()
	{
		base.BatchDeletesFailedPerSecond.Increment();
	}

	public void LogSuccessfulFetchMessages(long fetchMs, int count)
	{
		base.MessagesFetchedPerSecond.IncrementBy(count);
		base.FetchMessagesDurationAverage.Sample(fetchMs);
		base.FetchMessagesDurationPercentile.Sample(fetchMs);
	}

	public void LogMessageProcessingStart()
	{
		base.MessagesBeingProcessed.Increment();
	}

	public void LogMessageThrottled()
	{
		base.MessagesThrottledPerSecond.Increment();
	}

	public void LogMessageProcessSuccess(long processMs)
	{
		base.MessagesProcessedPerSecond.Increment();
		base.ProcessMessageDurationAverage.Sample(processMs);
		base.ProcessMessageDurationPercentile.Sample(processMs);
		base.MessagesBeingProcessed.Decrement();
	}

	public void LogMessageProcessFailure(long processMs)
	{
		base.ProcessMessageFailuresPerSecond.Increment();
		base.ProcessMessageDurationAverage.Sample(processMs);
		base.ProcessMessageDurationPercentile.Sample(processMs);
		base.MessagesBeingProcessed.Decrement();
	}

	/// <summary>
	/// Called when a message is deleted.
	/// </summary>
	public void LogMessageProcessSuccess()
	{
		base.MessagesProcessedPerSecond.Increment();
		base.MessagesBeingProcessed.Decrement();
	}
}
