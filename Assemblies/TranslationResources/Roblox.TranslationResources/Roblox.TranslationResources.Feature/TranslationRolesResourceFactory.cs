namespace Roblox.TranslationResources.Feature;

internal static class TranslationRolesResourceFactory
{
	public const string FullNamespace = "Feature.TranslationRoles";

	public static ITranslationRolesResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new TranslationRolesResources_de_de(state), 
			TranslationResourceLocale.en_us => new TranslationRolesResources_en_us(state), 
			TranslationResourceLocale.es_es => new TranslationRolesResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new TranslationRolesResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new TranslationRolesResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new TranslationRolesResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new TranslationRolesResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new TranslationRolesResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new TranslationRolesResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new TranslationRolesResources_zh_tw(state), 
			_ => new TranslationRolesResources_en_us(state), 
		};
	}
}
