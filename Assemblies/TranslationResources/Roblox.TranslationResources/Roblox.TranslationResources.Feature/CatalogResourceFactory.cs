namespace Roblox.TranslationResources.Feature;

internal static class CatalogResourceFactory
{
	public const string FullNamespace = "Feature.Catalog";

	public static ICatalogResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CatalogResources_de_de(state), 
			TranslationResourceLocale.en_us => new CatalogResources_en_us(state), 
			TranslationResourceLocale.es_es => new CatalogResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CatalogResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CatalogResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CatalogResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CatalogResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CatalogResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CatalogResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CatalogResources_zh_tw(state), 
			_ => new CatalogResources_en_us(state), 
		};
	}
}
