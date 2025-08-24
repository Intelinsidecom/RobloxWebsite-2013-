namespace Roblox.TranslationResources.Feature;

internal static class GameBadgesResourceFactory
{
	public const string FullNamespace = "Feature.GameBadges";

	public static IGameBadgesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameBadgesResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameBadgesResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameBadgesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameBadgesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameBadgesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameBadgesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameBadgesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameBadgesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameBadgesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameBadgesResources_zh_tw(state), 
			_ => new GameBadgesResources_en_us(state), 
		};
	}
}
