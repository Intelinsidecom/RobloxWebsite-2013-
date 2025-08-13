using System;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.TranslationResources;

namespace Roblox.Platform.Localization.Accounts;

/// <inheritdoc />
/// <summary>
/// An abstract class that implements the <see cref="T:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider" />
public abstract class LocalizationResourceProviderBase : ILocalizationResourceProvider
{
	protected readonly ILocaleResourceFactory LocaleResourceFactory;

	protected readonly IAccountLocaleAccessor AccountLocaleAccessor;

	/// <inheritdoc cref="P:Roblox.Platform.Localization.Accounts.TranslationResourceLocaleMapper.DefaultTranslationResourceLocale" />
	protected TranslationResourceLocale DefaultTranslationResourceLocale => TranslationResourceLocaleMapper.DefaultTranslationResourceLocale;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Localization.Accounts.LocalizationResourceProviderBase" /> class.
	/// </summary>
	/// <param name="localeResourceFactory">The locale resource factory.</param>
	/// <param name="accountLocaleAccessor">The account locale accessor.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// localeResourceFactory
	/// or
	/// accountLocaleAccessor
	/// </exception>
	protected LocalizationResourceProviderBase(ILocaleResourceFactory localeResourceFactory, IAccountLocaleAccessor accountLocaleAccessor)
	{
		LocaleResourceFactory = localeResourceFactory ?? throw new ArgumentNullException("localeResourceFactory");
		AccountLocaleAccessor = accountLocaleAccessor ?? throw new ArgumentNullException("accountLocaleAccessor");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Localization.Accounts.TranslationResourceLocaleMapper.MapToResourceLocale(System.Nullable{Roblox.Platform.Localization.Core.SupportedLocaleEnum})" />
	protected TranslationResourceLocale MapToResourceLocale(SupportedLocaleEnum? locale)
	{
		return TranslationResourceLocaleMapper.MapToResourceLocale(locale);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider.GetLocalizationResources(Roblox.Platform.Membership.IUser)" />
	public abstract IMasterResources GetLocalizationResources(IUser user);

	/// <inheritdoc cref="M:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider.GetLocalizationResourcesForSpecificLocale(Roblox.Platform.Membership.IUser,Roblox.Platform.Localization.Core.SupportedLocaleEnum)" />
	public abstract IMasterResources GetLocalizationResourcesForSpecificLocale(IUser user, SupportedLocaleEnum locale);
}
