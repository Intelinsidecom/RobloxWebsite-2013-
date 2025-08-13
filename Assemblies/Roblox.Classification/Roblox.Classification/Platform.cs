using System;
using System.Web;
using Roblox.Classification.Properties;
using Roblox.EventLog;

namespace Roblox.Classification;

[Obsolete("Use the Roblox.Platform.Devices implementation instead.", false)]
public static class Platform
{
	[Obsolete("Use the Roblox.Platform.Devices implementation instead.", false)]
	public static byte DetectPlatform(HttpContext context)
	{
		return DetectPlatform(context.Request.UserAgent);
	}

	[Obsolete("Use the Roblox.Platform.Devices implementation instead.", false)]
	public static byte DetectPlatform(string userAgent)
	{
		if (string.IsNullOrEmpty(userAgent))
		{
			return PlatformType.UnknownID;
		}
		string uaString = userAgent.ToLower();
		if (uaString.Contains("windows") || uaString.Contains("wininet"))
		{
			return PlatformType.PCID;
		}
		if (uaString.Contains("ipad1"))
		{
			return PlatformType.iPad1ID;
		}
		if (uaString.Contains("ipad2"))
		{
			return PlatformType.iPad2ID;
		}
		if (uaString.Contains("ipad3"))
		{
			return PlatformType.iPad3ID;
		}
		if (uaString.Contains("iphone1"))
		{
			return PlatformType.iPhone3GID;
		}
		if (uaString.Contains("iphone2"))
		{
			return PlatformType.iPhone3GSID;
		}
		if (uaString.Contains("iphone3"))
		{
			return PlatformType.iPhone4ID;
		}
		if (uaString.Contains("iphone4"))
		{
			return PlatformType.iPhone4SID;
		}
		if (uaString.Contains("iphone5"))
		{
			return PlatformType.iPhone5ID;
		}
		if (uaString.Contains("iphone6"))
		{
			return PlatformType.iPhone6ID;
		}
		if (uaString.Contains("ipod3"))
		{
			return PlatformType.iPodTouch3GID;
		}
		if (uaString.Contains("ipod4"))
		{
			return PlatformType.iPodTouch4GID;
		}
		if (uaString.Contains("ipod5"))
		{
			return PlatformType.iPodTouch5GID;
		}
		if (uaString.Contains("ipod") || uaString.Contains("iphone"))
		{
			return PlatformType.iOSUnknownPhoneID;
		}
		if (uaString.Contains("ipad"))
		{
			return PlatformType.iOSUnknownTabletID;
		}
		if (uaString.Contains("ios"))
		{
			return PlatformType.iOSUnknownID;
		}
		if (uaString.Contains("mac"))
		{
			return PlatformType.MacID;
		}
		if (uaString.Contains("android"))
		{
			if (uaString.Contains("mobile"))
			{
				return PlatformType.AndroidUnknownPhoneID;
			}
			return PlatformType.AndroidUnknownTabletID;
		}
		if (uaString.Contains("xbox"))
		{
			return PlatformType.XboxOneID;
		}
		if (Settings.Default.LogUnknownPlatforms)
		{
			ExceptionHandler.LogException("Unknown platform detected: " + userAgent, LogLevel.Information);
		}
		return PlatformType.UnknownID;
	}
}
