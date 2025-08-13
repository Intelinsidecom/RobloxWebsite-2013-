using System.Collections.Generic;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

/// <summary>
/// Account Locale initializer - use to update users observed and supported locale.
/// </summary>
public interface IAccountLocaleInitializer
{
	/// <summary>
	/// Set observed locale for user's account. If account not present, create new entry with observed locale.
	/// If the code gets called from UI, make sure you check IsUserInRolloutPercentage. If not, no need to show UI elements to users.
	/// Observed locale information id retrieved from http request object.
	/// If observed locale not found then user will have default observed locale.
	/// </summary>
	/// <param name="user">User for which observed locale need to be set. <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="changeAgent">The change agent.</param>
	/// <returns>
	/// AccountLocaleInitializerResponse
	/// </returns>
	AccountLocaleInitializerResponse SetOrCreateObservedLocaleForUser(IUser user, IAccountLocalesChangeAgent changeAgent);

	/// <summary>
	/// Set supported locale for user's account. If account not present, create new entry with observed locale and supported locale.
	/// Observed locale information id retrieved from http request object.
	/// If observed locale not found then user will have default observed locale.
	/// </summary>
	/// <param name="user">User for which supported locale need to be set. <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="supportedLocaleEnum"><see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" />Supported locale enum that needs to be set for given user. Null value will reset user's supported locale.</param>
	/// <param name="changeAgent">The change agent.</param>
	/// <returns>
	/// AccountLocaleInitializerResponse
	/// </returns>
	AccountLocaleInitializerResponse SetOrCreateSupportedLocaleForUser(IUser user, SupportedLocaleEnum? supportedLocaleEnum, IAccountLocalesChangeAgent changeAgent);

	/// <summary>
	/// Creates user locale entry for given user if not present in DB and returns user's Locale Information
	/// If user is null, method does not create any entry in DB and returns locale information retrieved from http request object.
	/// </summary>
	/// <param name="user">User for which account locale need to be retrieved. <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="returnsUgcLocale"></param>
	/// <returns>IUserLocale <see cref="T:Roblox.Web.Code.IUserLocale" />If true, when full experience is not enabled, it will return ugc locale. Otherwise, returns default locale.</returns>
	IUserLocale GetOrCreateUserLocale(IUser user, bool returnsUgcLocale = false);

	/// <summary>
	/// returns list of supported locales
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns>List of ISupportedLocale</returns>
	IReadOnlyCollection<ISupportedLocale> GetSupportedLocales(IUser user);

	/// <summary>
	/// Get list of supported locales with locus information
	/// </summary>
	/// <param name="user"></param>
	/// <param name="isSortedByFullExperience">Sort the list by putting full-experience locales first</param>
	/// <returns>List of <see cref="T:Roblox.Web.Code.ISupportedLocaleLocus" /></returns>
	IReadOnlyCollection<ISupportedLocaleLocus> GetSupportedLocalesWithLocus(IUser user, bool isSortedByFullExperience = false);

	/// <summary>
	/// Creates user locale entry for the given user if not present in the DB and returns the user's Locale Information for each localization
	/// locus. See <see cref="T:Roblox.Web.Code.ILocalizationLocusUserLocales" /> for our supported locus.
	/// </summary>
	/// <param name="user">User for which account locale need to be retrieved. <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>An instance of <see cref="T:Roblox.Web.Code.ILocalizationLocusUserLocales" />.</returns>
	ILocalizationLocusUserLocales GetLocalizationLocusUserSupportedLocales(IUser user);

	/// <summary>
	/// Returns supported locale based on overrideLocale parameter. See <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /> for Supported Locale
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="overrideLocale">override locale to get SupportedLocale </param>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></returns>
	ISupportedLocale GetSupportedLocaleBasedOnOverride(IUser user, SupportedLocaleEnum overrideLocale);
}
