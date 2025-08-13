using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class VoteIPFloodChecker : FloodChecker
{
	public VoteIPFloodChecker(string ipAddress)
		: base($"VoteFloodChecker_IPAddress:{ipAddress}", Settings.Default.VoteIPFloodCheckLimit, Settings.Default.VoteIPFloodCheckExpiry)
	{
	}
}
