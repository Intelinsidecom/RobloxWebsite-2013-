namespace Roblox.TranslationResources.Feature;

internal static class TranslationLanguageSwitchResourceFactory
{
	public const string FullNamespace = "Feature.TranslationLanguageSwitch";

	public static ITranslationLanguageSwitchResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TranslationLanguageSwitchResources_de_de(state), 
			TranslationResourceLocale.en_us => new TranslationLanguageSwitchResources_en_us(state), 
			TranslationResourceLocale.es_es => new TranslationLanguageSwitchResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TranslationLanguageSwitchResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new TranslationLanguageSwitchResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TranslationLanguageSwitchResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TranslationLanguageSwitchResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new TranslationLanguageSwitchResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TranslationLanguageSwitchResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TranslationLanguageSwitchResources_zh_tw(state), 
			_ => new TranslationLanguageSwitchResources_en_us(state), 
		};
	}
}
