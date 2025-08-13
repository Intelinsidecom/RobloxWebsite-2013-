using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.TranslationResources;

namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// Common Interface to access Locale specific resources.
/// </summary>
public interface ILocalizationResourceProvider
{
	/// <summary>
	/// Get user's localized resources (creates a Locale if one doesn't exist)
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns>localized resources. <see cref="T:Roblox.TranslationResources.IMasterResources" /></returns>
	IMasterResources GetLocalizationResources(IUser user);

	/// <summary>
	/// Returns resource based on locale param if locale is enabled for given user.
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="locale">Locale for which resource will be returned</param>
	/// <returns>Localized resource based on locale<see cref="T:Roblox.TranslationResources.IMasterResources" /></returns>
	IMasterResources GetLocalizationResourcesForSpecificLocale(IUser user, SupportedLocaleEnum locale);
}
