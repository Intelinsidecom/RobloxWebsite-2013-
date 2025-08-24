using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

public interface IReviewTaskRepublisherFactory
{
	IReviewTaskRepublisher<TTask> Create<TTask>(IReviewTaskFactory<TTask> reviewTaskFactory, IReviewTaskPublisher<TTask> reviewTaskPublisher, ISupportedLocaleIdentifier localeIdentifier, ModerationTaskType taskType, ModerationTaskPriority priority) where TTask : IReviewTask;
}
