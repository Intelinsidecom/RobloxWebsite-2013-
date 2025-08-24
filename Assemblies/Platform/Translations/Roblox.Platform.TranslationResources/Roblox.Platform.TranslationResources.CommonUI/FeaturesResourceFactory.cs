namespace Roblox.TranslationResources.CommonUI;

internal static class FeaturesResourceFactory
{
	public const string FullNamespace = "CommonUI.Features";

	public static IFeaturesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new FeaturesResources_de_de(state), 
			TranslationResourceLocale.en_us => new FeaturesResources_en_us(state), 
			TranslationResourceLocale.es_es => new FeaturesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new FeaturesResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new FeaturesResources_id_id(state), 
			TranslationResourceLocale.it_it => new FeaturesResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new FeaturesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new FeaturesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new FeaturesResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new FeaturesResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new FeaturesResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new FeaturesResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new FeaturesResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new FeaturesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new FeaturesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new FeaturesResources_zh_tw(state), 
			_ => new FeaturesResources_en_us(state), 
		};
	}
}
