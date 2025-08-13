namespace Roblox.TranslationResources.Feature;

internal static class DevelopLandingResourceFactory
{
	public const string FullNamespace = "Feature.DevelopLanding";

	public static IDevelopLandingResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new DevelopLandingResources_de_de(state), 
			TranslationResourceLocale.en_us => new DevelopLandingResources_en_us(state), 
			TranslationResourceLocale.es_es => new DevelopLandingResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new DevelopLandingResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new DevelopLandingResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new DevelopLandingResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new DevelopLandingResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new DevelopLandingResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new DevelopLandingResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new DevelopLandingResources_zh_tw(state), 
			_ => new DevelopLandingResources_en_us(state), 
		};
	}
}
