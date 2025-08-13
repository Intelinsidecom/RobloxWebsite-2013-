namespace Roblox.TranslationResources.Common;

internal static class TermsOfServiceResourceFactory
{
	public const string FullNamespace = "Common.TermsOfService";

	public static ITermsOfServiceResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TermsOfServiceResources_de_de(state), 
			TranslationResourceLocale.en_us => new TermsOfServiceResources_en_us(state), 
			TranslationResourceLocale.es_es => new TermsOfServiceResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TermsOfServiceResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new TermsOfServiceResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TermsOfServiceResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TermsOfServiceResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new TermsOfServiceResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TermsOfServiceResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TermsOfServiceResources_zh_tw(state), 
			_ => new TermsOfServiceResources_en_us(state), 
		};
	}
}
