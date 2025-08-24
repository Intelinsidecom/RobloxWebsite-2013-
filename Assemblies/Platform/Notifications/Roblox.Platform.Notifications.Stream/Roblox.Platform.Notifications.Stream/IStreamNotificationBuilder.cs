using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface IStreamNotificationBuilder : INotificationBuilder
{
	IStreamNotification BuildNotification(IStoredStreamNotification storedNotification);
}
