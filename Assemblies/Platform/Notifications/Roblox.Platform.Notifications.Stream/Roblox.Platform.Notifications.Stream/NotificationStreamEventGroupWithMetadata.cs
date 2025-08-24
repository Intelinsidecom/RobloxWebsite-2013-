using System;
using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

internal class NotificationStreamEventGroupWithMetadata : INotificationStreamEventGroupWithMetadata
{
	public long EventCount { get; set; }

	public DateTime EventDate { get; set; }

	public List<INotificationStreamEvent> Events { get; set; }

	public NotificationSourceType SourceType { get; set; }
}
