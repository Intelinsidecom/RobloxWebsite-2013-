namespace Roblox.TranslationResources.Purchasing;

internal static class RixtyPinResourceFactory
{
	public const string FullNamespace = "Purchasing.RixtyPin";

	public static IRixtyPinResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new RixtyPinResources_de_de(state), 
			TranslationResourceLocale.en_us => new RixtyPinResources_en_us(state), 
			TranslationResourceLocale.es_es => new RixtyPinResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new RixtyPinResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new RixtyPinResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new RixtyPinResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new RixtyPinResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new RixtyPinResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new RixtyPinResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new RixtyPinResources_zh_tw(state), 
			_ => new RixtyPinResources_en_us(state), 
		};
	}
}
