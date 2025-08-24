namespace Roblox.TranslationResources.Feature;

internal static class CreditCardExpiringModalResourceFactory
{
	public const string FullNamespace = "Feature.CreditCardExpiringModal";

	public static ICreditCardExpiringModalResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CreditCardExpiringModalResources_de_de(state), 
			TranslationResourceLocale.en_us => new CreditCardExpiringModalResources_en_us(state), 
			TranslationResourceLocale.es_es => new CreditCardExpiringModalResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CreditCardExpiringModalResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CreditCardExpiringModalResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CreditCardExpiringModalResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CreditCardExpiringModalResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CreditCardExpiringModalResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CreditCardExpiringModalResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CreditCardExpiringModalResources_zh_tw(state), 
			_ => new CreditCardExpiringModalResources_en_us(state), 
		};
	}
}
