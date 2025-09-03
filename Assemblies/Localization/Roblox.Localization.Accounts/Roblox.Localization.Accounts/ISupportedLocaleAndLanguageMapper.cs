using Roblox.Localization.Core;
namespace Roblox.Localization.Accounts {
    interface ISupportedLocaleAndLanguageMapper

{
	ISupportedLocale MapSupportedLocale(IAccountLocaleEntity accountLocaleEntity);

	ILanguageFamily MapLangauge(IAccountLocaleEntity accountLocaleEntity);
}


}
