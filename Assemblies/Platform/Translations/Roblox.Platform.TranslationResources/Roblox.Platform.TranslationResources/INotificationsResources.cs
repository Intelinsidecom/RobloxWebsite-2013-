using System;
using System.Collections.Generic;
using Roblox.Platform.TranslationResources.Notifications;
namespace Roblox.Platform.TranslationResources {
    public interface INotificationsResources : ITranslationResourcesNamespacesGroup

{
	IDesktopPushNotificationPromptsResources DesktopPushNotificationPrompts { get; }

	INotificationStreamResources NotificationStream { get; }

	IPushNotificationsResources PushNotifications { get; }
}


}


