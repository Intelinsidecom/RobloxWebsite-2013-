using Roblox.FloodCheckers;
using Roblox.Platform.AccountPins.Properties;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Flood checker for inputting Account Pins.
/// </summary>
/// <seealso cref="T:Roblox.FloodCheckers.FloodChecker" />
internal class AccountPinInputFloodChecker : FloodChecker
{
	public AccountPinInputFloodChecker(long accountId, string sessionIdString)
		: base($"AccountPinInputFloodChecker_AccountID:{accountId}_SessionId:{sessionIdString}", Settings.Default.AccountPinInputFloodCheckerLimit, Settings.Default.AccountPinInputFloodCheckerExpiry)
	{
	}
}
