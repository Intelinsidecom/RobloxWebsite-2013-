namespace Roblox.TranslationResources.Common;

internal static class PresenceResourceFactory
{
	public const string FullNamespace = "Common.Presence";

	public static IPresenceResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PresenceResources_de_de(state), 
			TranslationResourceLocale.en_us => new PresenceResources_en_us(state), 
			TranslationResourceLocale.es_es => new PresenceResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PresenceResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PresenceResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PresenceResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PresenceResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PresenceResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PresenceResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PresenceResources_zh_tw(state), 
			_ => new PresenceResources_en_us(state), 
		};
	}
}
