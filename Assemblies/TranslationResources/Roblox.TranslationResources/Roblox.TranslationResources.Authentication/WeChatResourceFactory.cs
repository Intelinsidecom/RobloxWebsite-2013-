namespace Roblox.TranslationResources.Authentication;

internal static class WeChatResourceFactory
{
	public const string FullNamespace = "Authentication.WeChat";

	public static IWeChatResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new WeChatResources_de_de(state), 
			TranslationResourceLocale.en_us => new WeChatResources_en_us(state), 
			TranslationResourceLocale.es_es => new WeChatResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new WeChatResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new WeChatResources_id_id(state), 
			TranslationResourceLocale.it_it => new WeChatResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new WeChatResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new WeChatResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new WeChatResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new WeChatResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new WeChatResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new WeChatResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new WeChatResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new WeChatResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new WeChatResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new WeChatResources_zh_tw(state), 
			_ => new WeChatResources_en_us(state), 
		};
	}
}
