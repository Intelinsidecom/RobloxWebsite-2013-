namespace Roblox.TranslationResources.Authentication;

internal static class ReturnToStudioResourceFactory
{
	public const string FullNamespace = "Authentication.ReturnToStudio";

	public static IReturnToStudioResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ReturnToStudioResources_de_de(state), 
			TranslationResourceLocale.en_us => new ReturnToStudioResources_en_us(state), 
			TranslationResourceLocale.es_es => new ReturnToStudioResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ReturnToStudioResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ReturnToStudioResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ReturnToStudioResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ReturnToStudioResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ReturnToStudioResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ReturnToStudioResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ReturnToStudioResources_zh_tw(state), 
			_ => new ReturnToStudioResources_en_us(state), 
		};
	}
}
