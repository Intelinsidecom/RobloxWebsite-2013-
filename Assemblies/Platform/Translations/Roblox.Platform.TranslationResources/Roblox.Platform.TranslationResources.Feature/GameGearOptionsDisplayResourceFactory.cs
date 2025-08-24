namespace Roblox.TranslationResources.Feature;

internal static class GameGearOptionsDisplayResourceFactory
{
	public const string FullNamespace = "Feature.GameGearOptionsDisplay";

	public static IGameGearOptionsDisplayResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameGearOptionsDisplayResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameGearOptionsDisplayResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameGearOptionsDisplayResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameGearOptionsDisplayResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameGearOptionsDisplayResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameGearOptionsDisplayResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameGearOptionsDisplayResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameGearOptionsDisplayResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameGearOptionsDisplayResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameGearOptionsDisplayResources_zh_tw(state), 
			_ => new GameGearOptionsDisplayResources_en_us(state), 
		};
	}
}
