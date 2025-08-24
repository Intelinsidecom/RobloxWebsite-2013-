using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

/// <summary>
/// Represents a class that can be used to configure which notifications get sent to which channels, as well as the default settings.
/// </summary>
public interface INotificationBandManager
{
	/// <summary>
	/// Allows notifications to be sent from the given NotificationSourceType to the given ReceiverDestinationType.
	/// </summary>
	/// <param name="notificationSourceType">The source of notifications to allow.</param>
	/// <param name="receiverDestinationType">The destination to allow notifications to be sent to.</param>
	/// <param name="isEnabledByDefault">Whether the notification should be sent by default, e.g., if a receiver has not specified a preference.</param>
	/// <param name="isOverridableByReceiver">Whether a receiver's preference is respected while deciding whether to send a notification or not.</param>
	/// <remarks>The default values for <paramref name="isEnabledByDefault" /> and <paramref name="isOverridableByReceiver" /> will create a NotificationBand but will not send notifications to anyone. 
	/// To change this behavior set these parameters in either this method or <see cref="M:Roblox.Platform.Notifications.INotificationBandManager.UpdateNotificationBandDefaults(Roblox.Platform.Notifications.INotificationBand,System.Boolean,System.Boolean)" />.</remarks>
	void CreateNotificationBand(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool isEnabledByDefault = false, bool isOverridableByReceiver = false);

	/// <summary>
	/// Updates the default settings of the specified INotificationBand.
	/// </summary>
	/// <param name="notificationBand">The notification band to change defaults for.</param>
	/// <param name="isEnabledByDefault">Whether notifications should be sent on this band by default.</param>
	/// <param name="isOverridableByReceiver">Whether a receiver should be able to configure receipt of notifications on this band.</param>
	void UpdateNotificationBandDefaults(INotificationBand notificationBand, bool isEnabledByDefault, bool isOverridableByReceiver);

	/// <summary>
	/// Prevents messages from being sent on the notification band.
	/// </summary>
	/// <param name="notificationBand">The notification band to disable.</param>
	void DisableNotificationBand(INotificationBand notificationBand);
}
