using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal class ReceiverDestinationTypeOptOut : IReceiverDestinationTypeOptOut
{
	public IReceiver Receiver { get; internal set; }

	public ReceiverDestinationType ReceiverDestinationType { get; internal set; }
}
