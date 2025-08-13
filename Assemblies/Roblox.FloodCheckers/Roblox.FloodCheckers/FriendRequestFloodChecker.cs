using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class FriendRequestFloodChecker : FloodChecker
{
	public FriendRequestFloodChecker(long userId)
		: base($"FriendRequestFloodChecker_UserId:{userId}", Settings.Default.FriendRequestFloodCheckerLimit, Settings.Default.FriendRequestFloodCheckerExpiry)
	{
	}
}
