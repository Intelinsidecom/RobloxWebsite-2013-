namespace Roblox.TranslationResources.Authentication;

internal static class LoginResourceFactory
{
	public const string FullNamespace = "Authentication.Login";

	public static ILoginResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new LoginResources_de_de(state), 
			TranslationResourceLocale.en_us => new LoginResources_en_us(state), 
			TranslationResourceLocale.es_es => new LoginResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new LoginResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new LoginResources_id_id(state), 
			TranslationResourceLocale.it_it => new LoginResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new LoginResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new LoginResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new LoginResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new LoginResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new LoginResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new LoginResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new LoginResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new LoginResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new LoginResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new LoginResources_zh_tw(state), 
			_ => new LoginResources_en_us(state), 
		};
	}
}
