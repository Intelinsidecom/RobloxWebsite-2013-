using Roblox.FloodCheckers.Core;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocaleFloodCheckerFactory
{
	IFloodChecker GetSupportedLocaleUpdateFloodChecker(long accountId);

	IFloodChecker GetObservedLocaleUpdateFloodChecker(long accountId);
}
