using System;

namespace Roblox.Platform.Notifications.Push;

internal class StoredPushNotification : IStoredPushNotification
{
	public PushNotificationIntent Intent { get; set; }

	public DateTime Created { get; set; }

	public string DetailJson { get; set; }

	public bool FallbackDelivered { get; set; }
}
