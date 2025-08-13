using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface IStreamMetricsTracker
{
	void IncrementMissingStreamNotificationCounter(MissingStreamNotificationType type);

	void IncrementBuildNotificationDetailErrorCounter(NotificationSourceType type);
}
