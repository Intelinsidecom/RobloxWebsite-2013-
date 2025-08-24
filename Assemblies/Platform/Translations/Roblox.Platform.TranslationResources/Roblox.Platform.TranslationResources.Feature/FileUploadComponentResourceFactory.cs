namespace Roblox.TranslationResources.Feature;

internal static class FileUploadComponentResourceFactory
{
	public const string FullNamespace = "Feature.FileUploadComponent";

	public static IFileUploadComponentResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new FileUploadComponentResources_de_de(state), 
			TranslationResourceLocale.en_us => new FileUploadComponentResources_en_us(state), 
			TranslationResourceLocale.es_es => new FileUploadComponentResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new FileUploadComponentResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new FileUploadComponentResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new FileUploadComponentResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new FileUploadComponentResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new FileUploadComponentResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new FileUploadComponentResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new FileUploadComponentResources_zh_tw(state), 
			_ => new FileUploadComponentResources_en_us(state), 
		};
	}
}
