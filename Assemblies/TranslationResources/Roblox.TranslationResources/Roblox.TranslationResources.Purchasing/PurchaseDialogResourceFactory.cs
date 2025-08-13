namespace Roblox.TranslationResources.Purchasing;

internal static class PurchaseDialogResourceFactory
{
	public const string FullNamespace = "Purchasing.PurchaseDialog";

	public static IPurchaseDialogResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PurchaseDialogResources_de_de(state), 
			TranslationResourceLocale.en_us => new PurchaseDialogResources_en_us(state), 
			TranslationResourceLocale.es_es => new PurchaseDialogResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PurchaseDialogResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PurchaseDialogResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PurchaseDialogResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PurchaseDialogResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PurchaseDialogResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PurchaseDialogResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PurchaseDialogResources_zh_tw(state), 
			_ => new PurchaseDialogResources_en_us(state), 
		};
	}
}
