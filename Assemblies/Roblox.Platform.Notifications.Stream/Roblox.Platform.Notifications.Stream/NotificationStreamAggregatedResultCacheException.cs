using System;

namespace Roblox.Platform.Notifications.Stream;

internal class NotificationStreamAggregatedResultCacheException : Exception
{
	public NotificationStreamAggregatedResultCacheException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
