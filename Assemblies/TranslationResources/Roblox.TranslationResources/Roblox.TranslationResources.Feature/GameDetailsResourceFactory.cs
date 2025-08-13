namespace Roblox.TranslationResources.Feature;

internal static class GameDetailsResourceFactory
{
	public const string FullNamespace = "Feature.GameDetails";

	public static IGameDetailsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameDetailsResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameDetailsResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameDetailsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameDetailsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameDetailsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameDetailsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameDetailsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameDetailsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameDetailsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameDetailsResources_zh_tw(state), 
			_ => new GameDetailsResources_en_us(state), 
		};
	}
}
