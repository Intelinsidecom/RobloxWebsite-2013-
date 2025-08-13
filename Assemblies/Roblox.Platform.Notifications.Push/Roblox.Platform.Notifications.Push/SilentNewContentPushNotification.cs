using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public class SilentNewContentPushNotification : ISilentNewContentPushNotification
{
	public NotificationSourceType NotificationType { get; set; }

	public string Category { get; set; }

	public DateTime EventDate { get; set; }

	public object Detail { get; set; }
}
