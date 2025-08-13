using Roblox.TranslationResources.Notifications;

namespace Roblox.TranslationResources;

public interface INotificationsResources : ITranslationResourcesNamespacesGroup
{
	IDesktopPushNotificationPromptsResources DesktopPushNotificationPrompts { get; }

	INotificationStreamResources NotificationStream { get; }

	IPushNotificationsResources PushNotifications { get; }
}
