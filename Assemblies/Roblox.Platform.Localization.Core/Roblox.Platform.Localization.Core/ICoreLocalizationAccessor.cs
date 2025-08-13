using System;
using System.Collections.Generic;

namespace Roblox.Platform.Localization.Core;

/// <summary>
/// An interface that provides core localization constructs needed.
/// </summary>
public interface ICoreLocalizationAccessor
{
	/// <summary>
	/// Get Language Family by Id
	/// </summary>
	/// <param name="languageFamilyIdentifier">id of language</param>
	/// <returns><see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> if exists or null</returns>
	ILanguageFamily GetLanguageFamily(ILanguageFamilyIdentifier languageFamilyIdentifier);

	/// <summary>
	/// Get Language Family by Language Family Code.
	/// </summary>
	/// <param name="languageFamilyCode">Language Family Code. eg. 'en' </param>
	/// <returns><see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> if exists or null.</returns>
	ILanguageFamily GetLanguageFamily(string languageFamilyCode);

	/// <summary>
	/// Gets the available languages for out of game UGC(e.g. names and descriptions). It is up to the consumer of this API to sort the values.
	/// </summary>
	/// <returns>A <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> that are available for UGC.</returns>
	IReadOnlyCollection<ILanguageFamily> GetAvailableLanguageFamiliesForOutOfGameUgc();

	/// <summary>
	/// Get the available language for in game UGC(e.g. in game translations). Consumer should sort the values
	/// </summary>
	/// <returns></returns>
	[Obsolete("This is no longer the way to determine what languages are available in game.")]
	IReadOnlyCollection<ILanguageFamily> GetAvailableLanguageFamiliesForInGameUgc();

	/// <summary>
	/// Get the language family for in game UGC by language code
	/// </summary>
	/// <param name="languageFamilyCode"></param>
	/// <returns></returns>
	ILanguageFamily GetSupportedInGameUGCLanguageFamily(string languageFamilyCode);

	/// <summary>
	/// Get a Device Reported Locale by its Id.
	/// </summary>
	/// <param name="deviceReportedLocaleId">The device reported locale identifier.</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.Localization.Core.IDeviceReportedLocale" /> if present or null
	/// </returns>
	IDeviceReportedLocale GetDeviceReportedLocale(IDeviceReportedLocaleIdentifier deviceReportedLocaleId);

	/// <summary>
	/// Get a Device Reported Locale by looking up its locale code.
	/// </summary>
	/// <param name="deviceReportedLocaleCode"></param>
	/// <returns>ILocaleInformation</returns>
	IDeviceReportedLocale GetDeviceReportedLocale(string deviceReportedLocaleCode);

	/// <summary>
	/// Get supported locale by supported locale id.
	/// </summary>
	/// <param name="supportedLocaleId">id of supported locale</param>
	/// <returns>ISupportedLocale if exists or null</returns>
	ISupportedLocale GetSupportedLocaleBySupportedLocaleId(ISupportedLocaleIdentifier supportedLocaleId);

	/// <summary>
	/// Get supported locale by supported locale code.
	/// No fallback mechanism is available (similar to LookupLocaleInformationByRawLocale) for associated language and supported locale.
	/// </summary>
	/// <param name="supportedLocaleCode">locale code of supported locale. For example en_us</param>
	/// <returns>ISupportedLocale if exists or null</returns>
	ISupportedLocale GetSupportedLocaleBySupportedLocaleCode(string supportedLocaleCode);

	/// <summary>
	/// Get all supported locales
	/// </summary>
	/// <param name="isChinaJvUser">A boolean, if true, will return only JV supported locales </param>
	/// <returns> Read only list of ISupportedLocale if present or empty list</returns>
	IReadOnlyCollection<ISupportedLocale> GetSupportedLocales(bool isChinaJvUser = false);

	/// <summary>
	/// DO NOT USE THIS METHOD FOR ANY PUBLIC FACING API
	/// Get all supported locales for internal usage without any filters.
	/// </summary>
	/// <returns> Read only list of ISupportedLocale if present or empty list</returns>
	IReadOnlyCollection<ISupportedLocale> GetSupportedLocalesInternal();

	/// <summary>
	/// Get default supported locale
	/// </summary>
	/// <returns>ISupportedLocale</returns>
	ISupportedLocale GetDefaultSupportedLocale();

	/// <summary>
	/// Returns SupportedLocaleEnum for supported locale code. Null or empty param will be considered as invalid value.
	/// For invalid parameter, null value will be returned.
	/// </summary>
	/// <param name="supportedLocaleCode">Code for which SupportedLocaleEnum will be returned.</param>
	/// <returns><see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" /></returns>
	SupportedLocaleEnum? GetSupportedLocaleEnum(string supportedLocaleCode);

	/// <summary>
	/// Gets default supported locale from a language
	/// </summary>
	/// <param name="language">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /></param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></returns>
	ISupportedLocale GetDefaultSupportedLocaleFromLanguage(ILanguageFamily language);
}
