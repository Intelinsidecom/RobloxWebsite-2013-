namespace Roblox.TranslationResources.Feature;

internal static class ProfileResourceFactory
{
	public const string FullNamespace = "Feature.Profile";

	public static IProfileResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ProfileResources_de_de(state), 
			TranslationResourceLocale.en_us => new ProfileResources_en_us(state), 
			TranslationResourceLocale.es_es => new ProfileResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ProfileResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ProfileResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ProfileResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ProfileResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ProfileResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ProfileResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ProfileResources_zh_tw(state), 
			_ => new ProfileResources_en_us(state), 
		};
	}
}
