namespace Roblox.TranslationResources.Authentication;

internal static class AccountRecoveryResourceFactory
{
	public const string FullNamespace = "Authentication.AccountRecovery";

	public static IAccountRecoveryResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new AccountRecoveryResources_de_de(state), 
			TranslationResourceLocale.en_us => new AccountRecoveryResources_en_us(state), 
			TranslationResourceLocale.es_es => new AccountRecoveryResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new AccountRecoveryResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new AccountRecoveryResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new AccountRecoveryResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new AccountRecoveryResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new AccountRecoveryResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new AccountRecoveryResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new AccountRecoveryResources_zh_tw(state), 
			_ => new AccountRecoveryResources_en_us(state), 
		};
	}
}
