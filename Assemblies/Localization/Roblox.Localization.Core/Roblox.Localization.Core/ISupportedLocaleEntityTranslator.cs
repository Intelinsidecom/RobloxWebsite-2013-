namespace Roblox.Platform.Localization.Core;

internal interface ISupportedLocaleEntityTranslator
{
	ISupportedLocale GetDefaultSupportedLocale();

	ISupportedLocale GetSupportedLocale(ISupportedLocaleEntity supportedLocaleEntity);
}
