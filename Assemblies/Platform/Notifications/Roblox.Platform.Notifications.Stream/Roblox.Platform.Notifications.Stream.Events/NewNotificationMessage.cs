using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Notifications.Stream.Events;

public class NewNotificationMessage : UserNotificationMessageBase
{
	public override string Type { get; set; }

	public NewNotificationMessage()
	{
		Type = "NewNotification";
	}
}
