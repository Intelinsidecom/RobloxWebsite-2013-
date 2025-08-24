namespace Roblox.TranslationResources.Feature;

internal static class AvatarResourceFactory
{
	public const string FullNamespace = "Feature.Avatar";

	public static IAvatarResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new AvatarResources_de_de(state), 
			TranslationResourceLocale.en_us => new AvatarResources_en_us(state), 
			TranslationResourceLocale.es_es => new AvatarResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new AvatarResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new AvatarResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new AvatarResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new AvatarResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new AvatarResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new AvatarResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new AvatarResources_zh_tw(state), 
			_ => new AvatarResources_en_us(state), 
		};
	}
}
