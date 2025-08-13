using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public interface ISilentNewContentPushNotification
{
	NotificationSourceType NotificationType { get; }

	string Category { get; }

	DateTime EventDate { get; }

	object Detail { get; }
}
