namespace Roblox.TranslationResources.Feature;

internal static class PrivateSalesResourceFactory
{
	public const string FullNamespace = "Feature.PrivateSales";

	public static IPrivateSalesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PrivateSalesResources_de_de(state), 
			TranslationResourceLocale.en_us => new PrivateSalesResources_en_us(state), 
			TranslationResourceLocale.es_es => new PrivateSalesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PrivateSalesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PrivateSalesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PrivateSalesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PrivateSalesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PrivateSalesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PrivateSalesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PrivateSalesResources_zh_tw(state), 
			_ => new PrivateSalesResources_en_us(state), 
		};
	}
}
