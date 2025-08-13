using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal class NotificationSourceTypeOptOut : INotificationSourceTypeOptOut
{
	public NotificationSourceType NotificationSourceType { get; internal set; }

	public IReceiver Receiver { get; internal set; }
}
