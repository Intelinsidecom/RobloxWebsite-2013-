using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.TranslationResources;

namespace Roblox.Platform.Localization.Accounts;

/// <inheritdoc cref="T:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider" />.
/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider" /> that is not aware of the context.
/// This needs to be used in all places where context cannot be loaded.
/// For all the places that can load HttpContext, use Roblox.Web.LocalizationResourceProvider.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Localization.Accounts.LocalizationResourceProviderBase" />
public class ContextAgnosticLocalizationResourceProvider : LocalizationResourceProviderBase
{
	/// <summary>
	/// Instantiate an object of <see cref="T:Roblox.Platform.Localization.Accounts.ContextAgnosticLocalizationResourceProvider" />.
	/// </summary>
	/// <param name="localeResourceFactory"><see cref="T:Roblox.TranslationResources.ILocaleResourceFactory" /></param>
	/// <param name="accountLocaleAccessor"><see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleAccessor" /></param>
	public ContextAgnosticLocalizationResourceProvider(ILocaleResourceFactory localeResourceFactory, IAccountLocaleAccessor accountLocaleAccessor)
		: base(localeResourceFactory, accountLocaleAccessor)
	{
	}

	/// <inheritdoc cref="M:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider.GetLocalizationResources(Roblox.Platform.Membership.IUser)" />.
	public override IMasterResources GetLocalizationResources(IUser user)
	{
		if (user == null)
		{
			return LocaleResourceFactory.GetMasterResources(base.DefaultTranslationResourceLocale, AccountLocaleAccessor.GetTranslationResourcesState(user));
		}
		TranslationResourceLocale resourceLocale = MapToResourceLocale(AccountLocaleAccessor.GetAccountLocale(user.AccountId)?.SupportedLocale?.Locale);
		return LocaleResourceFactory.GetMasterResources(resourceLocale, AccountLocaleAccessor.GetTranslationResourcesState(user));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider.GetLocalizationResourcesForSpecificLocale(Roblox.Platform.Membership.IUser,Roblox.Platform.Localization.Core.SupportedLocaleEnum)" />.
	public override IMasterResources GetLocalizationResourcesForSpecificLocale(IUser user, SupportedLocaleEnum locale)
	{
		TranslationResourceLocale resourceLocale = MapToResourceLocale(locale);
		return LocaleResourceFactory.GetMasterResources(resourceLocale, AccountLocaleAccessor.GetTranslationResourcesState(user));
	}
}
