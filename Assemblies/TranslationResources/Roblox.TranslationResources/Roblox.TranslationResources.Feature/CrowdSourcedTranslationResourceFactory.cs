namespace Roblox.TranslationResources.Feature;

internal static class CrowdSourcedTranslationResourceFactory
{
	public const string FullNamespace = "Feature.CrowdSourcedTranslation";

	public static ICrowdSourcedTranslationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CrowdSourcedTranslationResources_de_de(state), 
			TranslationResourceLocale.en_us => new CrowdSourcedTranslationResources_en_us(state), 
			TranslationResourceLocale.es_es => new CrowdSourcedTranslationResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CrowdSourcedTranslationResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CrowdSourcedTranslationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CrowdSourcedTranslationResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CrowdSourcedTranslationResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CrowdSourcedTranslationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CrowdSourcedTranslationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CrowdSourcedTranslationResources_zh_tw(state), 
			_ => new CrowdSourcedTranslationResources_en_us(state), 
		};
	}
}
