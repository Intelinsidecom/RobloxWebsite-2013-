using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface INotificationStreamPersister
{
	/// <summary>
	/// Stores a notification and returns the id to the stored version.
	/// </summary>
	/// <param name="sourceType">The <see cref="T:Roblox.Platform.Notifications.Core.NotificationSourceType" /> of the notification.</param>
	/// <param name="eventTarget">The identifier the consumer is using to identify the content of a notiication.</param>
	/// <returns>A <see cref="T:System.Guid" /> uniquely identifing this notificaiton.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTarget" /> is null or empty</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="eventTarget" /> is longer than the maximum limit</exception>
	Guid GenerateNotificationId(NotificationSourceType sourceType, EventTarget eventTarget);

	void ClearUnreadNotifications(IReceiver receiver);

	void LogNotificationStreamReceipt(IReceiver recipient, Guid notificationId);

	void MarkNotificationInteracted(Guid notificationId, IReceiver receiver, bool publishToOthers);

	void RevokeNotification(Guid notificationId, IReceiver receiver);
}
