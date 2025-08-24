namespace Roblox.TranslationResources.Feature;

internal static class ItemResourceFactory
{
	public const string FullNamespace = "Feature.Item";

	public static IItemResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ItemResources_de_de(state), 
			TranslationResourceLocale.en_us => new ItemResources_en_us(state), 
			TranslationResourceLocale.es_es => new ItemResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ItemResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ItemResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ItemResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ItemResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ItemResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ItemResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ItemResources_zh_tw(state), 
			_ => new ItemResources_en_us(state), 
		};
	}
}
