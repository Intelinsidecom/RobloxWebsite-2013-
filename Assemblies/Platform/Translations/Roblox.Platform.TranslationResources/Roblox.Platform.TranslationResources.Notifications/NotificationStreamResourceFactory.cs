namespace Roblox.TranslationResources.Notifications;

internal static class NotificationStreamResourceFactory
{
	public const string FullNamespace = "Notifications.NotificationStream";

	public static INotificationStreamResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new NotificationStreamResources_de_de(state), 
			TranslationResourceLocale.en_us => new NotificationStreamResources_en_us(state), 
			TranslationResourceLocale.es_es => new NotificationStreamResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new NotificationStreamResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new NotificationStreamResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new NotificationStreamResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new NotificationStreamResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new NotificationStreamResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new NotificationStreamResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new NotificationStreamResources_zh_tw(state), 
			_ => new NotificationStreamResources_en_us(state), 
		};
	}
}
