namespace Roblox.Platform.Notifications.Core;

public interface INotificationBuilderRegistry<TNotificationBuilder> where TNotificationBuilder : INotificationBuilder
{
	void RegisterBuilder(TNotificationBuilder notificationBuilder);

	TNotificationBuilder GetBuilder(NotificationSourceType type);
}
