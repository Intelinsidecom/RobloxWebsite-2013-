using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

/// <summary>
/// Identifies a notification stored in the notification stream.
/// </summary>
internal class NotificationStreamEventIdentifier
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Notifications.Core.NotificationSourceType" /> of the notification.
	/// </summary>
	public NotificationSourceType SourceType { get; set; }

	/// <summary>
	/// The id of the event.
	/// </summary>
	public Guid EventId { get; set; }

	/// <summary>
	/// The time the event happened.
	/// </summary>
	public long EventDate { get; set; }

	/// <summary>
	/// The event's <see cref="P:Roblox.Platform.Notifications.Stream.NotificationStreamEventIdentifier.EventTarget" />.
	/// </summary>
	public EventTarget EventTarget { get; set; }
}
