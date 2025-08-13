using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class XboxLiveAccountCreationFloodChecker : FloodChecker
{
	public XboxLiveAccountCreationFloodChecker(string pairwiseId)
		: base($"XboxLiveAccountCreationFloodChecker_PairwiseId:{pairwiseId}", Settings.Default.XboxLiveAccountCreationLimit, Settings.Default.XboxLiveAccountCreationExpiry)
	{
	}
}
