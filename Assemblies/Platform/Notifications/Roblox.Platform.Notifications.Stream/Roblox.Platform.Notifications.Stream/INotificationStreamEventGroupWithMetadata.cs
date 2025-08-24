using System;
using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface INotificationStreamEventGroupWithMetadata
{
	NotificationSourceType SourceType { get; }

	List<INotificationStreamEvent> Events { get; }

	DateTime EventDate { get; }

	long EventCount { get; }
}
