namespace Roblox.TranslationResources.Feature;

internal static class FeedResourceFactory
{
	public const string FullNamespace = "Feature.Feed";

	public static IFeedResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new FeedResources_de_de(state), 
			TranslationResourceLocale.en_us => new FeedResources_en_us(state), 
			TranslationResourceLocale.es_es => new FeedResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new FeedResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new FeedResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new FeedResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new FeedResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new FeedResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new FeedResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new FeedResources_zh_tw(state), 
			_ => new FeedResources_en_us(state), 
		};
	}
}
