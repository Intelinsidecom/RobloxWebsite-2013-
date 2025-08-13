namespace Roblox.TranslationResources.Feature;

internal static class SourceLanguageResourceFactory
{
	public const string FullNamespace = "Feature.SourceLanguage";

	public static ISourceLanguageResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SourceLanguageResources_de_de(state), 
			TranslationResourceLocale.en_us => new SourceLanguageResources_en_us(state), 
			TranslationResourceLocale.es_es => new SourceLanguageResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SourceLanguageResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SourceLanguageResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SourceLanguageResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SourceLanguageResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SourceLanguageResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SourceLanguageResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SourceLanguageResources_zh_tw(state), 
			_ => new SourceLanguageResources_en_us(state), 
		};
	}
}
