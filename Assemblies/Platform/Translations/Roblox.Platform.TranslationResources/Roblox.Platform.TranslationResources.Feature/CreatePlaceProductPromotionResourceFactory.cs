namespace Roblox.TranslationResources.Feature;

internal static class CreatePlaceProductPromotionResourceFactory
{
	public const string FullNamespace = "Feature.CreatePlaceProductPromotion";

	public static ICreatePlaceProductPromotionResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CreatePlaceProductPromotionResources_de_de(state), 
			TranslationResourceLocale.en_us => new CreatePlaceProductPromotionResources_en_us(state), 
			TranslationResourceLocale.es_es => new CreatePlaceProductPromotionResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CreatePlaceProductPromotionResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CreatePlaceProductPromotionResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CreatePlaceProductPromotionResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CreatePlaceProductPromotionResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CreatePlaceProductPromotionResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CreatePlaceProductPromotionResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CreatePlaceProductPromotionResources_zh_tw(state), 
			_ => new CreatePlaceProductPromotionResources_en_us(state), 
		};
	}
}
