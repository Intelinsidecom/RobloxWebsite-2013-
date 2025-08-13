namespace Roblox.TranslationResources.CommonUI;

internal static class ControlsResourceFactory
{
	public const string FullNamespace = "CommonUI.Controls";

	public static IControlsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ControlsResources_de_de(state), 
			TranslationResourceLocale.en_us => new ControlsResources_en_us(state), 
			TranslationResourceLocale.es_es => new ControlsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ControlsResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new ControlsResources_id_id(state), 
			TranslationResourceLocale.it_it => new ControlsResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new ControlsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ControlsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ControlsResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new ControlsResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new ControlsResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new ControlsResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new ControlsResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new ControlsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ControlsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ControlsResources_zh_tw(state), 
			_ => new ControlsResources_en_us(state), 
		};
	}
}
