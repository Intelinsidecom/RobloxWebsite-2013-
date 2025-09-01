using Roblox.Localization.Core;
namespace Roblox.Moderation {
    public interface IReviewTaskPublisher<in TTask> where TTask : IReviewTask

{
	void Publish(TTask task, ISupportedLocaleIdentifier supportedLocaleIdentifier, ModerationTaskPriority priority);
}


}
