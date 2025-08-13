using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.Notifications;

public interface IPushNotificationDestinationSettingGroup
{
	string Name { get; }

	PushPlatformType Platform { get; }

	long DestinationId { get; }

	bool IsEnabled { get; }

	bool IsSetByReceiver { get; }
}
