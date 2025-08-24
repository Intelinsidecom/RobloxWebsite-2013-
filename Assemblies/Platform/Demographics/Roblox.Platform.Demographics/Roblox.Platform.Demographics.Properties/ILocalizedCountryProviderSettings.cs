namespace Roblox.Platform.Demographics.Properties;

internal interface ILocalizedCountryProviderSettings
{
	bool IsCountryNameTranslationEnabled { get; }

	bool IsCountryNameTranslationCachingEnabled { get; }
}
