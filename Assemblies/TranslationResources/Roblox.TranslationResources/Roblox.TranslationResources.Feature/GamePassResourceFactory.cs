namespace Roblox.TranslationResources.Feature;

internal static class GamePassResourceFactory
{
	public const string FullNamespace = "Feature.GamePass";

	public static IGamePassResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GamePassResources_de_de(state), 
			TranslationResourceLocale.en_us => new GamePassResources_en_us(state), 
			TranslationResourceLocale.es_es => new GamePassResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GamePassResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GamePassResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GamePassResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GamePassResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GamePassResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GamePassResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GamePassResources_zh_tw(state), 
			_ => new GamePassResources_en_us(state), 
		};
	}
}
