namespace Roblox.Platform.Notifications.Push;

public interface IPushNotificationDeliverer
{
	PushDeliveryResult Deliver(IPushNotificationSpecification specification, DeliveryAttemptType attempt);
}
