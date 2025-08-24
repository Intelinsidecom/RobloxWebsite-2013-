using System;
using Roblox.Platform.Core;
using Roblox.Platform.Groups.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Groups;

public static class GroupWallPostsFeatureVerifier
{
	public static bool IsFeatureEnabled(IUser user)
	{
		return IsFeatureEnabled(() => user != null && user.IsSoothSayer());
	}

	public static bool IsFeatureEnabled(User user)
	{
		return IsFeatureEnabled(() => user != null && user.TestIsSoothsayer());
	}

	public static bool IsFeatureEnabled(Func<bool> isSoothsayerGetter)
	{
		if (isSoothsayerGetter == null)
		{
			throw new PlatformArgumentNullException("isSoothsayerGetter");
		}
		if (Settings.Default.IsOverridingGroupWallPostsFeatureEnabledForSoothsayers && isSoothsayerGetter())
		{
			return Settings.Default.IsGroupWallPostsFeatureEnabledForSoothsayers;
		}
		return Settings.Default.IsGroupWallPostsFeatureEnabled;
	}
}
