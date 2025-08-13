namespace Roblox.TranslationResources.Feature;

internal static class RecommendationsResourceFactory
{
	public const string FullNamespace = "Feature.Recommendations";

	public static IRecommendationsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new RecommendationsResources_de_de(state), 
			TranslationResourceLocale.en_us => new RecommendationsResources_en_us(state), 
			TranslationResourceLocale.es_es => new RecommendationsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new RecommendationsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new RecommendationsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new RecommendationsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new RecommendationsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new RecommendationsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new RecommendationsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new RecommendationsResources_zh_tw(state), 
			_ => new RecommendationsResources_en_us(state), 
		};
	}
}
