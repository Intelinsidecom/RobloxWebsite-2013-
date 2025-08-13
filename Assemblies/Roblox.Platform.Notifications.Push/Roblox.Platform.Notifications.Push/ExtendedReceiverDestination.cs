using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

internal class ExtendedReceiverDestination : IExtendedReceiverDestination
{
	public IReceiverDestinationEntity ReceiverDestination { get; set; }

	public IDestinationEntity Destination { get; set; }

	public IDestinationTypeEntity DestinationType { get; set; }

	public PushPlatformType PlatformType { get; set; }

	public PushApplicationType ApplicationType { get; set; }
}
