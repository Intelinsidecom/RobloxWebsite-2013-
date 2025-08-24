using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationSourceTypeOptOut
{
	NotificationSourceType NotificationSourceType { get; }

	IReceiver Receiver { get; }
}
