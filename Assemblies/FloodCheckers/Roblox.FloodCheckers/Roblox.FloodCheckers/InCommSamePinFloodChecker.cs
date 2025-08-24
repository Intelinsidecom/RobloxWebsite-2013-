using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class InCommSamePinFloodChecker : FloodChecker
{
	public InCommSamePinFloodChecker(string inCommPin)
		: base("GamecardRedemption", $"GamecardRedemptionFloodChecker_Pin:{inCommPin}", Settings.Default.InCommSamePinFloodCheckLimit, Settings.Default.InCommSamePinFloodCheckExpiry, Settings.Default.InCommSamePinFloodCheckEnabled)
	{
	}
}
