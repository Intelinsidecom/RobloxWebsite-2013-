using System;
using Roblox.TrackingQueue;

namespace Roblox.Platform.Moderation;

internal class ReviewTaskDequeuer<TTask> : IReviewTaskDequeuer<TTask> where TTask : IReviewTask
{
	private readonly IQueueTracker _QueueTracker;

	public ReviewTaskDequeuer(IQueueTracker queueTracker)
	{
		_QueueTracker = queueTracker ?? throw new ArgumentNullException("queueTracker");
	}

	public bool TryDequeueOldestItemInQueue(out string message, out TimeSpan age)
	{
		return _QueueTracker.TryDequeueOldestItemInQueue(out message, out age);
	}
}
