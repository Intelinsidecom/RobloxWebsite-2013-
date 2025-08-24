using System;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskDequeuer<out TTask> where TTask : IReviewTask
{
	bool TryDequeueOldestItemInQueue(out string message, out TimeSpan age);
}
