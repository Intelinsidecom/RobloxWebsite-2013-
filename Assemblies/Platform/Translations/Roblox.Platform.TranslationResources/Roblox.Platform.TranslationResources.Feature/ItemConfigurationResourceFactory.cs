namespace Roblox.TranslationResources.Feature;

internal static class ItemConfigurationResourceFactory
{
	public const string FullNamespace = "Feature.ItemConfiguration";

	public static IItemConfigurationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ItemConfigurationResources_de_de(state), 
			TranslationResourceLocale.en_us => new ItemConfigurationResources_en_us(state), 
			TranslationResourceLocale.es_es => new ItemConfigurationResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ItemConfigurationResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ItemConfigurationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ItemConfigurationResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ItemConfigurationResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ItemConfigurationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ItemConfigurationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ItemConfigurationResources_zh_tw(state), 
			_ => new ItemConfigurationResources_en_us(state), 
		};
	}
}
