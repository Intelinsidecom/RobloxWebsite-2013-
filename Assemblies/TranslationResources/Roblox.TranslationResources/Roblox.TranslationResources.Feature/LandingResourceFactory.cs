namespace Roblox.TranslationResources.Feature;

internal static class LandingResourceFactory
{
	public const string FullNamespace = "Feature.Landing";

	public static ILandingResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new LandingResources_de_de(state), 
			TranslationResourceLocale.en_us => new LandingResources_en_us(state), 
			TranslationResourceLocale.es_es => new LandingResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new LandingResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new LandingResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new LandingResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new LandingResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new LandingResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new LandingResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new LandingResources_zh_tw(state), 
			_ => new LandingResources_en_us(state), 
		};
	}
}
