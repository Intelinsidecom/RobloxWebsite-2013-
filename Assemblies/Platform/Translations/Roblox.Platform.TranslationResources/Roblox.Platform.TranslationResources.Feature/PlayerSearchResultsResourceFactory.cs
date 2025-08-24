namespace Roblox.TranslationResources.Feature;

internal static class PlayerSearchResultsResourceFactory
{
	public const string FullNamespace = "Feature.PlayerSearchResults";

	public static IPlayerSearchResultsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PlayerSearchResultsResources_de_de(state), 
			TranslationResourceLocale.en_us => new PlayerSearchResultsResources_en_us(state), 
			TranslationResourceLocale.es_es => new PlayerSearchResultsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PlayerSearchResultsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PlayerSearchResultsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PlayerSearchResultsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PlayerSearchResultsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PlayerSearchResultsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PlayerSearchResultsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PlayerSearchResultsResources_zh_tw(state), 
			_ => new PlayerSearchResultsResources_en_us(state), 
		};
	}
}
