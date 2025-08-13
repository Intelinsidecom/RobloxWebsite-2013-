using System;

namespace Roblox.Platform.Notifications.Push;

public interface IStoredPushNotification
{
	PushNotificationIntent Intent { get; }

	DateTime Created { get; }

	string DetailJson { get; }

	bool FallbackDelivered { get; }
}
