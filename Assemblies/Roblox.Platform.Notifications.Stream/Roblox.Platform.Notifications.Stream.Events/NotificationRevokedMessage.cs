using System;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Notifications.Stream.Events;

internal class NotificationRevokedMessage : UserNotificationMessageBase
{
	public override string Type { get; set; } = "NotificationRevoked";


	public Guid NotificationId { get; private set; }

	public NotificationRevokedMessage(Guid notificationId)
	{
		NotificationId = notificationId;
	}
}
