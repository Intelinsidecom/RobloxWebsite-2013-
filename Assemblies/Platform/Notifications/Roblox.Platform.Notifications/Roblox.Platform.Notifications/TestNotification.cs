using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

/// <summary>
/// An <see cref="T:Roblox.Platform.Notifications.Core.INotification" /> to send out as test notification when the user first activates the notification system.
/// </summary>
public class TestNotification : INotification
{
	/// <inheritdoc />
	public NotificationGenerator Generator { get; set; }

	/// <inheritdoc />
	public NotificationSourceType SourceType => NotificationSourceType.Test;

	/// <inheritdoc />
	public EventTarget EventTargetId { get; set; }

	/// <inheritdoc />
	public DateTime EventDate { get; set; }

	/// <summary>
	/// A json payload which contains detailed information about this notification.
	/// </summary>
	public string Detail { get; set; }

	/// <summary>
	/// The notification's category.
	/// </summary>
	public string Category => "Test";

	/// <inheritdoc />
	public string GetMessageSpecificNotificationKey()
	{
		return null;
	}
}
