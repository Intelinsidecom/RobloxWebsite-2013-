namespace Roblox.Platform.Localization.Core;

public interface ICoreLocalizationBuilder
{
	/// <summary>
	/// Set the Langauge Family that a given Device Reported Locale belongs to
	/// </summary>
	/// <param name="deviceReportedLocale">Locale information for which Language needs to be set</param>
	/// <param name="languageFamily">Language that needs to be set for locale information. Language must be in list of valid list of languages.</param>
	void MapDeviceReportedLocaleToLanguageFamily(IDeviceReportedLocale deviceReportedLocale, ILanguageFamily languageFamily);

	/// <summary>
	/// Set the default Supported Locale for given Device Reported Locale
	/// </summary>
	/// <param name="deviceReportedLocale">Locale information for which supported locale needs to be set</param>
	/// <param name="supportedLocale">supported locale that needs to be set for locale information. Supported Local needs to be in list of valid supported locales.</param>
	void MapDeviceReportedLocaleToSupportedLocale(IDeviceReportedLocale deviceReportedLocale, ISupportedLocale supportedLocale);

	/// <summary>
	/// Records a device reported locale in the database if it doesn't already exist
	/// </summary>
	/// <param name="rawDeviceReportedLocaleCode">raw locale value passed by a client deivce. eg. "en-us", accept-language header "en_US,en;q=0.8"</param>
	/// <returns>The new or existing identifier for the locale code reported by the deivice</returns>
	IDeviceReportedLocaleIdentifier RecordDeviceReportedLocale(string rawDeviceReportedLocaleCode);
}
