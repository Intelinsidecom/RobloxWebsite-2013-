using System;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Stream.Properties;
using Roblox.Redis.Lru;

namespace Roblox.Platform.Notifications.Stream;

public class NotificationStreamPersister : INotificationStreamPersister
{
	private readonly INotificationStreamAccessor _NotificationStreamAccessor;

	public NotificationStreamPersister(INotificationEventPublisher notificationEventPublisher, INotificationStreamRedisClients notificationStreamRedisClients, ILogger logger, IStreamNotificationEventPublisher streamNotificationEventPublisher)
	{
		_NotificationStreamAccessor = new NotificationStreamAccessor(notificationEventPublisher, notificationStreamRedisClients.EphemeralRedisClient, RedisLruClient.GetInstance(), logger, streamNotificationEventPublisher, new UnreadCountTracker(notificationStreamRedisClients.EphemeralRedisClient, GetUtcNow), new HourlyEventCountTracker(notificationStreamRedisClients.PersistentRedisClient, Settings.Default.NotificationStreamEventExpirationDelay));
	}

	public void ClearUnreadNotifications(IReceiver receiver)
	{
		_NotificationStreamAccessor.ClearUnreadNotifications(receiver);
	}

	/// <inheritdoc />
	public Guid GenerateNotificationId(NotificationSourceType sourceType, EventTarget eventTargetId)
	{
		return _NotificationStreamAccessor.StoreNotification(sourceType, eventTargetId);
	}

	public void LogNotificationStreamReceipt(IReceiver recipient, Guid notificationId)
	{
		_NotificationStreamAccessor.LogNotificationStreamReceipt(recipient, notificationId);
	}

	public void MarkNotificationInteracted(Guid notificationId, IReceiver receiver, bool publishToOthers)
	{
		_NotificationStreamAccessor.MarkNotificationInteracted(notificationId, receiver, publishToOthers);
	}

	public void RevokeNotification(Guid notificationId, IReceiver receiver)
	{
		_NotificationStreamAccessor.RevokeNotification(notificationId, receiver);
	}

	private static DateTime GetUtcNow()
	{
		return DateTime.UtcNow;
	}
}
