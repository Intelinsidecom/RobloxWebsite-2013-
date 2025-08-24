using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class KnockoutsFloodChecker : FloodChecker
{
	public KnockoutsFloodChecker(long userId)
		: base($"KnockoutsFloodChecker_UserId:{userId}", Settings.Default.KnockoutsFloodCheckerLimit, Settings.Default.KnockoutsFloodCheckerExpiry)
	{
	}
}
