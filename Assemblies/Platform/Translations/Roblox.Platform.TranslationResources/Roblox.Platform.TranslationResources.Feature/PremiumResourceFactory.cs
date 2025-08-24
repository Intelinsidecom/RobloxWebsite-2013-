namespace Roblox.TranslationResources.Feature;

internal static class PremiumResourceFactory
{
	public const string FullNamespace = "Feature.Premium";

	public static IPremiumResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PremiumResources_de_de(state), 
			TranslationResourceLocale.en_us => new PremiumResources_en_us(state), 
			TranslationResourceLocale.es_es => new PremiumResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PremiumResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PremiumResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PremiumResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PremiumResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PremiumResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PremiumResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PremiumResources_zh_tw(state), 
			_ => new PremiumResources_en_us(state), 
		};
	}
}
