namespace Roblox.Platform.Localization.Core;

internal interface ILocaleParser
{
	/// <summary>
	/// standardized the raw locale and return
	/// </summary>
	/// <param name="rawLocale"></param>
	/// <returns>standardized locale</returns>
	string GetStandardizedLocaleFromRawLocaleString(string rawLocale);

	/// <summary>
	/// Get language from standardized locale
	/// </summary>
	/// <param name="standardizedLocale"></param>
	/// <returns>language code </returns>
	string GetLanguageCodeFromStandardizedLocale(string standardizedLocale);

	/// <summary>
	/// Get SupportedLocaleEnum from locale code. If locale code not found return null.
	/// </summary>
	/// <param name="localeCode"></param>
	/// <returns><see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" /></returns>
	SupportedLocaleEnum? ParseLocaleCodeToSupportedLocaleEnum(string localeCode);
}
