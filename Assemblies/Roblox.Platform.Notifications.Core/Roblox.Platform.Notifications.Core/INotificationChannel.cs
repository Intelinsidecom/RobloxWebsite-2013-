using System;

namespace Roblox.Platform.Notifications.Core;

public interface INotificationChannel
{
	ReceiverDestinationType DestinationType { get; }

	string Store(INotification message);

	void Distribute(INotification message, string channelNotificationId);

	void Distribute(NotificationSourceType notificationSourceType, string channelNotificationId);

	void DistributeStatusUpdateForSingleNotification(NotificationSourceType notificationSourceType, string channelNotificationId, ReceiverNotificationStatus newStatus);

	void DistributeStatusUpdateForCategory(NotificationSourceType notificationSourceType, string notificationCategory, ReceiverNotificationStatus newStatus, DateTime? eventDate);
}
