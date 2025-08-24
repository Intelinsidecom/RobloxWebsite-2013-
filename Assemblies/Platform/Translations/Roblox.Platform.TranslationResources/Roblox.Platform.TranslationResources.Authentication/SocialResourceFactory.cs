namespace Roblox.TranslationResources.Authentication;

internal static class SocialResourceFactory
{
	public const string FullNamespace = "Authentication.Social";

	public static ISocialResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SocialResources_de_de(state), 
			TranslationResourceLocale.en_us => new SocialResources_en_us(state), 
			TranslationResourceLocale.es_es => new SocialResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SocialResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SocialResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SocialResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SocialResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SocialResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SocialResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SocialResources_zh_tw(state), 
			_ => new SocialResources_en_us(state), 
		};
	}
}
