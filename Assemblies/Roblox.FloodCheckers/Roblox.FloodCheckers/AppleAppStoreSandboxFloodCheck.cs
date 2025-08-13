using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AppleAppStoreSandboxFloodCheck : FloodChecker
{
	public AppleAppStoreSandboxFloodCheck()
		: base("AppleAppStoreSandboxFloodCheck", Settings.Default.AppleAppStoreSandboxLimitPerHour, new TimeSpan(1, 0, 0))
	{
	}
}
