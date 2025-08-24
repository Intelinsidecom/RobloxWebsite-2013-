using System;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Notifications.Stream.Events;

public class NotificationMarkedInteractedMessage : UserNotificationMessageBase
{
	public override string Type { get; set; }

	public Guid NotificationId { get; set; }

	public NotificationMarkedInteractedMessage(Guid notificationId)
	{
		NotificationId = notificationId;
		Type = "NotificationMarkedInteracted";
	}
}
