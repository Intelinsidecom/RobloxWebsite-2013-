using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationBand
{
	int Id { get; }

	NotificationSourceType NotificationSourceType { get; }

	ReceiverDestinationType ReceiverDestinationType { get; }

	bool IsEnabledByDefault { get; }

	bool IsOverridable { get; }
}
