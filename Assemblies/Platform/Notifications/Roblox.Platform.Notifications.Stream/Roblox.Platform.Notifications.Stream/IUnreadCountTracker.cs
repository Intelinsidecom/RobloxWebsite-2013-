using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface IUnreadCountTracker
{
	void Reset(IReceiver receiver);

	long GetCount(IReceiver receiver);

	void Increment(IReceiver receiver);

	bool DecrementIfNotificationWasUnread(IReceiver receiver, long notificationEventTicks);
}
