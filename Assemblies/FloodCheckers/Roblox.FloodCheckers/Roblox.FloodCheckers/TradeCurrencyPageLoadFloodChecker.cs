using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class TradeCurrencyPageLoadFloodChecker : FloodChecker
{
	public TradeCurrencyPageLoadFloodChecker(long userID)
		: base($"TradeCurrencyPageLoadFloodChecker_UserID:{userID}", Settings.Default.TradeCurrencyPageLoadFloodCheckerLimit, Settings.Default.TradeCurrencyPageLoadFloodCheckerExpiry)
	{
	}
}
