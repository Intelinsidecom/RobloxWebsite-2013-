using Roblox.Platform.Notifications.Core.Events;

namespace Roblox.Platform.Notifications.Core;

public interface INotificationEventPublisher
{
	void PublishNew(INotification message);

	void PublishUpdate(NotificationUpdate update);

	void PublishCategoryUpdate(CategoryUpdate update);
}
