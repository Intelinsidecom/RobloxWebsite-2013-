using Roblox.FloodCheckers.Core;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountCountryFloodCheckerFactory
{
	IFloodChecker GetAccountCountryUpdateFloodChecker(long accountId);
}
