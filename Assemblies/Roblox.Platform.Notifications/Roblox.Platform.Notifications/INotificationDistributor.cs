using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationDistributor
{
	void DistributeNotification(INotification message);

	void UpdateNotificationStatusByNotificationKey(IReceiver receiver, NotificationSourceType sourceType, ReceiverNotificationStatus newStatus, string notificationKey);

	void UpdateNotificationStatusByChannelNotificationId(IReceiver receiver, ReceiverNotificationStatus newStatus, ReceiverDestinationType sourceDestinationType, string channelNotificationId);

	void UpdateNotificationCategory(IReceiver receiver, NotificationSourceType notificationSourceType, string notificationCategory, ReceiverNotificationStatus notificationStatus, DateTime? eventDate = null);
}
