using System;
namespace Roblox.Moderationpublic {
    interface IReviewTaskDequeuer<out TTask> where TTask : IReviewTask

{
	bool TryDequeueOldestItemInQueue(out string message, out TimeSpan age);
}


}
