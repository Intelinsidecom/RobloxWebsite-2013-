namespace Roblox.TranslationResources.Feature;

internal static class ItemModelResourceFactory
{
	public const string FullNamespace = "Feature.ItemModel";

	public static IItemModelResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ItemModelResources_de_de(state), 
			TranslationResourceLocale.en_us => new ItemModelResources_en_us(state), 
			TranslationResourceLocale.es_es => new ItemModelResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ItemModelResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ItemModelResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ItemModelResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ItemModelResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ItemModelResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ItemModelResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ItemModelResources_zh_tw(state), 
			_ => new ItemModelResources_en_us(state), 
		};
	}
}
