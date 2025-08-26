using Roblox.FloodCheckers.Core;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountLocaleFloodCheckerFactory

{
	IFloodChecker GetSupportedLocaleUpdateFloodChecker(long accountId);

	IFloodChecker GetObservedLocaleUpdateFloodChecker(long accountId);
}


}
