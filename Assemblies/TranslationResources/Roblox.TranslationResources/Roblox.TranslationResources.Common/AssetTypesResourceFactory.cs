namespace Roblox.TranslationResources.Common;

internal static class AssetTypesResourceFactory
{
	public const string FullNamespace = "Common.AssetTypes";

	public static IAssetTypesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new AssetTypesResources_de_de(state), 
			TranslationResourceLocale.en_us => new AssetTypesResources_en_us(state), 
			TranslationResourceLocale.es_es => new AssetTypesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new AssetTypesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new AssetTypesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new AssetTypesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new AssetTypesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new AssetTypesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new AssetTypesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new AssetTypesResources_zh_tw(state), 
			_ => new AssetTypesResources_en_us(state), 
		};
	}
}
