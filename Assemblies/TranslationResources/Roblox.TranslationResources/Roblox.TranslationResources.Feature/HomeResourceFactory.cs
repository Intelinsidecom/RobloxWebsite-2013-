namespace Roblox.TranslationResources.Feature;

internal static class HomeResourceFactory
{
	public const string FullNamespace = "Feature.Home";

	public static IHomeResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new HomeResources_de_de(state), 
			TranslationResourceLocale.en_us => new HomeResources_en_us(state), 
			TranslationResourceLocale.es_es => new HomeResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new HomeResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new HomeResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new HomeResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new HomeResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new HomeResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new HomeResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new HomeResources_zh_tw(state), 
			_ => new HomeResources_en_us(state), 
		};
	}
}
