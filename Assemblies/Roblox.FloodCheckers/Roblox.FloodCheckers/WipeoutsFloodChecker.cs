using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class WipeoutsFloodChecker : FloodChecker
{
	public WipeoutsFloodChecker(long userId)
		: base($"WipeoutsFloodChecker_UserId:{userId}", Settings.Default.WipeoutsFloodCheckerLimit, Settings.Default.WipeoutsFloodCheckerExpiry)
	{
	}
}
