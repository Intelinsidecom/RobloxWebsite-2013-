namespace Roblox.TranslationResources.Common;

internal static class GameSortsResourceFactory
{
	public const string FullNamespace = "Common.GameSorts";

	public static IGameSortsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameSortsResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameSortsResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameSortsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameSortsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameSortsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameSortsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameSortsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameSortsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameSortsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameSortsResources_zh_tw(state), 
			_ => new GameSortsResources_en_us(state), 
		};
	}
}
