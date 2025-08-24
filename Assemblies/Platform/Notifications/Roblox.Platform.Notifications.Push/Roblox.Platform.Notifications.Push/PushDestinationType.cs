using System;

namespace Roblox.Platform.Notifications.Push;

internal class PushDestinationType : IPushDestinationType
{
	public int ID { get; set; }

	public PushApplicationType ApplicationType { get; set; }

	public PushPlatformType PlatformType { get; set; }

	public string RegistrationEndpoint { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }
}
