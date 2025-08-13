using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ShowPrerollFloodChecker : FloodChecker
{
	public ShowPrerollFloodChecker(long userId)
		: base($"ShowPreroll_UserID:{userId}", Settings.Default.ShowPrerollFloodCheckLimit, Settings.Default.ShowPrerollFloodCheckExpiry)
	{
	}
}
