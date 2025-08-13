using System.Web;

namespace Roblox.Marketing.Tracking;

public static class JavaScriptEventManager
{
	public static string GetCardRedemptionEventJavaScript(string merchant, decimal balance)
	{
		return $"(function() {{ RobloxEventManager.triggerEvent('rbx_evt_card_redemption', {{ merchant: '{merchant}', cardValue: '{balance.ToString()}'}}); }}());";
	}

	public static string GetCPCEventJavascriptFromContext(HttpContext context, string eventType)
	{
		string acquisitionMedium = "";
		string acquisitionSource = "";
		string acquisitionCampaign = "";
		AcquisitionHelper.GetAcquisitionDataFromCookie(context, out acquisitionMedium, out acquisitionSource, out acquisitionCampaign);
		acquisitionSource = ((!(acquisitionMedium == "Direct") && !(acquisitionSource == "")) ? "Paid" : "Free");
		return GetGenericEventJavascript(eventType, acquisitionSource, "");
	}

	public static string GetGenericEventJavascript(string eventType, string optData1, string optData2)
	{
		string jsTrackingScript = "$(function() { RobloxEventManager.triggerEvent('rbx_evt_generic', { ";
		if (!string.IsNullOrEmpty(eventType))
		{
			jsTrackingScript += $"type: '{eventType}'";
		}
		if (!string.IsNullOrEmpty(optData1))
		{
			jsTrackingScript += $", opt1: '{optData1}'";
		}
		if (!string.IsNullOrEmpty(optData2) && !string.IsNullOrEmpty(optData1))
		{
			jsTrackingScript += $", opt2: '{optData2}'";
		}
		return jsTrackingScript + "}); });";
	}

	public static string GetUCCEventJavascript(HttpContext context)
	{
		string acquisitionMedium = "";
		string acquisitionSource = "";
		string acquisitionCampaign = "";
		AcquisitionHelper.GetAcquisitionDataFromCookie(context, out acquisitionMedium, out acquisitionSource, out acquisitionCampaign);
		return $"$(function() {{ RobloxEventManager.triggerEvent('rbx_evt_source_tracking', {{ source: '{acquisitionSource}', campaign: '{acquisitionCampaign}', medium: '{acquisitionMedium}' }}); }});";
	}

	public static string GetCustomPageVisitEventJavaScript(string page)
	{
		string robloxEventName = "rbx_evt_pageview_custom";
		string pageName = page + " Page";
		return $"$(function() {{ RobloxEventManager.triggerEvent('{robloxEventName}', {{ page: '{pageName}' }}); }});";
	}

	public static string GetCustomAuthenticatedPageVisitEventJavaScript(string page, User authenticatedUser)
	{
		string robloxEventName = "rbx_evt_pageview_custom";
		string pageName = page + " Page";
		string userType = ((authenticatedUser == null) ? "Guest" : "User");
		return $"$(function() {{ RobloxEventManager.triggerEvent('{robloxEventName}', {{ page: '{pageName}', userType: '{userType}' }}); }});";
	}
}
