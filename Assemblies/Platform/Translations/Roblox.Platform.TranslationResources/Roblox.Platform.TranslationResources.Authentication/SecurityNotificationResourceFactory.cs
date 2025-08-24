namespace Roblox.TranslationResources.Authentication;

internal static class SecurityNotificationResourceFactory
{
	public const string FullNamespace = "Authentication.SecurityNotification";

	public static ISecurityNotificationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SecurityNotificationResources_de_de(state), 
			TranslationResourceLocale.en_us => new SecurityNotificationResources_en_us(state), 
			TranslationResourceLocale.es_es => new SecurityNotificationResources_es_es(state), 
			TranslationResourceLocale.ja_jp => new SecurityNotificationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SecurityNotificationResources_ko_kr(state), 
			TranslationResourceLocale.zh_cjv => new SecurityNotificationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SecurityNotificationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SecurityNotificationResources_zh_tw(state), 
			_ => new SecurityNotificationResources_en_us(state), 
		};
	}
}
