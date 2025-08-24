using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ModifyEmailFloodChecker : FloodChecker
{
	public ModifyEmailFloodChecker(long userId)
		: base($"ModifyEmailFloodChecker_UserID:{userId}", Settings.Default.ModifyEmailFloodCheckLimit, Settings.Default.ModifyEmailFloodCheckExpiryHours)
	{
	}
}
