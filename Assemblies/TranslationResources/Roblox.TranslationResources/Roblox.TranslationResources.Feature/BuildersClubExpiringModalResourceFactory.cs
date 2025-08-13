namespace Roblox.TranslationResources.Feature;

internal static class BuildersClubExpiringModalResourceFactory
{
	public const string FullNamespace = "Feature.BuildersClubExpiringModal";

	public static IBuildersClubExpiringModalResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new BuildersClubExpiringModalResources_de_de(state), 
			TranslationResourceLocale.en_us => new BuildersClubExpiringModalResources_en_us(state), 
			TranslationResourceLocale.es_es => new BuildersClubExpiringModalResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new BuildersClubExpiringModalResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new BuildersClubExpiringModalResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new BuildersClubExpiringModalResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new BuildersClubExpiringModalResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new BuildersClubExpiringModalResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new BuildersClubExpiringModalResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new BuildersClubExpiringModalResources_zh_tw(state), 
			_ => new BuildersClubExpiringModalResources_en_us(state), 
		};
	}
}
