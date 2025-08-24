namespace Roblox.RealTimeNotifications.Client;

public enum PublishUserNotificationError
{
	Unknown = 1,
	InvalidUser,
	ErrorPublishingNotification,
	InvalidRequest,
	InvalidNotificationNamespace,
	UserNotificationPublisherCreationException
}
