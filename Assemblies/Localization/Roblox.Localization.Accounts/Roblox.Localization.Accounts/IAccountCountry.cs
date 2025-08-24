using Roblox.Platform.Demographics;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountCountry
{
	/// <summary>
	/// Account Id of a user
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// Country Id assocciated with an account
	/// </summary>
	ICountryIdentifier CountryId { get; }

	/// <summary>
	/// If country set by user explicitly then field returns true
	/// </summary>
	bool IsVerified { get; }
}
