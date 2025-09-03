namespace Roblox.Platform.RealTimeNotifications
{
    public interface IPubSub<TKeyInput, TPublishMessage> : IPublisher<TKeyInput, TPublishMessage>, ISubscriber<TKeyInput, TPublishMessage>
    {
    }
}
