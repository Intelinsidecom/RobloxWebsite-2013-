using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class UserPlaceJoinRequestFloodChecker : FloodChecker
{
	public UserPlaceJoinRequestFloodChecker(long userId)
		: base($"UserPlaceJoinRequestFloodChecker_UserId:{userId}", Settings.Default.UserPlaceJoinRequestFloodCheckLimit, Settings.Default.UserPlaceJoinRequestFloodCheckExpiry, Settings.Default.UserPlaceJoinRequestFloodCheckEnabled, "UserPlaceJoinRequestFloodCheck")
	{
	}
}
