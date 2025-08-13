namespace Roblox.TranslationResources.Feature;

internal static class VotingPanelResourceFactory
{
	public const string FullNamespace = "Feature.VotingPanel";

	public static IVotingPanelResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new VotingPanelResources_de_de(state), 
			TranslationResourceLocale.en_us => new VotingPanelResources_en_us(state), 
			TranslationResourceLocale.es_es => new VotingPanelResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new VotingPanelResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new VotingPanelResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new VotingPanelResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new VotingPanelResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new VotingPanelResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new VotingPanelResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new VotingPanelResources_zh_tw(state), 
			_ => new VotingPanelResources_en_us(state), 
		};
	}
}
