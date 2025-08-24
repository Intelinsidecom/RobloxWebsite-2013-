using System;

namespace Roblox.Platform.XboxLive.Properties;

public interface IXboxLiveSettings
{
	bool XboxLiveSignupEnabled { get; }

	bool XboxLiveAccountLinkingEnabled { get; }

	TimeSpan XboxLiveAccountManagementLockTimeout { get; }
}
