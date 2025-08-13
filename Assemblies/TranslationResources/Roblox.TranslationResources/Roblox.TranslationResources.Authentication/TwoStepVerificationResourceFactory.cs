namespace Roblox.TranslationResources.Authentication;

internal static class TwoStepVerificationResourceFactory
{
	public const string FullNamespace = "Authentication.TwoStepVerification";

	public static ITwoStepVerificationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TwoStepVerificationResources_de_de(state), 
			TranslationResourceLocale.en_us => new TwoStepVerificationResources_en_us(state), 
			TranslationResourceLocale.es_es => new TwoStepVerificationResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TwoStepVerificationResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new TwoStepVerificationResources_id_id(state), 
			TranslationResourceLocale.it_it => new TwoStepVerificationResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new TwoStepVerificationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TwoStepVerificationResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TwoStepVerificationResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new TwoStepVerificationResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new TwoStepVerificationResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new TwoStepVerificationResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new TwoStepVerificationResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new TwoStepVerificationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TwoStepVerificationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TwoStepVerificationResources_zh_tw(state), 
			_ => new TwoStepVerificationResources_en_us(state), 
		};
	}
}
