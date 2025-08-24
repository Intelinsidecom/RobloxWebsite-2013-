namespace Roblox.TranslationResources.Feature;

internal static class GameLanguagesResourceFactory
{
	public const string FullNamespace = "Feature.GameLanguages";

	public static IGameLanguagesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameLanguagesResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameLanguagesResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameLanguagesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameLanguagesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameLanguagesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameLanguagesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameLanguagesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameLanguagesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameLanguagesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameLanguagesResources_zh_tw(state), 
			_ => new GameLanguagesResources_en_us(state), 
		};
	}
}
