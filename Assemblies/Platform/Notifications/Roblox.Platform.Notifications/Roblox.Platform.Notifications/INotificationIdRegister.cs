using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationIdRegister
{
	void StoreNotificationIdLookupByNotificationKey(Guid notificationId, NotificationSourceType sourceType, string notificationKey);

	void StoreNotificationIdLookupByDestinationTypeNotificationId(Guid notificationId, ReceiverDestinationType destinationType, string destinationTypeNotificationId);

	Guid? RetrieveNotificationIdByNotificationKey(NotificationSourceType sourceType, string notificationKey);

	Guid? RetrieveNotificationIdByDestinationTypeNotificationId(ReceiverDestinationType destinationType, string destinationTypeNotificationId);

	void StoreNotificationSourceType(Guid notificationId, NotificationSourceType sourceType);

	void StoreNotificationDestinationTypeNotificationId(Guid notificationId, ReceiverDestinationType destinationType, string destinationTypeNotificationId);

	NotificationDistributionData RetrieveNotificationDistributionData(Guid notificationId);
}
