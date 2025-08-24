namespace Roblox.TranslationResources.Feature;

internal static class ShopDialogResourceFactory
{
	public const string FullNamespace = "Feature.ShopDialog";

	public static IShopDialogResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ShopDialogResources_de_de(state), 
			TranslationResourceLocale.en_us => new ShopDialogResources_en_us(state), 
			TranslationResourceLocale.es_es => new ShopDialogResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ShopDialogResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ShopDialogResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ShopDialogResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ShopDialogResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ShopDialogResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ShopDialogResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ShopDialogResources_zh_tw(state), 
			_ => new ShopDialogResources_en_us(state), 
		};
	}
}
