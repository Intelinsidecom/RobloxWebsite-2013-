using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class TradeCurrencySubmissionFloodChecker : FloodChecker
{
	public TradeCurrencySubmissionFloodChecker(long userID)
		: base($"TradeCurrencySubmissionFloodChecker_UserID:{userID}", Settings.Default.TradeCurrencySubmissionFloodCheckerLimit, Settings.Default.TradeCurrencySubmissionFloodCheckerExpiry)
	{
	}
}
