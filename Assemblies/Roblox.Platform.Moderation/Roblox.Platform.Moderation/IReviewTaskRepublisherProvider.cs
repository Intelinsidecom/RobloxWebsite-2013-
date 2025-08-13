using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskRepublisherProvider<out TTask> where TTask : IReviewTask
{
	/// <summary>
	/// Returns a IReviewTaskRepublisher of the appropriate task type.
	/// </summary>
	/// <param name="localeIdentifier">The locale of the review task queue that the republisher should use; sending null is treated as the unknown locale.</param>
	/// <param name="priority">The specific priority level of the queue to bind the republisher to</param>
	/// <returns></returns>
	IReviewTaskRepublisher<TTask> GetReviewTaskRepublisher(ISupportedLocaleIdentifier localeIdentifier, ModerationTaskPriority priority);
}
