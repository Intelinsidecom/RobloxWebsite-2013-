using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

/// <summary>
/// Represents a class that can save information about a notification receiver's preferences.
/// </summary>
public interface IReceiverPreferencesManager
{
	void OptOutOfReceiverDestinationType(IReceiver receiver, ReceiverDestinationType destinationType);

	void AllowReceiverDestinationTypeNotifications(IReceiver receiver, ReceiverDestinationType destinationType);

	void OptOutOfNotificationSourceType(IReceiver receiver, NotificationSourceType notificationSourceType);

	void AllowNotificationSourceTypeNotifications(IReceiver receiver, NotificationSourceType notificationSourceType);

	void SetNotificationBandPreference(IReceiver receiver, NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool isEnabled);

	void SetDestinationPreference(IReceiver receiver, NotificationSourceType notificationSourceType, long destinationId, bool isEnabled);
}
