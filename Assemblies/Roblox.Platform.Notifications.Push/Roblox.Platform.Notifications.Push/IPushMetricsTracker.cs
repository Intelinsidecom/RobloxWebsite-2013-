using System;

namespace Roblox.Platform.Notifications.Push;

public interface IPushMetricsTracker
{
	void IncrementRegistration(PushApplicationType application, PushPlatformType platform, bool userInitiated, bool newReceiverDestinationCreated);

	void IncrementRegistrationEvent(PushApplicationType application, PushPlatformType platform, PushRegistrationEventType registrationEventType);

	void IncrementDestinationExpiry(PushApplicationType application, PushPlatformType platform, int? receiverTypeId, long? receiverTargetId);

	void IncrementDeliveryAttempted(string notificationType, PushApplicationType application, PushPlatformType platform, DeliveryAttemptType attempt);

	void IncrementMetadataRead(string notificationType, PushApplicationType application, PushPlatformType platform, DateTime notificationDeliveryStarted, DateTime metadataRead);

	void IncrementMetadataRetrieveFailure(PushApplicationType application, PushPlatformType platform);

	void IncrementInteraction(string notificationType, PushNotificationInteractionType interactionType, PushApplicationType application, PushPlatformType platform, DateTime notificationDelivered, DateTime interactionRecorded);

	void IncrementDestinationFlooded(PushApplicationType application, PushPlatformType platform);

	void IncrementDestinationAndTypeCombinationFlooded(string notificationType, PushApplicationType application);
}
