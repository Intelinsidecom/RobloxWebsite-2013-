using Roblox.Platform.Demographics;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountCountryBuilder
{
	/// <summary>
	/// Fires when the user's country is changed.
	/// </summary>
	event CountryChangedByUserEventHandler CountryChangedByUser;

	/// <summary>
	/// Set country assocciated with account id. 
	/// Call this method only when user explicilty sets/chooses country field.
	/// </summary>
	/// <param name="accountId">The account id of user.</param>
	/// <param name="countryIdentifier">The country identifier that needs to set for account id. countryIdentifier cannot be negative or null.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" /> which contains the <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesChangeAgentType" /> and target id.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformException">This is thrown when changeAgent is not properly validated.</exception>
	void SetCountryVerifiedByUser(long accountId, ICountryIdentifier countryIdentifier, IAccountCountriesChangeAgent changeAgent);

	/// <summary>
	/// Set country assocciated with account id.
	/// Call this method when user is NOT setting country explicitly.
	/// This method will not override user's country when user already set country explicitly by calling SetCountryVerifiedByUser.
	/// Example setting country by ip address lookup.
	/// </summary>
	/// <param name="accountId">The account id of the user whose country was changed.</param>
	/// <param name="countryId">The country identifier that needs to set for account id. countryIdentifier cannot be negative but null is allowed.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountriesChangeAgent" /> which contains the <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesChangeAgentType" /> and target id.</param>
	/// /// <exception cref="T:Roblox.Platform.Core.PlatformException">This is thrown when changeAgent is not properly validated.</exception>
	void SetDerivedCountry(long accountId, ICountryIdentifier countryId, IAccountCountriesChangeAgent changeAgent);
}
