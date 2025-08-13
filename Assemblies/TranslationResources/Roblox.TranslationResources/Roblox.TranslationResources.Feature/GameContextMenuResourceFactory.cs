namespace Roblox.TranslationResources.Feature;

internal static class GameContextMenuResourceFactory
{
	public const string FullNamespace = "Feature.GameContextMenu";

	public static IGameContextMenuResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameContextMenuResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameContextMenuResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameContextMenuResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameContextMenuResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameContextMenuResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameContextMenuResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameContextMenuResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameContextMenuResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameContextMenuResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameContextMenuResources_zh_tw(state), 
			_ => new GameContextMenuResources_en_us(state), 
		};
	}
}
