using Roblox.Platform.Localization.Core;
namespace Roblox.Localization.Accountsinternal {
    interface ISupportedLocaleAndLanguageMapper

{
	ISupportedLocale MapSupportedLocale(IAccountLocaleEntity accountLocaleEntity);

	ILanguageFamily MapLangauge(IAccountLocaleEntity accountLocaleEntity);
}


}
