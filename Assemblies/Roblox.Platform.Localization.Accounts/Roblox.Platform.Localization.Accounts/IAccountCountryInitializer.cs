namespace Roblox.Platform.Localization.Accounts;

public interface IAccountCountryInitializer
{
	/// <summary>
	/// Set country for account by ip address. Country will not be updated if user has already set country explicitly.
	/// </summary>
	/// <param name="accountId">account of user</param>
	/// <param name="ipAddress">ipAddress of user. Empty or null ipAddress will throw an exception.</param>
	/// <param name="overwriteCountry">If true will over write current country for account with new country value. Except if country is set by user explicitly.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" /> which contains the <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesChangeAgentType" /> and target id.</param>
	void SetDerivedCountryForAccountByIpAddress(long accountId, string ipAddress, bool overwriteCountry, IAccountCountriesChangeAgent changeAgent);
}
