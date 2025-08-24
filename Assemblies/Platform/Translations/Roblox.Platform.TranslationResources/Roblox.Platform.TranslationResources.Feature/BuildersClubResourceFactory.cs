namespace Roblox.TranslationResources.Feature;

internal static class BuildersClubResourceFactory
{
	public const string FullNamespace = "Feature.BuildersClub";

	public static IBuildersClubResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new BuildersClubResources_de_de(state), 
			TranslationResourceLocale.en_us => new BuildersClubResources_en_us(state), 
			TranslationResourceLocale.es_es => new BuildersClubResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new BuildersClubResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new BuildersClubResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new BuildersClubResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new BuildersClubResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new BuildersClubResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new BuildersClubResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new BuildersClubResources_zh_tw(state), 
			_ => new BuildersClubResources_en_us(state), 
		};
	}
}
