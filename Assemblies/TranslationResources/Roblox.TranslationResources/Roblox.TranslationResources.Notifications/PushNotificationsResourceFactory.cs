namespace Roblox.TranslationResources.Notifications;

internal static class PushNotificationsResourceFactory
{
	public const string FullNamespace = "Notifications.PushNotifications";

	public static IPushNotificationsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PushNotificationsResources_de_de(state), 
			TranslationResourceLocale.en_us => new PushNotificationsResources_en_us(state), 
			TranslationResourceLocale.es_es => new PushNotificationsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PushNotificationsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PushNotificationsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PushNotificationsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PushNotificationsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PushNotificationsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PushNotificationsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PushNotificationsResources_zh_tw(state), 
			_ => new PushNotificationsResources_en_us(state), 
		};
	}
}
