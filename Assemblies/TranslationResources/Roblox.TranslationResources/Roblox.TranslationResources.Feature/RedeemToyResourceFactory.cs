namespace Roblox.TranslationResources.Feature;

internal static class RedeemToyResourceFactory
{
	public const string FullNamespace = "Feature.RedeemToy";

	public static IRedeemToyResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new RedeemToyResources_de_de(state), 
			TranslationResourceLocale.en_us => new RedeemToyResources_en_us(state), 
			TranslationResourceLocale.es_es => new RedeemToyResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new RedeemToyResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new RedeemToyResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new RedeemToyResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new RedeemToyResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new RedeemToyResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new RedeemToyResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new RedeemToyResources_zh_tw(state), 
			_ => new RedeemToyResources_en_us(state), 
		};
	}
}
