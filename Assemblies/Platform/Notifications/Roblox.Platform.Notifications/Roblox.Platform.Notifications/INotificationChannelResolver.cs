using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationChannelResolver
{
	ICollection<INotificationChannel> ResolveNotificationChannelsForNotification(NotificationSourceType notificationSourceType, IReceiver receiver, ReceiverNotificationStatus status);
}
