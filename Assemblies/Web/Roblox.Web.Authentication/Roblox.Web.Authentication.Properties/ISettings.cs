using System;

namespace Roblox.Web.Authentication.Properties;

public interface ISettings
{
	TimeSpan WebSessionTokenTimeToLive { get; }

	string AuthCookieDoNotShareWarning { get; }
}
