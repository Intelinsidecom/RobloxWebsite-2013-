using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface INotificationReceiverResolverRegistry
{
	void RegisterReceiverResolverForType(INotificationReceiverResolver receiverResolverGetter);

	ICollection<IReceiver> GetNotificationReceivers(INotification message);
}
