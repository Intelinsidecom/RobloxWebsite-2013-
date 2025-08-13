namespace Roblox.TranslationResources.Feature;

internal static class PlacesListResourceFactory
{
	public const string FullNamespace = "Feature.PlacesList";

	public static IPlacesListResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PlacesListResources_de_de(state), 
			TranslationResourceLocale.en_us => new PlacesListResources_en_us(state), 
			TranslationResourceLocale.es_es => new PlacesListResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PlacesListResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PlacesListResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PlacesListResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PlacesListResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PlacesListResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PlacesListResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PlacesListResources_zh_tw(state), 
			_ => new PlacesListResources_en_us(state), 
		};
	}
}
