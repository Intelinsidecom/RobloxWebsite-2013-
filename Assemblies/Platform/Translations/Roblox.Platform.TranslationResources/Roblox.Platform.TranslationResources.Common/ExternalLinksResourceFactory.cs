namespace Roblox.TranslationResources.Common;

internal static class ExternalLinksResourceFactory
{
	public const string FullNamespace = "Common.ExternalLinks";

	public static IExternalLinksResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ExternalLinksResources_de_de(state), 
			TranslationResourceLocale.en_us => new ExternalLinksResources_en_us(state), 
			TranslationResourceLocale.es_es => new ExternalLinksResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ExternalLinksResources_fr_fr(state), 
			TranslationResourceLocale.ko_kr => new ExternalLinksResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ExternalLinksResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ExternalLinksResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ExternalLinksResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ExternalLinksResources_zh_tw(state), 
			_ => new ExternalLinksResources_en_us(state), 
		};
	}
}
