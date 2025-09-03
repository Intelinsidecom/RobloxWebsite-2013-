using Roblox.FloodCheckers.Core;
namespace Roblox.Localization.Accounts {
    interface IAccountCountryFloodCheckerFactory

{
	IFloodChecker GetAccountCountryUpdateFloodChecker(long accountId);
}


}
