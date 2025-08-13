using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationBandAccessor
{
	INotificationBand Get(int notificationBandId);

	INotificationBand GetByNotificationSourceTypeAndReceiverDestinationType(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType);

	IEnumerable<INotificationBand> GetAllByNotificationSourceType(NotificationSourceType notificationSourceType);

	IEnumerable<INotificationBand> GetAllByReceiverDestinationType(ReceiverDestinationType receiverDestinationType);
}
