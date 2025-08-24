using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public class PushCategoryRevokeMessageDetail
{
	public string Category { get; set; }

	public DateTime RevokeUpToDate { get; set; }

	public NotificationSourceType RevokedNotificationType { get; set; }
}
