using Roblox.Platform.Demographics;
namespace Roblox.Localization.Accounts.Implementations {
    class AccountCountry : IAccountCountry

{
	public long AccountId { get; set; }

	public ICountryIdentifier CountryId { get; set; }

	public bool IsVerified { get; set; }
}


}
