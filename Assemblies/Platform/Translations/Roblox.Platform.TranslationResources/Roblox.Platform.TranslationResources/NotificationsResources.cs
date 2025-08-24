using System;
using Roblox.TranslationResources.Notifications;

namespace Roblox.TranslationResources;

internal class NotificationsResources : INotificationsResources, ITranslationResourcesNamespacesGroup
{
	private readonly Lazy<IDesktopPushNotificationPromptsResources> _IDesktopPushNotificationPromptsResources;

	private readonly Lazy<INotificationStreamResources> _INotificationStreamResources;

	private readonly Lazy<IPushNotificationsResources> _IPushNotificationsResources;

	public IDesktopPushNotificationPromptsResources DesktopPushNotificationPrompts => _IDesktopPushNotificationPromptsResources.Value;

	public INotificationStreamResources NotificationStream => _INotificationStreamResources.Value;

	public IPushNotificationsResources PushNotifications => _IPushNotificationsResources.Value;

	public NotificationsResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		_IDesktopPushNotificationPromptsResources = new Lazy<IDesktopPushNotificationPromptsResources>(() => DesktopPushNotificationPromptsResourceFactory.GetResources(locale, state));
		_INotificationStreamResources = new Lazy<INotificationStreamResources>(() => NotificationStreamResourceFactory.GetResources(locale, state));
		_IPushNotificationsResources = new Lazy<IPushNotificationsResources>(() => PushNotificationsResourceFactory.GetResources(locale, state));
	}

	public ITranslationResources GetByFullNamespace(string fullTranslationResourceNamespace)
	{
		if (string.IsNullOrWhiteSpace(fullTranslationResourceNamespace))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "fullTranslationResourceNamespace");
		}
		return fullTranslationResourceNamespace switch
		{
			"Notifications.DesktopPushNotificationPrompts" => DesktopPushNotificationPrompts, 
			"Notifications.NotificationStream" => NotificationStream, 
			"Notifications.PushNotifications" => PushNotifications, 
			_ => null, 
		};
	}
}
