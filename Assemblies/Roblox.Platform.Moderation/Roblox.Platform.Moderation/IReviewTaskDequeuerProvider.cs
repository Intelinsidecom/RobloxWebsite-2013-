using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskDequeuerProvider<out TTask> where TTask : IReviewTask
{
	/// <summary>
	/// Returns a ReviewTaskQueueTracker that is bound to the specified locale, priority, and TTask
	/// </summary>
	/// <param name="localeIdentifier">The locale of the review task queue that the dequeuer is setup to dequeue from; sending null is treated as the unknown locale</param>
	/// <param name="priority">The specific priority level of the queue to bind the dequeuer to</param>
	/// <returns></returns>
	IReviewTaskDequeuer<TTask> GetReviewTaskDequeuer(ISupportedLocaleIdentifier localeIdentifier, ModerationTaskPriority priority);
}
