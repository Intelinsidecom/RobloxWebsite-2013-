using System;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public class NotificationStreamChannel : INotificationChannel
{
	private readonly IReceiver _Receiver;

	private readonly INotificationStreamPersister _NotificationStreamPersister;

	public ReceiverDestinationType DestinationType => ReceiverDestinationType.NotificationStream;

	public NotificationStreamChannel(INotificationStreamPersister notificationStreamPersister, IReceiver receiver)
	{
		_Receiver = receiver;
		_NotificationStreamPersister = notificationStreamPersister;
	}

	public string Store(INotification message)
	{
		return _NotificationStreamPersister.GenerateNotificationId(message.SourceType, message.EventTargetId).ToString();
	}

	public void Distribute(INotification message, string channelNotificationId)
	{
		Distribute(message.SourceType, channelNotificationId);
	}

	public void Distribute(NotificationSourceType notificationSourceType, string channelNotificationId)
	{
		if (!Guid.TryParse(channelNotificationId, out var notificationId))
		{
			throw new PlatformArgumentException("channelNotificationId was not a guid");
		}
		_NotificationStreamPersister.LogNotificationStreamReceipt(_Receiver, notificationId);
	}

	public void DistributeStatusUpdateForSingleNotification(NotificationSourceType notificationSourceType, string channelNotificationId, ReceiverNotificationStatus newStatus)
	{
		if (!Guid.TryParse(channelNotificationId, out var notificationId))
		{
			throw new PlatformArgumentException("channelNotificationId was not a guid");
		}
		switch (newStatus)
		{
		case ReceiverNotificationStatus.Read:
			_NotificationStreamPersister.MarkNotificationInteracted(notificationId, _Receiver, publishToOthers: false);
			break;
		case ReceiverNotificationStatus.Revoked:
			_NotificationStreamPersister.RevokeNotification(notificationId, _Receiver);
			break;
		}
	}

	public void DistributeStatusUpdateForCategory(NotificationSourceType notificationSourceType, string notificationCategory, ReceiverNotificationStatus newStatus, DateTime? eventDate)
	{
	}
}
