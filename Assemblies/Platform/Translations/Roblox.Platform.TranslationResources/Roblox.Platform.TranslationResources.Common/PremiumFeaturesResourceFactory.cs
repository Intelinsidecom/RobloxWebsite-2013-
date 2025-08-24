namespace Roblox.TranslationResources.Common;

internal static class PremiumFeaturesResourceFactory
{
	public const string FullNamespace = "Common.PremiumFeatures";

	public static IPremiumFeaturesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PremiumFeaturesResources_de_de(state), 
			TranslationResourceLocale.en_us => new PremiumFeaturesResources_en_us(state), 
			TranslationResourceLocale.es_es => new PremiumFeaturesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PremiumFeaturesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PremiumFeaturesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PremiumFeaturesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PremiumFeaturesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PremiumFeaturesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PremiumFeaturesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PremiumFeaturesResources_zh_tw(state), 
			_ => new PremiumFeaturesResources_en_us(state), 
		};
	}
}
