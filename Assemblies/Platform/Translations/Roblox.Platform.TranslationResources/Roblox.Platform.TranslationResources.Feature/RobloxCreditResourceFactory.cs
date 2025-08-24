namespace Roblox.TranslationResources.Feature;

internal static class RobloxCreditResourceFactory
{
	public const string FullNamespace = "Feature.RobloxCredit";

	public static IRobloxCreditResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new RobloxCreditResources_de_de(state), 
			TranslationResourceLocale.en_us => new RobloxCreditResources_en_us(state), 
			TranslationResourceLocale.es_es => new RobloxCreditResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new RobloxCreditResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new RobloxCreditResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new RobloxCreditResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new RobloxCreditResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new RobloxCreditResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new RobloxCreditResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new RobloxCreditResources_zh_tw(state), 
			_ => new RobloxCreditResources_en_us(state), 
		};
	}
}
