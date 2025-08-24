using Roblox.Platform.Membership;

namespace Roblox.Platform.XboxLive;

public static class XboxLiveExtensions
{
	public static bool IsXboxLiveUser(this IUser user, XboxLiveUserManager userManager)
	{
		return userManager.IsXboxLiveUser(user);
	}

	public static bool IsXboxGamerTagValid(this IUser user, string gamerTag, XboxLiveUserManager userManager)
	{
		return userManager.IsXboxGamerTagValid(user, gamerTag);
	}
}
