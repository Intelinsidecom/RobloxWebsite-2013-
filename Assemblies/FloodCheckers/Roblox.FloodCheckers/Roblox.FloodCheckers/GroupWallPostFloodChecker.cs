using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class GroupWallPostFloodChecker : FloodChecker
{
	public GroupWallPostFloodChecker(long userId)
		: base($"GroupWallPostFloodChecker_UserID:{userId}", Settings.Default.GroupWallPostFloodCheckLimit, Settings.Default.GroupWallPostFloodCheckExpiry)
	{
	}
}
