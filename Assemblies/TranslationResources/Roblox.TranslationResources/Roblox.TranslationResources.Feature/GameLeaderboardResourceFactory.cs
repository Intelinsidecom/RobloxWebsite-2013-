namespace Roblox.TranslationResources.Feature;

internal static class GameLeaderboardResourceFactory
{
	public const string FullNamespace = "Feature.GameLeaderboard";

	public static IGameLeaderboardResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameLeaderboardResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameLeaderboardResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameLeaderboardResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameLeaderboardResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameLeaderboardResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameLeaderboardResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameLeaderboardResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameLeaderboardResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameLeaderboardResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameLeaderboardResources_zh_tw(state), 
			_ => new GameLeaderboardResources_en_us(state), 
		};
	}
}
