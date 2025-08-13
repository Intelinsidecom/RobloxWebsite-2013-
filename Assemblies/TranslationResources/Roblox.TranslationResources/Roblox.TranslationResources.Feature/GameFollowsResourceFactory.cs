namespace Roblox.TranslationResources.Feature;

internal static class GameFollowsResourceFactory
{
	public const string FullNamespace = "Feature.GameFollows";

	public static IGameFollowsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameFollowsResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameFollowsResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameFollowsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameFollowsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameFollowsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameFollowsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameFollowsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameFollowsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameFollowsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameFollowsResources_zh_tw(state), 
			_ => new GameFollowsResources_en_us(state), 
		};
	}
}
