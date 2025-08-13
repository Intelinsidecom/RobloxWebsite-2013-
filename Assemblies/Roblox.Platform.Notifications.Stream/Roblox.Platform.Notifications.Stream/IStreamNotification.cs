using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

/// <summary>
/// Represents a notification within the notification stream subsystem.
/// </summary>
public interface IStreamNotification
{
	/// <summary>
	/// The notification's <see cref="T:Roblox.Platform.Notifications.Core.NotificationSourceType" />
	/// </summary>
	NotificationSourceType SourceType { get; }

	/// <summary>
	/// The notification's category
	/// </summary>
	string Category { get; }

	/// <summary>
	/// The notification's <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" />
	/// </summary>
	EventTarget EventTargetId { get; }

	/// <summary>
	/// The notification's time
	/// </summary>
	DateTime EventDate { get; }

	/// <summary>
	/// An <see cref="T:System.Object" /> containing detailed information about this notification.
	/// </summary>
	object Detail { get; }
}
