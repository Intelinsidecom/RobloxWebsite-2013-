namespace Roblox.TranslationResources.Feature;

internal static class BuildersClubPageResourceFactory
{
	public const string FullNamespace = "Feature.BuildersClubPage";

	public static IBuildersClubPageResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new BuildersClubPageResources_de_de(state), 
			TranslationResourceLocale.en_us => new BuildersClubPageResources_en_us(state), 
			TranslationResourceLocale.es_es => new BuildersClubPageResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new BuildersClubPageResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new BuildersClubPageResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new BuildersClubPageResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new BuildersClubPageResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new BuildersClubPageResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new BuildersClubPageResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new BuildersClubPageResources_zh_tw(state), 
			_ => new BuildersClubPageResources_en_us(state), 
		};
	}
}
