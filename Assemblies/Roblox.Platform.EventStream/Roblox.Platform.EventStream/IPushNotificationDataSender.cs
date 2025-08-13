namespace Roblox.Platform.EventStream;

public interface IPushNotificationDataSender
{
	/// <summary>
	/// Publish push notification data to AmazonKinesisFirehose
	/// </summary>
	/// <param name="pushNotificationData">The push notification data</param>
	void PublishData(IPushNotificationData pushNotificationData);
}
