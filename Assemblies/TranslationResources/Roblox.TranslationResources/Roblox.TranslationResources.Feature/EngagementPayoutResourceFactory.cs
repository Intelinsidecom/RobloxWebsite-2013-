namespace Roblox.TranslationResources.Feature;

internal static class EngagementPayoutResourceFactory
{
	public const string FullNamespace = "Feature.EngagementPayout";

	public static IEngagementPayoutResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new EngagementPayoutResources_de_de(state), 
			TranslationResourceLocale.en_us => new EngagementPayoutResources_en_us(state), 
			TranslationResourceLocale.es_es => new EngagementPayoutResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new EngagementPayoutResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new EngagementPayoutResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new EngagementPayoutResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new EngagementPayoutResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new EngagementPayoutResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new EngagementPayoutResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new EngagementPayoutResources_zh_tw(state), 
			_ => new EngagementPayoutResources_en_us(state), 
		};
	}
}
