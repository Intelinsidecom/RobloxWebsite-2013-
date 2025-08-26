namespace Roblox.Moderationpublic {
    interface IReviewTaskDequeuerFactory

{
	IReviewTaskDequeuer<TTask> Create<TTask>(string trackingKey) where TTask : IReviewTask;
}


}
