using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

/// <summary>
/// A notification shown in the notification stream.
/// </summary>
public interface IStoredStreamNotification
{
	/// <summary>
	/// The notification's event target id. Used by the consumer subsystem to identify the content of this notification.
	/// </summary>
	EventTarget EventTargetId { get; }

	/// <summary>
	/// The date this notification was sent.
	/// </summary>
	DateTime EventDate { get; }
}
