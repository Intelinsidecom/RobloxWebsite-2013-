using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public interface IPushNotificationEventPublisher
{
	bool PublishPrimaryNotification(IUserPushDestination destination, Guid notificationId, PushNotificationIntent intent, NotificationSourceType? notificationSourceType);

	bool PublishFallbackNotification(IPushNotificationSpecification notification);
}
