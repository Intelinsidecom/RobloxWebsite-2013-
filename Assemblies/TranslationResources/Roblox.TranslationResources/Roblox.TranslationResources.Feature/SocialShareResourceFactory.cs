namespace Roblox.TranslationResources.Feature;

internal static class SocialShareResourceFactory
{
	public const string FullNamespace = "Feature.SocialShare";

	public static ISocialShareResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SocialShareResources_de_de(state), 
			TranslationResourceLocale.en_us => new SocialShareResources_en_us(state), 
			TranslationResourceLocale.es_es => new SocialShareResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SocialShareResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SocialShareResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SocialShareResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SocialShareResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SocialShareResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SocialShareResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SocialShareResources_zh_tw(state), 
			_ => new SocialShareResources_en_us(state), 
		};
	}
}
