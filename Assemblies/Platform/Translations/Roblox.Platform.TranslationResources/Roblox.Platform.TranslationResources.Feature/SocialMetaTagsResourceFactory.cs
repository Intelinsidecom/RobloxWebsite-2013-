namespace Roblox.TranslationResources.Feature;

internal static class SocialMetaTagsResourceFactory
{
	public const string FullNamespace = "Feature.SocialMetaTags";

	public static ISocialMetaTagsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SocialMetaTagsResources_de_de(state), 
			TranslationResourceLocale.en_us => new SocialMetaTagsResources_en_us(state), 
			TranslationResourceLocale.es_es => new SocialMetaTagsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SocialMetaTagsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SocialMetaTagsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SocialMetaTagsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SocialMetaTagsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SocialMetaTagsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SocialMetaTagsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SocialMetaTagsResources_zh_tw(state), 
			_ => new SocialMetaTagsResources_en_us(state), 
		};
	}
}
