namespace Roblox.TranslationResources.Feature;

internal static class FavoritesResourceFactory
{
	public const string FullNamespace = "Feature.Favorites";

	public static IFavoritesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new FavoritesResources_de_de(state), 
			TranslationResourceLocale.en_us => new FavoritesResources_en_us(state), 
			TranslationResourceLocale.es_es => new FavoritesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new FavoritesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new FavoritesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new FavoritesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new FavoritesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new FavoritesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new FavoritesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new FavoritesResources_zh_tw(state), 
			_ => new FavoritesResources_en_us(state), 
		};
	}
}
