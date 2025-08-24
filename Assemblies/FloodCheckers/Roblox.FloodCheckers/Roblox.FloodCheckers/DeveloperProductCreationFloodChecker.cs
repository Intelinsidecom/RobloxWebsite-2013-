using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class DeveloperProductCreationFloodChecker : FloodChecker
{
	public DeveloperProductCreationFloodChecker(long userId)
		: base($"DeveloperProductCreationFloodChecker_UserId:{userId}", Settings.Default.DeveloperProductCreationFloodCheckLimit, Settings.Default.DeveloperProductCreationFloodCheckExpiry)
	{
	}
}
