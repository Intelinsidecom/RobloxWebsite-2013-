namespace Roblox.TranslationResources.Feature;

internal static class TranslationManagementResourceFactory
{
	public const string FullNamespace = "Feature.TranslationManagement";

	public static ITranslationManagementResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TranslationManagementResources_de_de(state), 
			TranslationResourceLocale.en_us => new TranslationManagementResources_en_us(state), 
			TranslationResourceLocale.es_es => new TranslationManagementResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TranslationManagementResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new TranslationManagementResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TranslationManagementResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TranslationManagementResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new TranslationManagementResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TranslationManagementResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TranslationManagementResources_zh_tw(state), 
			_ => new TranslationManagementResources_en_us(state), 
		};
	}
}
