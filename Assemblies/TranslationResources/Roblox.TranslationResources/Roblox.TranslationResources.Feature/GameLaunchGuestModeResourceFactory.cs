namespace Roblox.TranslationResources.Feature;

internal static class GameLaunchGuestModeResourceFactory
{
	public const string FullNamespace = "Feature.GameLaunchGuestMode";

	public static IGameLaunchGuestModeResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GameLaunchGuestModeResources_de_de(state), 
			TranslationResourceLocale.en_us => new GameLaunchGuestModeResources_en_us(state), 
			TranslationResourceLocale.es_es => new GameLaunchGuestModeResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GameLaunchGuestModeResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GameLaunchGuestModeResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GameLaunchGuestModeResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GameLaunchGuestModeResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GameLaunchGuestModeResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GameLaunchGuestModeResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GameLaunchGuestModeResources_zh_tw(state), 
			_ => new GameLaunchGuestModeResources_en_us(state), 
		};
	}
}
