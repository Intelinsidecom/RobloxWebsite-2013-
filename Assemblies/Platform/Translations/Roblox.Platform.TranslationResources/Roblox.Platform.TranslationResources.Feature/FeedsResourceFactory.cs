namespace Roblox.TranslationResources.Feature;

internal static class FeedsResourceFactory
{
	public const string FullNamespace = "Feature.Feeds";

	public static IFeedsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new FeedsResources_de_de(state), 
			TranslationResourceLocale.en_us => new FeedsResources_en_us(state), 
			TranslationResourceLocale.es_es => new FeedsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new FeedsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new FeedsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new FeedsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new FeedsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new FeedsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new FeedsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new FeedsResources_zh_tw(state), 
			_ => new FeedsResources_en_us(state), 
		};
	}
}
