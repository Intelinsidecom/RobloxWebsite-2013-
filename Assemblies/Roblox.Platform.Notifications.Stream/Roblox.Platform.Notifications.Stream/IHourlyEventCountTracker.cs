using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

internal interface IHourlyEventCountTracker
{
	void Increment(IReceiver receiver, NotificationSourceType sourceType, DateTime eventDateTime);

	void Decrement(IReceiver receiver, NotificationSourceType sourceType, DateTime eventDateTime);

	long GetCount(IReceiver receiver, NotificationSourceType sourceType, DateTime startDateTime, int hoursToInclude);
}
