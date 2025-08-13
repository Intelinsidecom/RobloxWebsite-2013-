using System;
using System.Web;
using Roblox.Marketing;
using Roblox.Platform.Marketing;

namespace Roblox.Web.Code.Marketing;

[Obsolete("Use Roblox.Web.Marketing instead")]
public static class PlatformMarketingHelper
{
	public static IBrowserTracker GetBrowserTracker(HttpContext context)
	{
		long? browserTrackerId = MarketingHelper.GetBrowserTrackerID(context);
		IBrowserTracker browserTracker = null;
		if (browserTrackerId.HasValue)
		{
			browserTracker = FactoryProvider.BrowserTrackerFactory.Get(browserTrackerId.Value);
		}
		return browserTracker;
	}
}
