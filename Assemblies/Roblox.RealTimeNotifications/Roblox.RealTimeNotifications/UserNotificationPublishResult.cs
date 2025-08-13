namespace Roblox.RealTimeNotifications;

public enum UserNotificationPublishResult
{
	/// <summary>
	/// At least one client/subsription for the user received the notification
	/// </summary>
	UserReceivedNotification,
	/// <summary>
	/// No subscription/client for the user received notification (user probably offline)
	/// </summary>
	UserDidNotReceiveNotification,
	/// <summary>
	/// Attempting to publish notification to an Invalid User
	/// </summary>
	InvalidUser,
	/// <summary>
	/// There was an error publishing notification
	/// </summary>
	ErrorPublishingNotification
}
