namespace Roblox.TranslationResources.Feature;

internal static class DownloadAppResourceFactory
{
	public const string FullNamespace = "Feature.DownloadApp";

	public static IDownloadAppResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new DownloadAppResources_de_de(state), 
			TranslationResourceLocale.en_us => new DownloadAppResources_en_us(state), 
			TranslationResourceLocale.es_es => new DownloadAppResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new DownloadAppResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new DownloadAppResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new DownloadAppResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new DownloadAppResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new DownloadAppResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new DownloadAppResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new DownloadAppResources_zh_tw(state), 
			_ => new DownloadAppResources_en_us(state), 
		};
	}
}
