using Roblox.FloodCheckers.Core;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountCountryFloodCheckerFactory

{
	IFloodChecker GetAccountCountryUpdateFloodChecker(long accountId);
}


}
