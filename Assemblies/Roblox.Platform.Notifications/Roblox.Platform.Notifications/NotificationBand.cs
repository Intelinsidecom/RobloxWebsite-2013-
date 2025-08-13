using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal class NotificationBand : INotificationBand
{
	public int Id { get; internal set; }

	public NotificationSourceType NotificationSourceType { get; internal set; }

	public ReceiverDestinationType ReceiverDestinationType { get; internal set; }

	public bool IsEnabledByDefault { get; internal set; }

	public bool IsOverridable { get; internal set; }
}
