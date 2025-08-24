using Roblox.Platform.Membership;
using Roblox.TranslationResources;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountLocaleAccessor
{
	/// <summary>
	/// Get <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocale" /> for given account id.
	/// </summary>
	/// <param name="accountId">The account id.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocale" /> if present, null otherwise.</returns>
	IAccountLocale GetAccountLocale(long accountId);

	/// <summary>
	/// Get translation resources state.
	/// </summary>
	/// <param name="user"></param>
	/// <returns><see cref="T:Roblox.TranslationResources.TranslationResourceState" /></returns>
	TranslationResourceState GetTranslationResourcesState(IUser user);

	/// <summary>
	/// Checks whether the provided <see cref="T:Roblox.Platform.Membership.IUser" /> has explicitly set their <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>False if the <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /> from the AccountLocaleEntity based on the given <see cref="T:Roblox.Platform.Membership.IUser" /> is NULL. Otherwise, return true.</returns>
	bool IsPreferredLocaleExplicitlySet(IUser user);
}
