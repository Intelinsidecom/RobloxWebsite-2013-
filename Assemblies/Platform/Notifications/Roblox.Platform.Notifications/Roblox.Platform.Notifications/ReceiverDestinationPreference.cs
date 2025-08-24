using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal class ReceiverDestinationPreference : IReceiverDestinationPreference
{
	public NotificationSourceType NotificationSourceType { get; internal set; }

	public long DestinationId { get; internal set; }

	public IReceiver Receiver { get; internal set; }

	public bool IsEnabled { get; internal set; }
}
