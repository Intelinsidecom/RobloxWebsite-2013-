namespace Roblox.TranslationResources.Feature;

internal static class ChinaPaymentResourceFactory
{
	public const string FullNamespace = "Feature.ChinaPayment";

	public static IChinaPaymentResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ChinaPaymentResources_de_de(state), 
			TranslationResourceLocale.en_us => new ChinaPaymentResources_en_us(state), 
			TranslationResourceLocale.es_es => new ChinaPaymentResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ChinaPaymentResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ChinaPaymentResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ChinaPaymentResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ChinaPaymentResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ChinaPaymentResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ChinaPaymentResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ChinaPaymentResources_zh_tw(state), 
			_ => new ChinaPaymentResources_en_us(state), 
		};
	}
}
