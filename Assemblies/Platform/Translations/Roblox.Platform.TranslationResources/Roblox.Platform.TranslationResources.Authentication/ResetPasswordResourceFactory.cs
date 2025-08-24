namespace Roblox.TranslationResources.Authentication;

internal static class ResetPasswordResourceFactory
{
	public const string FullNamespace = "Authentication.ResetPassword";

	public static IResetPasswordResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ResetPasswordResources_de_de(state), 
			TranslationResourceLocale.en_us => new ResetPasswordResources_en_us(state), 
			TranslationResourceLocale.es_es => new ResetPasswordResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ResetPasswordResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new ResetPasswordResources_id_id(state), 
			TranslationResourceLocale.it_it => new ResetPasswordResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new ResetPasswordResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ResetPasswordResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ResetPasswordResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new ResetPasswordResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new ResetPasswordResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new ResetPasswordResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new ResetPasswordResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new ResetPasswordResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ResetPasswordResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ResetPasswordResources_zh_tw(state), 
			_ => new ResetPasswordResources_en_us(state), 
		};
	}
}
