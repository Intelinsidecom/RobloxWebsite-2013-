namespace Roblox.TranslationResources.Purchasing;

internal static class RedeemGameCardResourceFactory
{
	public const string FullNamespace = "Purchasing.RedeemGameCard";

	public static IRedeemGameCardResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new RedeemGameCardResources_de_de(state), 
			TranslationResourceLocale.en_us => new RedeemGameCardResources_en_us(state), 
			TranslationResourceLocale.es_es => new RedeemGameCardResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new RedeemGameCardResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new RedeemGameCardResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new RedeemGameCardResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new RedeemGameCardResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new RedeemGameCardResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new RedeemGameCardResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new RedeemGameCardResources_zh_tw(state), 
			_ => new RedeemGameCardResources_en_us(state), 
		};
	}
}
