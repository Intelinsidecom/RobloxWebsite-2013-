namespace Roblox.TranslationResources.Feature;

internal static class DevexCashOutResourceFactory
{
	public const string FullNamespace = "Feature.DevexCashOut";

	public static IDevexCashOutResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new DevexCashOutResources_de_de(state), 
			TranslationResourceLocale.en_us => new DevexCashOutResources_en_us(state), 
			TranslationResourceLocale.es_es => new DevexCashOutResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new DevexCashOutResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new DevexCashOutResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new DevexCashOutResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new DevexCashOutResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new DevexCashOutResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new DevexCashOutResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new DevexCashOutResources_zh_tw(state), 
			_ => new DevexCashOutResources_en_us(state), 
		};
	}
}
