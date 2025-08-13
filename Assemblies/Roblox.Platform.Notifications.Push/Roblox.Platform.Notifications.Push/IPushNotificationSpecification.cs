using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public interface IPushNotificationSpecification
{
	long ReceiverDestinationId { get; }

	PushApplicationType Application { get; }

	Guid NotificationId { get; }

	PushNotificationIntent Intent { get; }

	NotificationSourceType? NewContentNotificationType { get; }
}
