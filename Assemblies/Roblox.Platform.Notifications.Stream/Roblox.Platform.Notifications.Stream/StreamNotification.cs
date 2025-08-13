using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

internal class StreamNotification : IStreamNotification
{
	public NotificationSourceType SourceType { get; set; }

	public string Category { get; set; }

	public EventTarget EventTargetId { get; set; }

	public DateTime EventDate { get; set; }

	public object Detail { get; set; }
}
