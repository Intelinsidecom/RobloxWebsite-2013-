using System.Diagnostics;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationsMetricsTracker
{
	void TrackNotificationDelivery(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool wasSuccess);

	void TrackNotificationUpdate(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool wasSuccess);

	void TrackDistributionComplete(NotificationSourceType notificationSourceType, Stopwatch stopwatch, int numberOfReceivers, int totalNumberOfChannels);

	void TrackUpdateComplete(NotificationSourceType notificationSourceType, Stopwatch stopwatch);

	void TrackUpdateLookupFailure(ReceiverNotificationStatus updatedStatus);
}
