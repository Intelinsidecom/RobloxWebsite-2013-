using System;
using System.Web;
using Roblox.Libraries.Cookies;
using Roblox.Marketing.Properties;
using Roblox.Web.Cookies;

namespace Roblox.Marketing.Tracking;

public static class AcquisitionHelper
{
	public static AcquisitionSource GetUserAcquisitionSource(HttpContext context)
	{
		if (Enum.TryParse<AcquisitionSource>(GetUserAcquisitionSourceString(context), ignoreCase: true, out var acquisitionSource))
		{
			return acquisitionSource;
		}
		return AcquisitionSource.Default;
	}

	public static string GetUserAcquisitionSourceString(HttpContext context)
	{
		string source = string.Empty;
		string medium = string.Empty;
		if (Settings.Default.UseSourceCookieForRBXSource)
		{
			SourceCookie cookie2 = RobloxCookieHelper.Get<SourceCookie>(SourceCookie.CookieIdentifier);
			if (cookie2 != null)
			{
				source = cookie2.Source;
				medium = cookie2.Medium;
			}
		}
		else
		{
			HttpCookie cookie = context.Request.Cookies.Get("RBXSource");
			if (cookie != null)
			{
				medium = cookie.Values["rbx_medium"];
				source = cookie.Values["rbx_source"];
			}
		}
		if (!string.IsNullOrEmpty(medium) && medium.ToLower().Equals("direct"))
		{
			source = "wom";
		}
		if (string.IsNullOrEmpty(source))
		{
			source = "wom";
		}
		return source.ToLower();
	}

	public static void HandleNewUserAcquisitionTracking(HttpContext context, long userId, byte platformTypeId)
	{
		if (Settings.Default.UseSourceCookieForRBXSource)
		{
			SourceCookie cookie = RobloxCookieHelper.Get<SourceCookie>(SourceCookie.CookieIdentifier);
			if (cookie != null)
			{
				UserAcquisition.CreateNew(userId, cookie.Medium, cookie.Source, cookie.Campaign, cookie.AcquisitionTime, cookie.AcquisitionReferrer, cookie.AdGroup, cookie.Keyword, cookie.MatchType, platformTypeId);
			}
			return;
		}
		HttpCookie cookie2 = context.Request.Cookies.Get("RBXSource");
		if (cookie2 != null)
		{
			string s = cookie2.Values["rbx_acquisition_time"];
			string acquisitionReferrer = cookie2.Values["rbx_acquisition_referrer"];
			string acquisitionMedium = cookie2.Values["rbx_medium"];
			string acquisitionSource = cookie2.Values["rbx_source"];
			string acquisitionCampaign = cookie2.Values["rbx_campaign"];
			string acquisitionAdGroup = cookie2.Values["rbx_adgroup"];
			string acquisitionKeyword = cookie2.Values["rbx_keyword"];
			string acquisitionMatchType = cookie2.Values["rbx_matchtype"];
			DateTime? acquisitionDateTime = null;
			if (DateTime.TryParse(s, out var parsedDateTime))
			{
				acquisitionDateTime = parsedDateTime;
			}
			UserAcquisition.CreateNew(userId, acquisitionMedium, acquisitionSource, acquisitionCampaign, acquisitionDateTime, acquisitionReferrer, acquisitionAdGroup, acquisitionKeyword, acquisitionMatchType, platformTypeId);
		}
	}

	public static void HandleNewUserAcquisitionTracking(string acquisitionSource, long userId, byte platformTypeId)
	{
		UserAcquisition.CreateNew(userId, acquisitionSource, acquisitionSource, null, DateTime.Now, null, null, null, null, platformTypeId);
	}

	public static void GetAcquisitionDataFromCookie(HttpContext context, out string acquisitionMedium, out string acquisitionSource, out string acquisitionCampaign)
	{
		acquisitionMedium = (acquisitionSource = (acquisitionCampaign = string.Empty));
		if (Settings.Default.UseSourceCookieForRBXSource)
		{
			SourceCookie cookie2 = RobloxCookieHelper.Get<SourceCookie>(SourceCookie.CookieIdentifier);
			if (cookie2 != null)
			{
				acquisitionMedium = cookie2.Medium ?? "";
				acquisitionSource = cookie2.Source ?? "";
				acquisitionCampaign = cookie2.Campaign ?? "";
			}
			return;
		}
		RobloxCookie cookie = RobloxCookie.Get(context, "RBXSource");
		if (cookie != null)
		{
			acquisitionMedium = cookie.GetValue("rbx_medium");
			if (acquisitionMedium == null)
			{
				acquisitionMedium = "";
			}
			acquisitionSource = cookie.GetValue("rbx_source");
			if (acquisitionSource == null)
			{
				acquisitionSource = "";
			}
			acquisitionCampaign = cookie.GetValue("rbx_campaign");
			if (acquisitionCampaign == null)
			{
				acquisitionCampaign = "";
			}
		}
	}
}
