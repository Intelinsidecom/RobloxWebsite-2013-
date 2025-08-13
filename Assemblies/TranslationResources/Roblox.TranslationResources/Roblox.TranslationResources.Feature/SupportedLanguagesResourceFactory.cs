namespace Roblox.TranslationResources.Feature;

internal static class SupportedLanguagesResourceFactory
{
	public const string FullNamespace = "Feature.SupportedLanguages";

	public static ISupportedLanguagesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SupportedLanguagesResources_de_de(state), 
			TranslationResourceLocale.en_us => new SupportedLanguagesResources_en_us(state), 
			TranslationResourceLocale.es_es => new SupportedLanguagesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SupportedLanguagesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SupportedLanguagesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SupportedLanguagesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SupportedLanguagesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SupportedLanguagesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SupportedLanguagesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SupportedLanguagesResources_zh_tw(state), 
			_ => new SupportedLanguagesResources_en_us(state), 
		};
	}
}
