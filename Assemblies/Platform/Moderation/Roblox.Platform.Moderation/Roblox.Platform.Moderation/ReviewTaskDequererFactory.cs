using System;
using Roblox.TrackingQueue;

namespace Roblox.Platform.Moderation;

public class ReviewTaskDequererFactory : IReviewTaskDequeuerFactory
{
	private readonly IQueueTrackerFactory _QueueTrackerFactory;

	public ReviewTaskDequererFactory(IQueueTrackerFactory queueTrackerFactory)
	{
		_QueueTrackerFactory = queueTrackerFactory ?? throw new ArgumentNullException("queueTrackerFactory");
	}

	public IReviewTaskDequeuer<TTask> Create<TTask>(string trackingKey) where TTask : IReviewTask
	{
		if (string.IsNullOrEmpty(trackingKey))
		{
			throw new ArgumentException("trackingKey must not be null or empty", "trackingKey");
		}
		return new ReviewTaskDequeuer<TTask>(_QueueTrackerFactory.Create(trackingKey));
	}
}
