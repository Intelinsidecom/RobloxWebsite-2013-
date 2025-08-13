namespace Roblox.TranslationResources.Common;

internal static class CaptchaResourceFactory
{
	public const string FullNamespace = "Common.Captcha";

	public static ICaptchaResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CaptchaResources_de_de(state), 
			TranslationResourceLocale.en_us => new CaptchaResources_en_us(state), 
			TranslationResourceLocale.es_es => new CaptchaResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CaptchaResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CaptchaResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CaptchaResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CaptchaResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CaptchaResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CaptchaResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CaptchaResources_zh_tw(state), 
			_ => new CaptchaResources_en_us(state), 
		};
	}
}
