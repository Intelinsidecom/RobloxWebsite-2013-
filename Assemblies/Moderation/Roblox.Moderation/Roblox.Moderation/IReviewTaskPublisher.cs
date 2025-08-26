using Roblox.Platform.Localization.Core;
namespace Roblox.Moderationpublic {
    interface IReviewTaskPublisher<in TTask> where TTask : IReviewTask

{
	void Publish(TTask task, ISupportedLocaleIdentifier supportedLocaleIdentifier, ModerationTaskPriority priority);
}


}
