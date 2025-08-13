using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public class NotificationReceiverResolverRegistry : INotificationReceiverResolverRegistry
{
	private IDictionary<NotificationSourceType, INotificationReceiverResolver> MessageToReceiverRegistry = new Dictionary<NotificationSourceType, INotificationReceiverResolver>();

	private readonly Func<ILogger> _GetLogger;

	public NotificationReceiverResolverRegistry()
		: this(() => Accessors.Logger)
	{
	}

	public NotificationReceiverResolverRegistry(Func<ILogger> getLogger)
	{
		_GetLogger = getLogger ?? throw new ArgumentNullException("getLogger");
	}

	public void RegisterReceiverResolverForType(INotificationReceiverResolver receiverResolverGetter)
	{
		if (receiverResolverGetter == null)
		{
			throw new PlatformArgumentNullException("receiverResolverGetter");
		}
		MessageToReceiverRegistry[receiverResolverGetter.NotificationSourceType] = receiverResolverGetter;
	}

	public ICollection<IReceiver> GetNotificationReceivers(INotification message)
	{
		if (!MessageToReceiverRegistry.ContainsKey(message.SourceType))
		{
			_GetLogger()?.Error("The following source type does not have a corresponding receiver resolver, but someone attempted to resolve receivers anyways: ", message.SourceType);
			return new List<IReceiver>();
		}
		return MessageToReceiverRegistry[message.SourceType].GetReceiverForMessages(message);
	}
}
