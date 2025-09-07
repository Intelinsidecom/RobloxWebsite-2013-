using System;
using System.Web;
using Roblox.Platform.Marketing;
using Roblox.Marketing;

namespace Roblox.Web.Code.Marketing;

[Obsolete("Use Roblox.Web.Marketing instead")]
public static class PlatformMarketingHelper
{
	public static Roblox.Platform.Marketing.IBrowserTracker GetBrowserTracker(HttpContext context)
	{
		long? browserTrackerId = MarketingHelper.GetBrowserTrackerID(context);
		Roblox.Platform.Marketing.IBrowserTracker browserTracker = null;
		if (browserTrackerId.HasValue)
		{
			browserTracker = FactoryProvider.BrowserTrackerFactory.Get(browserTrackerId.Value);
		}
		return browserTracker;
	}
}
