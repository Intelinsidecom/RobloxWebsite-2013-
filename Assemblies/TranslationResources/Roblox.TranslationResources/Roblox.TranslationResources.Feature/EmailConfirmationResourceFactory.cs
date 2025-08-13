namespace Roblox.TranslationResources.Feature;

internal static class EmailConfirmationResourceFactory
{
	public const string FullNamespace = "Feature.EmailConfirmation";

	public static IEmailConfirmationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new EmailConfirmationResources_de_de(state), 
			TranslationResourceLocale.en_us => new EmailConfirmationResources_en_us(state), 
			TranslationResourceLocale.es_es => new EmailConfirmationResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new EmailConfirmationResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new EmailConfirmationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new EmailConfirmationResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new EmailConfirmationResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new EmailConfirmationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new EmailConfirmationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new EmailConfirmationResources_zh_tw(state), 
			_ => new EmailConfirmationResources_en_us(state), 
		};
	}
}
