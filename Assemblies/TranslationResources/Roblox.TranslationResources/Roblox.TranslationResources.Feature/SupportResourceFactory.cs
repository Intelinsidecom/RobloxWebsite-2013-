namespace Roblox.TranslationResources.Feature;

internal static class SupportResourceFactory
{
	public const string FullNamespace = "Feature.Support";

	public static ISupportResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SupportResources_de_de(state), 
			TranslationResourceLocale.en_us => new SupportResources_en_us(state), 
			TranslationResourceLocale.es_es => new SupportResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SupportResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SupportResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SupportResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SupportResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SupportResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SupportResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SupportResources_zh_tw(state), 
			_ => new SupportResources_en_us(state), 
		};
	}
}
