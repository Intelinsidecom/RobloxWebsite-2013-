using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public class PushRevokeMessageDetail
{
	public NotificationSourceType RevokedNotificationType { get; set; }

	public Guid RevokedNotificationId { get; set; }
}
