using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountCountryAccessor
{
	/// <summary>
	/// Get IAccountCountry associated with account id.
	/// </summary>
	/// <param name="accountId"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountry" />.</returns>
	IAccountCountry GetAccountCountry(long accountId);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Demographics.ICountry" /> of the user.  Returns null if the user is null or if no country is associated with the user's account.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> in question.</param>
	/// <param name="onlyIfExplicitlySetByUser">If set to true, the method will only return an <see cref="T:Roblox.Platform.Demographics.ICountry" /> that is explicitly set by the user.  If false (default), the method not distinguish whether the country was explicitly set by the user.</param>
	ICountry GetUserCountry(IUser user, bool onlyIfExplicitlySetByUser = false);
}
