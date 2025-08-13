using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

internal class PushNotificationEvent
{
	public long ReceiverDestinationId { get; set; }

	public PushApplicationType Application { get; set; }

	public Guid NotificationId { get; set; }

	public PushNotificationIntent Intent { get; set; }

	public NotificationSourceType? NewContentNotificationType { get; set; }
}
