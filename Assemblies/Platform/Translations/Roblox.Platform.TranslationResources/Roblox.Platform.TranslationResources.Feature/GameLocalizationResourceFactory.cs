namespace Roblox.TranslationResources.Feature;

internal static class GameLocalizationResourceFactory
{
	public const string FullNamespace = "Feature.GameLocalization";

	public static IGameLocalizationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameLocalizationResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameLocalizationResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameLocalizationResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameLocalizationResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameLocalizationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameLocalizationResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameLocalizationResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameLocalizationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameLocalizationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameLocalizationResources_zh_tw(state), 
			_ => new GameLocalizationResources_en_us(state), 
		};
	}
}
