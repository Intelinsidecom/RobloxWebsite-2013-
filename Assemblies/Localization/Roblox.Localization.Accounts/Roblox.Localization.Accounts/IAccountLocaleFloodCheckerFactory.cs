using Roblox.FloodCheckers.Core;
namespace Roblox.Localization.Accounts {
    interface IAccountLocaleFloodCheckerFactory

{
	IFloodChecker GetSupportedLocaleUpdateFloodChecker(long accountId);

	IFloodChecker GetObservedLocaleUpdateFloodChecker(long accountId);
}


}
