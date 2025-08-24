namespace Roblox.Platform.Moderation;

public interface IReviewTaskDequeuerFactory
{
	IReviewTaskDequeuer<TTask> Create<TTask>(string trackingKey) where TTask : IReviewTask;
}
