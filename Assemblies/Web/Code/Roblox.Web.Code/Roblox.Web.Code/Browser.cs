using System;
using System.Text.RegularExpressions;
using System.Web;
using Roblox.Common.Properties;
using Roblox.Web.Code.Properties;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code;

/// <summary>
/// NOTE:  You must check for a null UserAgent or unit tests will fail.
/// </summary>
public static class Browser
{
	public enum DeprecatedSystemType
	{
		Browser,
		MacOSX,
		iOS,
		None
	}

	/// <summary>
	/// This is a superset of ImplementsProxy.  This is all browsers that implement the proxy + the possibility that we're in studio.
	/// </summary>
	public static bool IsSupportedBrowser(HttpContext context)
	{
		if (!IsSupportedOS(context))
		{
			return false;
		}
		if (!ImplementsProxy(context))
		{
			return IsRobloxStudio(context);
		}
		return true;
	}

	public static DeprecatedSystemType DeprecatedSystemDialogType(HttpContext context)
	{
		if (Roblox.WebsiteSettings.Properties.Settings.Default.DeprecatedBrowserDialogEnabled)
		{
			if (IsDeprecatedBrowser(context))
			{
				return DeprecatedSystemType.Browser;
			}
			if (IsMac(context) && !IsSupportedMacOSXVersion(context))
			{
				return DeprecatedSystemType.MacOSX;
			}
			if (IsIOSDevice(context) && !IsSupportedIOSVersion(context))
			{
				return DeprecatedSystemType.iOS;
			}
		}
		return DeprecatedSystemType.None;
	}

	public static bool IsSupportedOS(HttpContext context)
	{
		if (IsWindows(context))
		{
			return true;
		}
		if (IsMac(context) && !string.IsNullOrEmpty(Roblox.Common.Properties.Settings.Default.ClientMacInstallUrl))
		{
			if (!IsSupportedMacOSXVersion(context))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool ImplementsProxy(HttpContext context)
	{
		if (IsWindows(context))
		{
			if (IsSupportedIE(context))
			{
				return true;
			}
			if (IsFirefox(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.FirefoxPluginIsEnabled;
			}
			if (IsChrome(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.ChromePluginIsEnabled;
			}
			if (IsSafari(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.WindowsSafariPluginIsEnabled;
			}
			if (IsOpera(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.WindowsOperaPluginEnabled;
			}
		}
		else if (IsMac(context))
		{
			if (IsSafari(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.SafariPluginIsEnabled;
			}
			if (IsFirefox(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.MacFirefoxPluginIsEnabled;
			}
			if (IsChrome(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.MacChromePluginIsEnabled;
			}
			if (IsOpera(context))
			{
				return Roblox.WebsiteSettings.Properties.Settings.Default.MacOperaPluginEnabled;
			}
		}
		return false;
	}

	public static bool IsDeprecatedBrowser(HttpContext context)
	{
		if (!IsIE7(context) && !IsIE8(context))
		{
			return IsIE9(context);
		}
		return true;
	}

	public static bool IsMac(HttpContext context)
	{
		if (Roblox.WebsiteSettings.Properties.Settings.Default.FixIOSMistakenForMac)
		{
			if (!string.IsNullOrEmpty(context.Request.UserAgent) && context.Request.UserAgent.ToLower().Contains("mac") && !IsIpad(context) && !IsIpod(context))
			{
				return !IsIphone(context);
			}
			return false;
		}
		if (!string.IsNullOrEmpty(context.Request.UserAgent) && context.Request.UserAgent.ToLower().Contains("mac"))
		{
			return !IsIpad(context);
		}
		return false;
	}

	public static bool IsSupportedMacOSXVersion(HttpContext context)
	{
		if (string.IsNullOrEmpty(context.Request.UserAgent))
		{
			return false;
		}
		if (IsIpad(context))
		{
			return false;
		}
		bool isSupportedMacOsXVersion = true;
		Match macOsXMatch = Regex.Match(context.Request.UserAgent, "mac os x 10[._](?<tenDotWhat>\\d+)", RegexOptions.IgnoreCase);
		if (macOsXMatch.Success)
		{
			int.TryParse(macOsXMatch.Groups["tenDotWhat"].Value, out var tenDotWhat);
			if (tenDotWhat < 6)
			{
				isSupportedMacOsXVersion = false;
			}
		}
		return isSupportedMacOsXVersion;
	}

	public static bool IsWindows(HttpContext context)
	{
		if (!string.IsNullOrEmpty(context.Request.UserAgent))
		{
			return context.Request.UserAgent.ToLower().Contains("windows");
		}
		return false;
	}

	public static bool IsWinXP(HttpContext context)
	{
		if (context.Request.UserAgent != null)
		{
			return context.Request.UserAgent.ToLower().Contains("windows nt 5.1");
		}
		return false;
	}

	public static bool IsWinVista(HttpContext context)
	{
		if (context.Request.UserAgent != null)
		{
			return context.Request.UserAgent.ToLower().Contains("windows nt 6.0");
		}
		return false;
	}

	public static bool IsIpad(HttpContext context)
	{
		if (context.Request.UserAgent != null)
		{
			return context.Request.UserAgent.ToLower().Contains("ipad");
		}
		return false;
	}

	public static bool IsIphone(HttpContext context)
	{
		return IsIphone(context.Request.UserAgent);
	}

	public static bool IsIphone(string userAgent)
	{
		return userAgent?.ToLower().Contains("iphone") ?? false;
	}

	public static bool IsIpod(HttpContext context)
	{
		return IsIpod(context.Request.UserAgent);
	}

	public static bool IsIpod(string userAgent)
	{
		return userAgent?.ToLower().Contains("ipod") ?? false;
	}

	public static bool IsIOSDevice(HttpContext context)
	{
		if (!IsIpad(context) && !IsIphone(context))
		{
			return IsIpod(context);
		}
		return true;
	}

	public static bool IsSupportedIOSVersion(HttpContext context)
	{
		if (string.IsNullOrEmpty(context.Request.UserAgent))
		{
			return false;
		}
		bool isSupportedIOSVersion = true;
		Match iOSMatch = Regex.Match(context.Request.UserAgent, "OS (?<iosVersion>\\d+)", RegexOptions.IgnoreCase);
		if (iOSMatch.Success)
		{
			int.TryParse(iOSMatch.Groups["iosVersion"].Value, out var osVersion);
			if (osVersion < 8)
			{
				isSupportedIOSVersion = false;
			}
		}
		return isSupportedIOSVersion;
	}

	public static bool IsMobileDevice(HttpContext context)
	{
		string u = context.Request.UserAgent;
		if (u != null)
		{
			string userAgent = u.ToLower();
			if (userAgent.Contains("mobile") || userAgent.Contains("phone"))
			{
				return !userAgent.Contains("ipad");
			}
			return false;
		}
		return false;
	}

	public static bool IsChrome(HttpContext context)
	{
		if (context.Request.UserAgent != null)
		{
			return IsChrome(context.Request.UserAgent);
		}
		return false;
	}

	public static bool IsChrome(string userAgent)
	{
		if (!string.IsNullOrEmpty(userAgent) && Regex.IsMatch(userAgent, "chrome", RegexOptions.IgnoreCase))
		{
			return !IsEdge(userAgent);
		}
		return false;
	}

	public static bool IsChromeAtLeastVersion(HttpContext context, int minVersion)
	{
		if (context.Request.UserAgent != null)
		{
			return IsChromeAtLeastVersion(context.Request.UserAgent, minVersion);
		}
		return false;
	}

	public static bool IsChromeAtLeastVersion(string userAgent, int minVersion)
	{
		if (string.IsNullOrEmpty(userAgent))
		{
			return false;
		}
		int? version = TryGetMajorChromeVersion(userAgent);
		if (version.HasValue)
		{
			return version.Value >= minVersion;
		}
		return false;
	}

	public static int? TryGetMajorChromeVersion(string userAgent)
	{
		string uaLower = userAgent.ToLower();
		if (!Roblox.Web.Code.Properties.Settings.Default.DoesChromeVersionDetectionExcludeEdge)
		{
			if (!uaLower.Contains("chrome"))
			{
				return null;
			}
		}
		else if (!IsChrome(userAgent))
		{
			return null;
		}
		string versionString = "";
		Match match = Regex.Match(uaLower, "chrome/(\\d+)", RegexOptions.IgnoreCase);
		if (match.Success)
		{
			versionString = match.Groups[1].Value;
		}
		int version = 0;
		if (!int.TryParse(versionString, out version))
		{
			return null;
		}
		return version;
	}

	public static bool IsFirefox(HttpContext context)
	{
		if (context.Request.UserAgent == null)
		{
			return false;
		}
		string useragent = context.Request.UserAgent.ToLower();
		if (useragent.Contains("firefox"))
		{
			return !useragent.Contains("chrome");
		}
		return false;
	}

	public static bool IsIE(HttpContext context)
	{
		if (context.Request.UserAgent != null)
		{
			if (!context.Request.UserAgent.ToLower().Contains("trident"))
			{
				return context.Request.UserAgent.ToLower().Contains("msie");
			}
			return true;
		}
		if (context.Request.Browser != null)
		{
			return context.Request.Browser.ActiveXControls;
		}
		return false;
	}

	public static bool IsSupportedIE(HttpContext context)
	{
		if (IsIE(context) && !context.Request.UserAgent.ToLower().Contains("win64"))
		{
			if (!Roblox.Web.Code.Properties.Settings.Default.LaunchGamesFromIE11Enabled)
			{
				return !IsIE11(context);
			}
			return true;
		}
		return false;
	}

	public static bool IsIE6(HttpContext context)
	{
		if (context.Request.Browser.Type == "IE6")
		{
			return !context.Request.UserAgent.Contains("SV1");
		}
		return false;
	}

	public static bool IsIE7(HttpContext context)
	{
		return context.Request.Browser.Type == "IE7";
	}

	public static bool IsIE8(HttpContext context)
	{
		return context.Request.Browser.Type == "IE8";
	}

	public static bool IsNewVersionOfIE(HttpContextBase context, int ieMajorVersion)
	{
		bool num = context.Request.Browser.Browser.Equals("IE", StringComparison.OrdinalIgnoreCase) || context.Request.Browser.Browser.Equals("InternetExplorer", StringComparison.OrdinalIgnoreCase);
		float detectedMajorVersion = -1f;
		float.TryParse(context.Request.Browser.Version, out detectedMajorVersion);
		if (!num || detectedMajorVersion.ToUInt32() >= ieMajorVersion)
		{
			return true;
		}
		return false;
	}

	public static bool IsIE9(HttpContext context)
	{
		if (IsIE(context))
		{
			return context.Request.UserAgent.ToLower().Contains("msie 9");
		}
		return false;
	}

	public static bool IsIE10(HttpContext context)
	{
		if (IsIE(context))
		{
			return context.Request.UserAgent.ToLower().Contains("msie 10");
		}
		return false;
	}

	public static bool IsIE11(HttpContext context)
	{
		if (IsIE(context))
		{
			return Regex.IsMatch(context.Request.UserAgent, "rv[: ]\\d+", RegexOptions.IgnoreCase);
		}
		return false;
	}

	public static bool IsEdgeChromium(HttpContext context)
	{
		if (context != null)
		{
			return IsEdgeChromium(context.Request.UserAgent);
		}
		return false;
	}

	public static bool IsEdgeChromium(string userAgent)
	{
		if (!string.IsNullOrEmpty(userAgent) && Regex.IsMatch(userAgent, " Edg/\\d+", RegexOptions.IgnoreCase))
		{
			return !IsEdge(userAgent);
		}
		return false;
	}

	public static bool IsEdge(HttpContext context)
	{
		if (context != null)
		{
			return IsEdge(context.Request.UserAgent);
		}
		return false;
	}

	public static bool IsEdge(string userAgent)
	{
		if (!string.IsNullOrEmpty(userAgent))
		{
			return Regex.IsMatch(userAgent, " Edge/\\d+", RegexOptions.IgnoreCase);
		}
		return false;
	}

	public static bool IsOpera(HttpContext context)
	{
		if (context.Request.UserAgent == null)
		{
			return false;
		}
		return context.Request.UserAgent.ToLower().Contains("opera");
	}

	public static bool IsSafari(HttpContext context)
	{
		if (context.Request.UserAgent == null || context.Request.Browser == null)
		{
			return false;
		}
		if (context.Request.Browser.Browser.ToLower().Contains("safari"))
		{
			return !context.Request.UserAgent.ToLower().Contains("chrome");
		}
		return false;
	}

	public static bool IsSafari(string userAgent)
	{
		userAgent = userAgent?.ToLower();
		if (userAgent != null && userAgent.Contains("safari") && !userAgent.Contains("chrome"))
		{
			return !userAgent.Contains("crios");
		}
		return false;
	}

	[Obsolete("Please use IClientDeviceIdentifier.IsRobloxStudio")]
	public static bool IsRobloxStudio(HttpContext context)
	{
		string userAgent = context.Request.UserAgent ?? string.Empty;
		if (!Roblox.Web.Code.Properties.Settings.Default.IsConsiderUnifiedStudioUserAgentEnabled || (!userAgent.Equals("RobloxStudio/WinInet") && !userAgent.Equals("RobloxStudio/Darwin")))
		{
			return context.Request.Browser.Browser.Equals("RobloxStudio");
		}
		return true;
	}

	[Obsolete("Please use IClientDeviceIdentifier.IsRoblox")]
	public static bool IsRoblox(string userAgent)
	{
		return userAgent?.ToLower().Contains("roblox") ?? false;
	}

	public static BrowserType GetBrowser(HttpContext context)
	{
		if (IsEdgeChromium(context))
		{
			return BrowserType.EdgeChromium;
		}
		if (IsEdge(context))
		{
			return BrowserType.Edge;
		}
		if (IsIE(context))
		{
			return BrowserType.IE;
		}
		if (IsFirefox(context))
		{
			return BrowserType.Firefox;
		}
		if (IsSafari(context))
		{
			return BrowserType.Safari;
		}
		if (IsChrome(context))
		{
			return BrowserType.Chrome;
		}
		if (IsOpera(context))
		{
			return BrowserType.Opera;
		}
		return BrowserType.Unknown;
	}

	public static bool IsKnownBrowser(HttpContext context)
	{
		return GetBrowser(context) != BrowserType.Unknown;
	}
}
