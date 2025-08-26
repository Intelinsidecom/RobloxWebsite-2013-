using Roblox.Platform.Core;
namespace Roblox.Marketingpublic {
    class UnknownBrowserTrackerException : PlatformException

{
	public UnknownBrowserTrackerException()
		: base("BrowserTracker was null or had id of 0.")
	{
	}
}


}
