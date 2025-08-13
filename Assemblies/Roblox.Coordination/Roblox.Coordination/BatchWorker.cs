using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Roblox.Coordination;

public abstract class BatchWorker : BackgroundWorker
{
	protected readonly int MaxMessagesPerBatchRequest;

	protected readonly int MaxTimeoutPerMessage;

	private readonly BlockingCollection<string> _WorkQueue = new BlockingCollection<string>();

	public event Action<ICollection<string>> BatchCompleted;

	public event Action<Exception> ExceptionOccured;

	protected BatchWorker(int maxMessagesPerBatchRequest = 10, int maxTimeoutPerMessage = 100)
	{
		MaxMessagesPerBatchRequest = maxMessagesPerBatchRequest;
		MaxTimeoutPerMessage = maxTimeoutPerMessage;
	}

	protected abstract void ProcessBatchAsync(List<string> batchedItems, Action<ICollection<string>> batchCompletedCallback, Action<Exception> exceptionHandler);

	protected override void DoWork()
	{
		List<string> batchedItems = new List<string>(MaxMessagesPerBatchRequest);
		for (int i = 0; i < MaxMessagesPerBatchRequest; i++)
		{
			if (!_WorkQueue.TryTake(out var workItem, MaxTimeoutPerMessage))
			{
				break;
			}
			batchedItems.Add(workItem);
		}
		if (batchedItems.Count != 0)
		{
			try
			{
				ProcessBatchAsync(batchedItems, this.BatchCompleted, this.ExceptionOccured);
			}
			catch (Exception e)
			{
				this.ExceptionOccured?.Invoke(e);
			}
		}
	}

	protected void EnqueueWork(string work)
	{
		if (!base.IsRunning)
		{
			Start();
		}
		_WorkQueue.Add(work);
	}
}
