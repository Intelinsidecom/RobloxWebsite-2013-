using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface IExperimentEnrollmentAccessor
{
	bool IsNotificationEnabled(IReceiver receiver, INotificationBand notificationBand);
}
