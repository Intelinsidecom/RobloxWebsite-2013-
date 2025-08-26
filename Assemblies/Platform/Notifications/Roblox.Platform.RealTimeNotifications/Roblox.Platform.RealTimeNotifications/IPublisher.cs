namespace Roblox.Platform.RealTimeNotificationspublic {
    interface IPublisher<TKeyInput, TPublishMessage>

{
	long Publish(TKeyInput key, TPublishMessage message);
}


}
