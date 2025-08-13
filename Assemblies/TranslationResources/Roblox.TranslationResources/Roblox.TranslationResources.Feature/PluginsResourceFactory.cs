namespace Roblox.TranslationResources.Feature;

internal static class PluginsResourceFactory
{
	public const string FullNamespace = "Feature.Plugins";

	public static IPluginsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PluginsResources_de_de(state), 
			TranslationResourceLocale.en_us => new PluginsResources_en_us(state), 
			TranslationResourceLocale.es_es => new PluginsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PluginsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PluginsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PluginsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PluginsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PluginsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PluginsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PluginsResources_zh_tw(state), 
			_ => new PluginsResources_en_us(state), 
		};
	}
}
