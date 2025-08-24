using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface IReceiverNotificationSettingsGroup
{
	NotificationSourceType NotificationSourceType { get; }

	ReceiverDestinationType ReceiverDestinationType { get; }

	bool IsEnabled { get; }

	bool IsOverridable { get; }

	bool IsSetByReceiver { get; }

	ICollection<IPushNotificationDestinationSettingGroup> PushNotificationDestinationPreferences { get; }
}
