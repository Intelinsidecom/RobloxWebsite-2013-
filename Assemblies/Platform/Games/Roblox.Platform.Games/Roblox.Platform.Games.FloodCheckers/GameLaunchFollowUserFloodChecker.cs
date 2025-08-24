using Roblox.FloodCheckers;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games.FloodCheckers;

public class GameLaunchFollowUserFloodChecker : FloodChecker
{
	public GameLaunchFollowUserFloodChecker(long followerUserId)
		: base($"GameLaunchFloodChecker_FollowUser_FollowerUserId:{followerUserId}", Settings.Default.GameLaunchFollowUserFloodCheckLimit, Settings.Default.GameLaunchFollowUserFloodCheckExpiry)
	{
	}
}
