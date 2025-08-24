using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Implementation;

internal class ReceiverNotificationSettingsGroup : IReceiverNotificationSettingsGroup
{
	public bool IsEnabled { get; set; }

	public bool IsOverridable { get; set; }

	public bool IsSetByReceiver { get; set; }

	public NotificationSourceType NotificationSourceType { get; set; }

	public ICollection<IPushNotificationDestinationSettingGroup> PushNotificationDestinationPreferences { get; private set; }

	public ReceiverDestinationType ReceiverDestinationType { get; set; }

	public ReceiverNotificationSettingsGroup()
	{
		PushNotificationDestinationPreferences = new List<IPushNotificationDestinationSettingGroup>();
	}
}
