using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class TeleportFloodChecker : FloodChecker
{
	public TeleportFloodChecker(long playerId)
		: base($"TeleportFloodChecker_Player:{playerId}", Settings.Default.TeleportPlaceJoinRequestFloodCheckLimit, Settings.Default.TeleportPlaceJoinRequestFloodCheckExpiry)
	{
	}
}
