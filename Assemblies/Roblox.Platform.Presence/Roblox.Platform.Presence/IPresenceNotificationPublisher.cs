using System;
using System.Collections.Generic;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Presence;

public interface IPresenceNotificationPublisher
{
	UserNotificationPublishResult PublishUserOnlineNotification(long recipientUserId, long actorUserId);

	UserNotificationPublishResult PublishUserOfflineNotification(long recipientUserId, long actorUserId);

	UserNotificationPublishResult PublishUsersBulkPresenceNotifications(long recipientUserId, IReadOnlyCollection<Tuple<long, PresenceEvent>> actorUsersWithPresenceStatus, bool publishSingleUserNotificationsForBackwardCompatibility);
}
