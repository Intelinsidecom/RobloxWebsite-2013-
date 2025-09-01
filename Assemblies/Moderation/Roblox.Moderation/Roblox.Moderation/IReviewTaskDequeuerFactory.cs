namespace Roblox.Moderation {
    interface IReviewTaskDequeuerFactory

{
	IReviewTaskDequeuer<TTask> Create<TTask>(string trackingKey) where TTask : IReviewTask;
}


}
