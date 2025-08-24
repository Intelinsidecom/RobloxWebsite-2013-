namespace Roblox.Platform.Localization.Core;

internal interface IObservedLocaleEntityTranslator
{
	/// <summary>
	/// Converts IObservedLocaleEntity to ILocaleInformation.
	/// For given IObservedLocaleEntity
	///     If Language null then we use default language.
	///     If SupportedLocale is null then we use language to get respective supported locale
	///     If language not found in DB then we use default locale.
	/// </summary>
	/// <param name="observedLocaleEntity"></param>
	/// <returns>ILocaleInformation</returns>
	IDeviceReportedLocale TranslateObservedLocaleEntityWithDefaults(IObservedLocaleEntity observedLocaleEntity);

	/// <summary>
	/// Converts IObservedLocaleEntity to ILocaleInformation. No defaults used.
	/// </summary>
	/// <param name="observedLocaleEntity"></param>
	/// <returns>ILocaleInformation</returns>
	IDeviceReportedLocale TranslateObservedLocaleEntity(IObservedLocaleEntity observedLocaleEntity);
}
