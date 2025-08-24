namespace Roblox.TranslationResources.Feature;

internal static class PaymentResourceFactory
{
	public const string FullNamespace = "Feature.Payment";

	public static IPaymentResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PaymentResources_de_de(state), 
			TranslationResourceLocale.en_us => new PaymentResources_en_us(state), 
			TranslationResourceLocale.es_es => new PaymentResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PaymentResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PaymentResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PaymentResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PaymentResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PaymentResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PaymentResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PaymentResources_zh_tw(state), 
			_ => new PaymentResources_en_us(state), 
		};
	}
}
