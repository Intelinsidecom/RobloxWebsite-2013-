using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public class NotificationBuilderRegistry<TNotificationBuilder> : INotificationBuilderRegistry<TNotificationBuilder> where TNotificationBuilder : class, INotificationBuilder
{
	private Dictionary<NotificationSourceType, TNotificationBuilder> _Registry = new Dictionary<NotificationSourceType, TNotificationBuilder>();

	public void RegisterBuilder(TNotificationBuilder notificationBuilder)
	{
		_Registry[notificationBuilder.NotificationSourceType] = notificationBuilder;
	}

	public TNotificationBuilder GetBuilder(NotificationSourceType type)
	{
		if (_Registry.TryGetValue(type, out var builder))
		{
			return builder;
		}
		return null;
	}
}
