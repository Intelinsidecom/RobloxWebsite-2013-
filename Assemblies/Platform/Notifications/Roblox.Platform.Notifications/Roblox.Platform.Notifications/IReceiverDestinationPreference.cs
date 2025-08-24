using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface IReceiverDestinationPreference
{
	NotificationSourceType NotificationSourceType { get; }

	long DestinationId { get; }

	IReceiver Receiver { get; }

	bool IsEnabled { get; }
}
