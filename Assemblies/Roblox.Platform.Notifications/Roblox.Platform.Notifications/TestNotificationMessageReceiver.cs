using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public class TestNotificationMessageReceiver : INotificationReceiverResolver
{
	public NotificationSourceType NotificationSourceType => NotificationSourceType.Test;

	public ICollection<IReceiver> GetReceiverForMessages(INotification message)
	{
		if (!(message is TestNotification testMessage))
		{
			throw new PlatformArgumentException("Type mismatch: supplied message is not a TestNotificationMessage");
		}
		IReceiver receiver = Roblox.Platform.Notifications.Core.Accessors.ReceiverAccessor.GetByReceiverTypeAndTarget(ReceiverType.User, testMessage.Generator.GeneratorId);
		return new List<IReceiver> { receiver };
	}
}
