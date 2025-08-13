using System;
using System.Web;
using Roblox.Configuration;
using Roblox.Marketing.Properties;

namespace Roblox.Marketing.BLL;

public class MarketingCookie
{
	private static string _Name = "RBXMarketing";

	public static string FirstHomePageVisitKey = "FirstHomePageVisit";

	public static string FirstVisitDateKey = "ts";

	public static string OneDayReturnKey = "odr";

	public static string SevenDayReturnKey = "sdr";

	public static RobloxCookie Get(HttpContext context)
	{
		return RobloxCookie.Get(context, _Name);
	}

	public static RobloxCookie GetOrCreate(HttpContext context)
	{
		RobloxCookie cookie = RobloxCookie.GetOrCreate(context, _Name, TimeSpan.FromDays(10000.0));
		if (Settings.Default.RBXMarketingCookieSetsDomain)
		{
			cookie.SetDomain(RobloxEnvironment.Domain);
		}
		return cookie;
	}
}
