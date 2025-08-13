namespace Roblox.TranslationResources.Feature;

internal static class ReportAbuseResourceFactory
{
	public const string FullNamespace = "Feature.ReportAbuse";

	public static IReportAbuseResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ReportAbuseResources_de_de(state), 
			TranslationResourceLocale.en_us => new ReportAbuseResources_en_us(state), 
			TranslationResourceLocale.es_es => new ReportAbuseResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ReportAbuseResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ReportAbuseResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ReportAbuseResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ReportAbuseResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ReportAbuseResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ReportAbuseResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ReportAbuseResources_zh_tw(state), 
			_ => new ReportAbuseResources_en_us(state), 
		};
	}
}
