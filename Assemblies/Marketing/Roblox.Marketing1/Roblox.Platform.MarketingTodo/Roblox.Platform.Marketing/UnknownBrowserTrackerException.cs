using Roblox.Platform.Core;

namespace Roblox.Platform.Marketing;

public class UnknownBrowserTrackerException : PlatformException
{
	public UnknownBrowserTrackerException()
		: base("BrowserTracker was null or had id of 0.")
	{
	}
}
