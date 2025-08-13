using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationBandPreference
{
	INotificationBand NotificationBand { get; }

	IReceiver Receiver { get; }

	bool IsEnabled { get; }
}
