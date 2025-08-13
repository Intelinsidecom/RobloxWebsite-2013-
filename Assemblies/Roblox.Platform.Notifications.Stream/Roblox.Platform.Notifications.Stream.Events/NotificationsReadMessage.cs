using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Notifications.Stream.Events;

public class NotificationsReadMessage : UserNotificationMessageBase
{
	public override string Type { get; set; }

	public NotificationsReadMessage()
	{
		Type = "NotificationsRead";
	}
}
