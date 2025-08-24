namespace Roblox.Platform.Localization.Core.Properties;

internal interface ISettings
{
	/// <summary>
	/// Default supported locale code. Example - en-us
	/// </summary>
	string DefaultSupportedLocale { get; }

	/// <summary>
	/// Default supported locale name. Example - English(US)
	/// </summary>
	string DefaultSupportedLocaleName { get; }

	/// <summary>
	/// Default supported locale native name. Example - English
	/// </summary>
	string DefaultSupportedLocaleNativeName { get; }

	/// <summary>
	/// Langauge name associated with default supported locale. Example - English
	/// </summary>
	string DefaultSupportedLocaleAssociatedLanguageName { get; }

	/// <summary>
	/// Langauge native name associated with default supported locale. Example - English
	/// </summary>
	string DefaultSupportedLocaleAssociatedLanguageNativeName { get; }

	/// <summary>
	/// Langauge code associated with default supported locale. Example - en
	/// </summary>
	string DefaultSupportedLocaleAssociatedLanguageCode { get; }

	/// <summary>
	/// Language Id associated with default supported locale. Example 41.
	/// </summary>
	int DefaultSupportedLocaleAssociatedLanguageId { get; }

	/// <summary>
	/// A comma separated list for the available out of game UGC language codes.
	/// </summary>
	string AvailableUgcLanguageCodesCsv { get; }

	/// <summary>
	/// A comma separated list for the available in game UGC language codes
	/// </summary>
	string AvailableInGameUgcLanguageCodesCsv { get; }
}
