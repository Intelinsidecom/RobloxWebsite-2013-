namespace Roblox.Platform.Notifications.Core.Events;

public class NotificationUpdate
{
	public NotificationSourceType? Type { get; set; }

	public ReceiverDestinationType? DestinationType { get; set; }

	public string NotificationKey { get; set; }

	public ReceiverNotificationStatus Status { get; set; }

	public IReceiver Receiver { get; set; }
}
