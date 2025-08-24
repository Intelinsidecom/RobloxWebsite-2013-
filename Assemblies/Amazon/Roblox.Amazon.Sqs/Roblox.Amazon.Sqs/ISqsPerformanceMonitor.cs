namespace Roblox.Amazon.Sqs;

internal interface ISqsPerformanceMonitor
{
	void LogParallelismIncreasedBy(int amountOfParallelism);

	void LogParallelismDecreasedBy(int amountOfParallelism);

	void LogStop();

	void LogSetCurrentThreads(int numberOfThreads);

	void LogThreadsIncreased(int numberOfThreads);

	void LogThreadsDecreased(int numberOfThreads);

	void LogSuccessfulBatchDelete(long deleteMs, int deleteCount);

	void LogCancelledBatchDelete();

	void LogFailedBatchDelete();

	void LogSuccessfulFetchMessages(long fetchMs, int count);

	void LogMessageProcessingStart();

	void LogMessageThrottled();

	void LogMessageProcessSuccess(long processMs);

	void LogMessageProcessSuccess();

	void LogMessageProcessFailure(long processMs);
}
