namespace Roblox.TranslationResources.Feature;

internal static class TranslatorPortalResourceFactory
{
	public const string FullNamespace = "Feature.TranslatorPortal";

	public static ITranslatorPortalResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TranslatorPortalResources_de_de(state), 
			TranslationResourceLocale.en_us => new TranslatorPortalResources_en_us(state), 
			TranslationResourceLocale.es_es => new TranslatorPortalResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TranslatorPortalResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new TranslatorPortalResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TranslatorPortalResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TranslatorPortalResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new TranslatorPortalResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TranslatorPortalResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TranslatorPortalResources_zh_tw(state), 
			_ => new TranslatorPortalResources_en_us(state), 
		};
	}
}
