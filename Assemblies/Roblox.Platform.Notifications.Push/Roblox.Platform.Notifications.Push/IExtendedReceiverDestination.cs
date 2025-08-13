using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

internal interface IExtendedReceiverDestination
{
	IReceiverDestinationEntity ReceiverDestination { get; }

	IDestinationEntity Destination { get; }

	IDestinationTypeEntity DestinationType { get; }

	PushPlatformType PlatformType { get; }

	PushApplicationType ApplicationType { get; }
}
