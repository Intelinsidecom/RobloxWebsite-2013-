using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public interface IReceiverDestinationTypeOptOut
{
	IReceiver Receiver { get; }

	ReceiverDestinationType ReceiverDestinationType { get; }
}
