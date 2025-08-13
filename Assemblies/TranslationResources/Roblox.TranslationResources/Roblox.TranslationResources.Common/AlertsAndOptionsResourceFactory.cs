namespace Roblox.TranslationResources.Common;

internal static class AlertsAndOptionsResourceFactory
{
	public const string FullNamespace = "Common.AlertsAndOptions";

	public static IAlertsAndOptionsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new AlertsAndOptionsResources_de_de(state), 
			TranslationResourceLocale.en_us => new AlertsAndOptionsResources_en_us(state), 
			TranslationResourceLocale.es_es => new AlertsAndOptionsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new AlertsAndOptionsResources_fr_fr(state), 
			TranslationResourceLocale.id_id => new AlertsAndOptionsResources_id_id(state), 
			TranslationResourceLocale.it_it => new AlertsAndOptionsResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new AlertsAndOptionsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new AlertsAndOptionsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new AlertsAndOptionsResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new AlertsAndOptionsResources_ru_ru(state), 
			TranslationResourceLocale.th_th => new AlertsAndOptionsResources_th_th(state), 
			TranslationResourceLocale.tr_tr => new AlertsAndOptionsResources_tr_tr(state), 
			TranslationResourceLocale.vi_vn => new AlertsAndOptionsResources_vi_vn(state), 
			TranslationResourceLocale.zh_cjv => new AlertsAndOptionsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new AlertsAndOptionsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new AlertsAndOptionsResources_zh_tw(state), 
			_ => new AlertsAndOptionsResources_en_us(state), 
		};
	}
}
