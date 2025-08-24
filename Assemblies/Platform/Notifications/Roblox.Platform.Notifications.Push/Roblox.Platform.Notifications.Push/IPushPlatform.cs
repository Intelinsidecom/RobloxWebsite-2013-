using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

internal interface IPushPlatform
{
	bool SupportsNotificationUpdates { get; }

	bool IsNotificationTokenValid(string token);

	string ProduceNotificationPayload(IPushNotificationSpecification specification, DeliveryAttemptType attempt, IPushNotificationMetadataManager metadataManager, INotificationBuilderRegistry<IPushNotificationContentBuilder> contentBuilderRegistry, IExtendedReceiverDestination receiver);

	bool FallbackRequired(IReceiver receiver, IPushNotificationSpecification specification);

	IPushServiceClient GetPushServiceClient();

	bool DeliveryAllowed(IReceiver receiver, IPushNotificationSpecification specification);
}
