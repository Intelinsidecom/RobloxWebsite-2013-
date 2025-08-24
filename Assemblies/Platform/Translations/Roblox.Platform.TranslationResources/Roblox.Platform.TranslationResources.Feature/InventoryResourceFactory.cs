namespace Roblox.TranslationResources.Feature;

internal static class InventoryResourceFactory
{
	public const string FullNamespace = "Feature.Inventory";

	public static IInventoryResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new InventoryResources_de_de(state), 
			TranslationResourceLocale.en_us => new InventoryResources_en_us(state), 
			TranslationResourceLocale.es_es => new InventoryResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new InventoryResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new InventoryResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new InventoryResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new InventoryResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new InventoryResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new InventoryResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new InventoryResources_zh_tw(state), 
			_ => new InventoryResources_en_us(state), 
		};
	}
}
