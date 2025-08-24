using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.AbTesting;

public interface IExperimentEnrollmentAccessor
{
	bool IsFriendRequestPushNotificationEnabled(IReceiver receiver);
}
