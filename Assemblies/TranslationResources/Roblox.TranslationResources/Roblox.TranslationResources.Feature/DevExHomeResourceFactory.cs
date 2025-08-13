namespace Roblox.TranslationResources.Feature;

internal static class DevExHomeResourceFactory
{
	public const string FullNamespace = "Feature.DevExHome";

	public static IDevExHomeResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new DevExHomeResources_de_de(state), 
			TranslationResourceLocale.en_us => new DevExHomeResources_en_us(state), 
			TranslationResourceLocale.es_es => new DevExHomeResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new DevExHomeResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new DevExHomeResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new DevExHomeResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new DevExHomeResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new DevExHomeResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new DevExHomeResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new DevExHomeResources_zh_tw(state), 
			_ => new DevExHomeResources_en_us(state), 
		};
	}
}
