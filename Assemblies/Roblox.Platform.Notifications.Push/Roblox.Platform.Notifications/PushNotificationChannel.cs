using System;
using Newtonsoft.Json;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.Notifications;

public class PushNotificationChannel : INotificationChannel
{
	internal readonly IUserPushDestination UserPushDestination;

	private readonly IPushNotificationEventPublisher _EventPublisher;

	private readonly IPushNotificationMetadataManager _MetadataManager;

	public ReceiverDestinationType DestinationType { get; }

	public PushNotificationChannel(ReceiverDestinationType destinationType, IUserPushDestination destination, IPushNotificationEventPublisher eventPublisher, IPushNotificationMetadataManager metadataManager)
	{
		DestinationType = destinationType;
		UserPushDestination = destination;
		_EventPublisher = eventPublisher;
		_MetadataManager = metadataManager;
	}

	public string Store(INotification message)
	{
		Guid pushNotificationId = Guid.NewGuid();
		StoredPushNotification metadata = new StoredPushNotification
		{
			Intent = PushNotificationIntent.NewContent,
			DetailJson = JsonConvert.SerializeObject(message),
			Created = DateTime.UtcNow
		};
		_MetadataManager.StoreNotificationMetadata(pushNotificationId, metadata);
		return pushNotificationId.ToString();
	}

	public void Distribute(INotification message, string channelNotificationId)
	{
		Guid pushNotificationId = Guid.Parse(channelNotificationId);
		_EventPublisher.PublishPrimaryNotification(UserPushDestination, pushNotificationId, PushNotificationIntent.NewContent, message.SourceType);
	}

	public void Distribute(NotificationSourceType notificationSourceType, string channelNotificationId)
	{
		Guid pushNotificationId = Guid.Parse(channelNotificationId);
		_EventPublisher.PublishPrimaryNotification(UserPushDestination, pushNotificationId, PushNotificationIntent.NewContent, notificationSourceType);
	}

	public void DistributeStatusUpdateForSingleNotification(NotificationSourceType notificationSourceType, string channelNotificationId, ReceiverNotificationStatus newStatus)
	{
		if (UserPushDestination.SupportsUpdateNotifications)
		{
			Guid updatedNotificationId = Guid.Parse(channelNotificationId);
			Guid notificationId = Guid.NewGuid();
			PushRevokeMessageDetail detail = new PushRevokeMessageDetail
			{
				RevokedNotificationType = notificationSourceType,
				RevokedNotificationId = updatedNotificationId
			};
			StoredPushNotification metadata = new StoredPushNotification
			{
				Intent = PushNotificationIntent.UpdateSingleNotification,
				DetailJson = JsonConvert.SerializeObject(detail),
				Created = DateTime.UtcNow
			};
			_MetadataManager.StoreNotificationMetadata(notificationId, metadata);
			_EventPublisher.PublishPrimaryNotification(UserPushDestination, notificationId, PushNotificationIntent.UpdateSingleNotification, null);
		}
	}

	public void DistributeStatusUpdateForCategory(NotificationSourceType notificationSourceType, string notificationCategory, ReceiverNotificationStatus newStatus, DateTime? eventDate)
	{
		Guid expirationNotificationId = Guid.NewGuid();
		PushCategoryRevokeMessageDetail detail = new PushCategoryRevokeMessageDetail
		{
			RevokedNotificationType = notificationSourceType,
			Category = notificationCategory,
			RevokeUpToDate = (eventDate ?? DateTime.UtcNow)
		};
		StoredPushNotification metadata = new StoredPushNotification
		{
			Intent = PushNotificationIntent.UpdateCategoryOfNotifications,
			DetailJson = JsonConvert.SerializeObject(detail),
			Created = DateTime.UtcNow
		};
		_MetadataManager.StoreNotificationMetadata(expirationNotificationId, metadata);
		_EventPublisher.PublishPrimaryNotification(UserPushDestination, expirationNotificationId, PushNotificationIntent.UpdateCategoryOfNotifications, null);
	}
}
