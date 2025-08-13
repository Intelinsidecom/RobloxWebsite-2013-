using System;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Properties;

namespace Roblox.Platform.Groups;

public static class ClansFeatureVerifier
{
	public static bool IsFeatureEnabled(Func<bool> isSoothsayerGetter)
	{
		if (isSoothsayerGetter == null)
		{
			throw new PlatformArgumentNullException("isSoothsayerGetter");
		}
		if (Settings.Default.IsOverridingClansFeatureEnabledForSoothsayers && isSoothsayerGetter())
		{
			return Settings.Default.IsClansFeatureEnabledForSoothsayers;
		}
		return Settings.Default.IsClansFeatureEnabled;
	}
}
