namespace Roblox.Platform.RealTimeNotifications
{
    public interface IPublisher<TKeyInput, TPublishMessage>
    {
        long Publish(TKeyInput key, TPublishMessage message);
    }
}
