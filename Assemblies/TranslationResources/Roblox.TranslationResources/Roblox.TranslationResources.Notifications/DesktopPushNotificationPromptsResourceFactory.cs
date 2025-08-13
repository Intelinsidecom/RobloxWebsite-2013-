namespace Roblox.TranslationResources.Notifications;

internal static class DesktopPushNotificationPromptsResourceFactory
{
	public const string FullNamespace = "Notifications.DesktopPushNotificationPrompts";

	public static IDesktopPushNotificationPromptsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new DesktopPushNotificationPromptsResources_de_de(state), 
			TranslationResourceLocale.en_us => new DesktopPushNotificationPromptsResources_en_us(state), 
			TranslationResourceLocale.es_es => new DesktopPushNotificationPromptsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new DesktopPushNotificationPromptsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new DesktopPushNotificationPromptsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new DesktopPushNotificationPromptsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new DesktopPushNotificationPromptsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new DesktopPushNotificationPromptsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new DesktopPushNotificationPromptsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new DesktopPushNotificationPromptsResources_zh_tw(state), 
			_ => new DesktopPushNotificationPromptsResources_en_us(state), 
		};
	}
}
