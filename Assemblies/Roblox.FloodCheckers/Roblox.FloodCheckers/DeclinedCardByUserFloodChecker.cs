using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class DeclinedCardByUserFloodChecker : FloodChecker
{
	public DeclinedCardByUserFloodChecker(long userId)
		: base($"DeclinedCardByUserFloodChecker_UserId:{userId}", Settings.Default.DeclinedCardByUserFloodCheckLimit, Settings.Default.DeclinedCardByUserFloodCheckExpiry)
	{
	}
}
