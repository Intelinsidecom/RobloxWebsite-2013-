using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.RealTimeNotifications;
using Roblox.Redis;

namespace Roblox.Platform.Presence;

public class PresenceNotificationPublisher : IPresenceNotificationPublisher
{
	private readonly UserNotificationPublisher<PresenceNotificationMessage> _UserNotificationPublisher;

	private readonly UserNotificationPublisher<PresenceNotificationMessage> _UserBulkNotificationsPublisher;

	public PresenceNotificationPublisher(ILogger logger, IRedisClient redisClient)
	{
		_UserNotificationPublisher = new UserNotificationPublisher<PresenceNotificationMessage>(logger, "PresenceNotifications", redisClient);
		_UserBulkNotificationsPublisher = new UserNotificationPublisher<PresenceNotificationMessage>(logger, "PresenceBulkNotifications", redisClient);
	}

	public UserNotificationPublishResult PublishUserOnlineNotification(long recipientUserId, long actorUserId)
	{
		PresenceNotificationMessage message = new PresenceNotificationMessage
		{
			UserId = actorUserId,
			Type = PresenceEventType.UserOnline.ToString()
		};
		return PublishUserStatusChange(recipientUserId, message);
	}

	public UserNotificationPublishResult PublishUserOfflineNotification(long recipientUserId, long actorUserId)
	{
		PresenceNotificationMessage message = new PresenceNotificationMessage
		{
			UserId = actorUserId,
			Type = PresenceEventType.UserOffline.ToString()
		};
		return PublishUserStatusChange(recipientUserId, message);
	}

	public UserNotificationPublishResult PublishUsersBulkPresenceNotifications(long recipientUserId, IReadOnlyCollection<Tuple<long, PresenceEvent>> actorUsersWithPresenceStatus, bool publishSingleUserNotificationsForBackwardCompatibility)
	{
		int numberOfEvents = actorUsersWithPresenceStatus.Count;
		List<PresenceNotificationMessage> bulkNotificationsMessage = new List<PresenceNotificationMessage>(numberOfEvents);
		List<PresenceNotificationMessage> eventsForPublishingSingleUserNotifications = (publishSingleUserNotificationsForBackwardCompatibility ? new List<PresenceNotificationMessage>(numberOfEvents) : null);
		foreach (Tuple<long, PresenceEvent> userWithPresenceStatus in actorUsersWithPresenceStatus)
		{
			if (userWithPresenceStatus != null)
			{
				bulkNotificationsMessage.Add(new PresenceNotificationMessage
				{
					UserId = userWithPresenceStatus.Item1,
					Type = PresenceEventType.PresenceChanged.ToString()
				});
				eventsForPublishingSingleUserNotifications?.Add(new PresenceNotificationMessage
				{
					UserId = userWithPresenceStatus.Item1,
					Type = userWithPresenceStatus.Item2.EventType.ToString()
				});
			}
		}
		long? bulkMessageSequenceNumber;
		long? bulkMessageNamespaceSequenceNumber;
		UserNotificationPublishResult num = PublishBulkUsersStatusChanges(recipientUserId, bulkNotificationsMessage, out bulkMessageSequenceNumber, out bulkMessageNamespaceSequenceNumber);
		if (num.IsSuccess() && publishSingleUserNotificationsForBackwardCompatibility && bulkMessageSequenceNumber.HasValue)
		{
			eventsForPublishingSingleUserNotifications.ForEach(delegate(PresenceNotificationMessage notificationMessage)
			{
				_UserNotificationPublisher.Publish(recipientUserId, notificationMessage, bulkMessageSequenceNumber, bulkMessageNamespaceSequenceNumber);
			});
		}
		return num;
	}

	private UserNotificationPublishResult PublishUserStatusChange(long recipientUserId, PresenceNotificationMessage message)
	{
		return _UserNotificationPublisher.Publish(recipientUserId, message);
	}

	private UserNotificationPublishResult PublishBulkUsersStatusChanges(long recipientUserId, IReadOnlyCollection<PresenceNotificationMessage> message, out long? bulkMessageSequenceNumber, out long? bulkMessageNamespaceSequenceNumber)
	{
		return _UserBulkNotificationsPublisher.Publish(recipientUserId, message, out bulkMessageSequenceNumber, out bulkMessageNamespaceSequenceNumber);
	}
}
