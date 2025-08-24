namespace Roblox.TranslationResources.Purchasing;

internal static class RobloxProductsResourceFactory
{
	public const string FullNamespace = "Purchasing.RobloxProducts";

	public static IRobloxProductsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new RobloxProductsResources_de_de(state), 
			TranslationResourceLocale.en_us => new RobloxProductsResources_en_us(state), 
			TranslationResourceLocale.es_es => new RobloxProductsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new RobloxProductsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new RobloxProductsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new RobloxProductsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new RobloxProductsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new RobloxProductsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new RobloxProductsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new RobloxProductsResources_zh_tw(state), 
			_ => new RobloxProductsResources_en_us(state), 
		};
	}
}
