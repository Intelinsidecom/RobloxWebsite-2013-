using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Localization.Accounts;

internal interface ISupportedLocaleAndLanguageMapper
{
	ISupportedLocale MapSupportedLocale(IAccountLocaleEntity accountLocaleEntity);

	ILanguageFamily MapLangauge(IAccountLocaleEntity accountLocaleEntity);
}
