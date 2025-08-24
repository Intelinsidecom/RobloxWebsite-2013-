namespace Roblox.TranslationResources.Feature;

internal static class AccountSettingsResourceFactory
{
	public const string FullNamespace = "Feature.AccountSettings";

	public static IAccountSettingsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new AccountSettingsResources_de_de(state), 
			TranslationResourceLocale.en_us => new AccountSettingsResources_en_us(state), 
			TranslationResourceLocale.es_es => new AccountSettingsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new AccountSettingsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new AccountSettingsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new AccountSettingsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new AccountSettingsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new AccountSettingsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new AccountSettingsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new AccountSettingsResources_zh_tw(state), 
			_ => new AccountSettingsResources_en_us(state), 
		};
	}
}
