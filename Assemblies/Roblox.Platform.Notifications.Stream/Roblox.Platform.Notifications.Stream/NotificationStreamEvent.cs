using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.Notifications.Stream.INotificationStreamEvent" />.
/// </summary>
internal class NotificationStreamEvent : INotificationStreamEvent
{
	/// <inheritdoc />
	public Guid EventId { get; set; }

	/// <inheritdoc />
	public EventTarget EventTargetId { get; set; }

	/// <inheritdoc />
	public bool IsInteracted { get; set; }
}
