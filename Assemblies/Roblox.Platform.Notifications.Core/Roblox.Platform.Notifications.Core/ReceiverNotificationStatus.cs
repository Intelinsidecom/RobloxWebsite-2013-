namespace Roblox.Platform.Notifications.Core;

public enum ReceiverNotificationStatus
{
	/// <summary>
	/// If the user has read the notification
	/// </summary>
	Read,
	/// <summary>
	/// If the notification is no longer valid (e.g. a friend request has already been accepted)
	/// </summary>
	Revoked,
	/// <summary>
	/// The original sending of the notification.
	/// </summary>
	Sent
}
