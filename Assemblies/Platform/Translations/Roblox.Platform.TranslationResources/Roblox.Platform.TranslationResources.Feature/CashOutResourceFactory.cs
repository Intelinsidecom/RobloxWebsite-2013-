namespace Roblox.TranslationResources.Feature;

internal static class CashOutResourceFactory
{
	public const string FullNamespace = "Feature.CashOut";

	public static ICashOutResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CashOutResources_de_de(state), 
			TranslationResourceLocale.en_us => new CashOutResources_en_us(state), 
			TranslationResourceLocale.es_es => new CashOutResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CashOutResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CashOutResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CashOutResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CashOutResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CashOutResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CashOutResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CashOutResources_zh_tw(state), 
			_ => new CashOutResources_en_us(state), 
		};
	}
}
