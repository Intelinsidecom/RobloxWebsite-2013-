using System;
using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

internal class NotificationStreamEventGroup
{
	public NotificationSourceType SourceType { get; set; }

	public List<NotificationStreamEvent> Events { get; set; }

	public DateTime EventDate { get; set; }

	public long EventCount { get; set; }
}
