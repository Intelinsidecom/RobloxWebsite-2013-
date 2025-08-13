namespace Roblox.TranslationResources.Feature;

internal static class TranslationAnalyticsResourceFactory
{
	public const string FullNamespace = "Feature.TranslationAnalytics";

	public static ITranslationAnalyticsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TranslationAnalyticsResources_de_de(state), 
			TranslationResourceLocale.en_us => new TranslationAnalyticsResources_en_us(state), 
			TranslationResourceLocale.es_es => new TranslationAnalyticsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TranslationAnalyticsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new TranslationAnalyticsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TranslationAnalyticsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TranslationAnalyticsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new TranslationAnalyticsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TranslationAnalyticsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TranslationAnalyticsResources_zh_tw(state), 
			_ => new TranslationAnalyticsResources_en_us(state), 
		};
	}
}
