namespace Roblox.TranslationResources.Authentication;

internal static class TencentResourceFactory
{
	public const string FullNamespace = "Authentication.Tencent";

	public static ITencentResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TencentResources_de_de(state), 
			TranslationResourceLocale.en_us => new TencentResources_en_us(state), 
			TranslationResourceLocale.es_es => new TencentResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TencentResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new TencentResources_id_id(state), 
			TranslationResourceLocale.it_it => new TencentResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new TencentResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TencentResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TencentResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new TencentResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new TencentResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new TencentResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new TencentResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new TencentResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TencentResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TencentResources_zh_tw(state), 
			_ => new TencentResources_en_us(state), 
		};
	}
}
