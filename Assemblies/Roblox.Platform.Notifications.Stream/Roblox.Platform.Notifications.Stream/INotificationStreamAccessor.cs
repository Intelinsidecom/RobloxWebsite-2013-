using System;
using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

internal interface INotificationStreamAccessor
{
	ICollection<NotificationStreamEventGroup> GetRecentNotifications(IReceiver receiver, int startIndex, int maxRows);

	void ClearUnreadNotifications(IReceiver receiver);

	long GetUnreadNotificationCount(IReceiver receiver);

	/// <summary>
	/// Stores a notification in the system.
	/// </summary>
	/// <param name="sourceType">The <see cref="T:Roblox.Platform.Notifications.Core.NotificationSourceType" /> of the notification.</param>
	/// <param name="eventTarget">An identifier used by the consumer to identify the notification's content. Has a configurable max length.</param>
	/// <returns>A <see cref="T:System.Guid" /> uniquely identifing this notificaiton.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTarget" /> is null or empty</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="eventTarget" /> is longer than the maximum limit</exception>
	Guid StoreNotification(NotificationSourceType sourceType, EventTarget eventTarget);

	void LogNotificationStreamReceipt(IReceiver recipient, Guid notificationId);

	void MarkNotificationInteracted(Guid notificationId, IReceiver receiver, bool publishToOthers);

	void RevokeNotification(Guid notificationId, IReceiver receiver);
}
