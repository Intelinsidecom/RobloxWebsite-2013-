namespace Roblox.TranslationResources.Communication;

internal static class CommonEmailResourceFactory
{
	public const string FullNamespace = "Communication.CommonEmail";

	public static ICommonEmailResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CommonEmailResources_de_de(state), 
			TranslationResourceLocale.en_us => new CommonEmailResources_en_us(state), 
			TranslationResourceLocale.es_es => new CommonEmailResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CommonEmailResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CommonEmailResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CommonEmailResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CommonEmailResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CommonEmailResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CommonEmailResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CommonEmailResources_zh_tw(state), 
			_ => new CommonEmailResources_en_us(state), 
		};
	}
}
