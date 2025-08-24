using System;

namespace Roblox.Platform.Notifications.Push;

/// <summary>
/// This contains the details of a new Push Notification. This is used to be published to SNS to be handled
/// some time in the future by a processor
/// </summary>
public class PushNotificationEventLegacy
{
	public long ReceiverDestinationId { get; set; }

	public PushApplicationType Application { get; set; }

	public Guid NotificationId { get; set; }

	public string NotificationType { get; set; }

	public bool IsUserVisible { get; set; }
}
