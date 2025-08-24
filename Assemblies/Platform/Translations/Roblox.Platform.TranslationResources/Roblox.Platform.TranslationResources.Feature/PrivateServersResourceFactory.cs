namespace Roblox.TranslationResources.Feature;

internal static class PrivateServersResourceFactory
{
	public const string FullNamespace = "Feature.PrivateServers";

	public static IPrivateServersResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PrivateServersResources_de_de(state), 
			TranslationResourceLocale.en_us => new PrivateServersResources_en_us(state), 
			TranslationResourceLocale.es_es => new PrivateServersResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PrivateServersResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PrivateServersResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PrivateServersResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PrivateServersResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PrivateServersResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PrivateServersResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PrivateServersResources_zh_tw(state), 
			_ => new PrivateServersResources_en_us(state), 
		};
	}
}
