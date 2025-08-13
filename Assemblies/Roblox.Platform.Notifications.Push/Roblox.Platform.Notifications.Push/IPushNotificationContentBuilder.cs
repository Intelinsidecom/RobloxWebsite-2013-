using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public interface IPushNotificationContentBuilder : INotificationBuilder
{
	ISilentNewContentPushNotification BuildSilentNewContentPushNotification(string notificationJson);

	IVisibleNewContentPushNotification BuildVisibleNewContentPushNotification(IUser user, string notificationJson);
}
