namespace Roblox.TranslationResources.Feature;

internal static class BuildersClubPanelResourceFactory
{
	public const string FullNamespace = "Feature.BuildersClubPanel";

	public static IBuildersClubPanelResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new BuildersClubPanelResources_de_de(state), 
			TranslationResourceLocale.en_us => new BuildersClubPanelResources_en_us(state), 
			TranslationResourceLocale.es_es => new BuildersClubPanelResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new BuildersClubPanelResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new BuildersClubPanelResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new BuildersClubPanelResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new BuildersClubPanelResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new BuildersClubPanelResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new BuildersClubPanelResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new BuildersClubPanelResources_zh_tw(state), 
			_ => new BuildersClubPanelResources_en_us(state), 
		};
	}
}
