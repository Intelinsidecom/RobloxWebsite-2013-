using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskPublisher<in TTask> where TTask : IReviewTask
{
	void Publish(TTask task, ISupportedLocaleIdentifier supportedLocaleIdentifier, ModerationTaskPriority priority);
}
