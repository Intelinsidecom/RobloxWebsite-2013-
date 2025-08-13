namespace Roblox.TranslationResources.Authentication;

internal static class SignUpResourceFactory
{
	public const string FullNamespace = "Authentication.SignUp";

	public static ISignUpResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SignUpResources_de_de(state), 
			TranslationResourceLocale.en_us => new SignUpResources_en_us(state), 
			TranslationResourceLocale.es_es => new SignUpResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SignUpResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new SignUpResources_id_id(state), 
			TranslationResourceLocale.it_it => new SignUpResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new SignUpResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SignUpResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SignUpResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new SignUpResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new SignUpResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new SignUpResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new SignUpResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new SignUpResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SignUpResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SignUpResources_zh_tw(state), 
			_ => new SignUpResources_en_us(state), 
		};
	}
}
