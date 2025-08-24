namespace Roblox.TranslationResources.Feature;

internal static class GameGearResourceFactory
{
	public const string FullNamespace = "Feature.GameGear";

	public static IGameGearResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameGearResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameGearResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameGearResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameGearResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameGearResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameGearResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameGearResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameGearResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameGearResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameGearResources_zh_tw(state), 
			_ => new GameGearResources_en_us(state), 
		};
	}
}
