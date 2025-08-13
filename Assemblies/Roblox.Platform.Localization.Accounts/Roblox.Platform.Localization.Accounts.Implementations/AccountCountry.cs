using Roblox.Platform.Demographics;

namespace Roblox.Platform.Localization.Accounts.Implementations;

internal class AccountCountry : IAccountCountry
{
	public long AccountId { get; set; }

	public ICountryIdentifier CountryId { get; set; }

	public bool IsVerified { get; set; }
}
