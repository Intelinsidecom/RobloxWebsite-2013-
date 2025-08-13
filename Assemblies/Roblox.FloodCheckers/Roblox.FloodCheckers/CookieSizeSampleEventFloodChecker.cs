using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class CookieSizeSampleEventFloodChecker : FloodChecker
{
	public CookieSizeSampleEventFloodChecker(string clientIp)
		: base($"CookieSizeSampleEventFloodChecker_IPAddress:{clientIp}", 1, TimeSpan.FromMinutes(20.0), Settings.Default.EnableCookieSizeSampleEventFloodChecker)
	{
	}
}
