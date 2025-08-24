using System;
using System.Collections.Generic;

namespace Roblox.Platform.Notifications.Push;

public interface IPushNotificationMetadataManager
{
	void StoreNotificationMetadata(Guid notificationId, IStoredPushNotification storedPushNotificationData);

	void RecordNotificationPrimaryDelivery(Guid notificationId, long receiverDestinationId);

	void RecordNotificationFallbackDelivery(Guid notificationId, long receiverDestinationId);

	void StoreDeliveryReceiptDestinationMapping(string deliveryReceiptId, long destinationId);

	IStoredPushNotification GetNotificationMetadata(IUserPushDestinationCore destination, Guid notificationId, bool markAsReceived);

	IStoredPushNotification GetNotificationMetadataUnguarded(Guid notificationId);

	void MarkNotificationAsReceived(IUserPushDestinationCore destination, Guid notificationId);

	bool HasNotificationBeenReceived(IUserPushDestinationCore destination, Guid notificationId);

	ICollection<Guid> GetNotificationMetadataIdsPaged(IUserPushDestinationCore destination, int start, int count);

	long? GetDestinationIdFromDeliveryReceipt(string deliveryReceiptId);

	void MarkNotificationAsInteracted(IUserPushDestinationCore destination, Guid notificationId, PushNotificationInteractionType interactionType);

	void ResetUninterruptedFallbackCount(IUserPushDestinationCore destination);

	int GetUninterruptedFallbackCount(IUserPushDestinationCore destination);
}
