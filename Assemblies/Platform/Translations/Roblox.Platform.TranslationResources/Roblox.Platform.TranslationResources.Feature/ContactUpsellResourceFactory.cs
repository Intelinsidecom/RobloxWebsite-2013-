namespace Roblox.TranslationResources.Feature;

internal static class ContactUpsellResourceFactory
{
	public const string FullNamespace = "Feature.ContactUpsell";

	public static IContactUpsellResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ContactUpsellResources_de_de(state), 
			TranslationResourceLocale.en_us => new ContactUpsellResources_en_us(state), 
			TranslationResourceLocale.es_es => new ContactUpsellResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ContactUpsellResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ContactUpsellResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ContactUpsellResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ContactUpsellResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ContactUpsellResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ContactUpsellResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ContactUpsellResources_zh_tw(state), 
			_ => new ContactUpsellResources_en_us(state), 
		};
	}
}
