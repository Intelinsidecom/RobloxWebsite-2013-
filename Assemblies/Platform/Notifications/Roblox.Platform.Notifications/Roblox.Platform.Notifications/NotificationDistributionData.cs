using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

/// <summary>
/// Represents an object that contains distribution data associated to a notification.
/// </summary>
public class NotificationDistributionData
{
	/// <summary>
	/// The <see cref="P:Roblox.Platform.Notifications.NotificationDistributionData.NotificationSourceType" />.
	/// </summary>
	public NotificationSourceType NotificationSourceType { get; set; }

	/// <summary>
	/// A map of <see cref="T:Roblox.Platform.Notifications.Core.ReceiverDestinationType" /> to notification channel id associated with the notification.
	/// A single notification can have a different notification channel id per every <see cref="T:Roblox.Platform.Notifications.Core.ReceiverDestinationType" />.
	/// This specific channel ids are use to pull the metadata of the notification for the specific channel.
	/// </summary>
	public Dictionary<ReceiverDestinationType, string> DestinationTypeNotificationIds { get; set; }
}
