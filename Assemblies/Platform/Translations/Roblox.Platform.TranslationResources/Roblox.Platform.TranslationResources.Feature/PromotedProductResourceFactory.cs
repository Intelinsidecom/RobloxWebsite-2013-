namespace Roblox.TranslationResources.Feature;

internal static class PromotedProductResourceFactory
{
	public const string FullNamespace = "Feature.PromotedProduct";

	public static IPromotedProductResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PromotedProductResources_de_de(state), 
			TranslationResourceLocale.en_us => new PromotedProductResources_en_us(state), 
			TranslationResourceLocale.es_es => new PromotedProductResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PromotedProductResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PromotedProductResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PromotedProductResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PromotedProductResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PromotedProductResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PromotedProductResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PromotedProductResources_zh_tw(state), 
			_ => new PromotedProductResources_en_us(state), 
		};
	}
}
