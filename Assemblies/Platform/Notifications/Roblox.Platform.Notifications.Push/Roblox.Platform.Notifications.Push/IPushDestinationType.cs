using System;

namespace Roblox.Platform.Notifications.Push;

public interface IPushDestinationType
{
	int ID { get; }

	PushApplicationType ApplicationType { get; }

	PushPlatformType PlatformType { get; }

	string RegistrationEndpoint { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
