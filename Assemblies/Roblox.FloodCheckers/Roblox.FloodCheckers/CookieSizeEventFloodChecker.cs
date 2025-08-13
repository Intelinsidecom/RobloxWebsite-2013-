using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class CookieSizeEventFloodChecker : FloodChecker
{
	public CookieSizeEventFloodChecker(string clientIp)
		: base($"CookieSizeEventFloodChecker_IPAddress:{clientIp}", 1, TimeSpan.FromMinutes(20.0), Settings.Default.EnableCookieSizeEventFloodChecker)
	{
	}
}
