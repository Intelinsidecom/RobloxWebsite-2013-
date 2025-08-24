using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.Notifications;

internal class PushNotificationDestinationSettingGroup : IPushNotificationDestinationSettingGroup
{
	public long DestinationId { get; set; }

	public bool IsEnabled { get; set; }

	public bool IsSetByReceiver { get; set; }

	public string Name { get; set; }

	public PushPlatformType Platform { get; set; }
}
