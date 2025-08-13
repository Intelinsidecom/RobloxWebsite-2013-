using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

public class PushDomainFactory
{
	internal virtual IReceiverDestinationEntityFactory ReceiverDestinationEntityFactory { get; }

	internal virtual IDestinationEntityFactory DestinationEntityFactory { get; }

	internal virtual IDestinationTypeEntityFactory DestinationTypeEntityFactory { get; }

	internal virtual IApplicationTypeEntityFactory ApplicationTypeEntityFactory { get; }

	internal virtual IAuthenticationTypeEntityFactory AuthenticationTypeEntityFactory { get; }

	internal virtual IPlatformTypeEntityFactory PlatformTypeEntityFactory { get; }

	internal virtual IReceiverTypeEntityFactory ReceiverTypeEntityFactory { get; }

	public PushDomainFactory()
	{
		ReceiverDestinationEntityFactory = new ReceiverDestinationEntityFactory();
		DestinationEntityFactory = new DestinationEntityFactory();
		DestinationTypeEntityFactory = new DestinationTypeEntityFactory();
		ApplicationTypeEntityFactory = new ApplicationTypeEntityFactory();
		AuthenticationTypeEntityFactory = new AuthenticationTypeEntityFactory();
		PlatformTypeEntityFactory = new PlatformTypeEntityFactory();
		ReceiverTypeEntityFactory = new ReceiverTypeEntityFactory();
	}
}
