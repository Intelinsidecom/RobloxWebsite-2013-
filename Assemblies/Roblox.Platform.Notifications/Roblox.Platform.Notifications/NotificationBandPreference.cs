using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal class NotificationBandPreference : INotificationBandPreference
{
	public INotificationBand NotificationBand { get; internal set; }

	public IReceiver Receiver { get; internal set; }

	public bool IsEnabled { get; internal set; }
}
