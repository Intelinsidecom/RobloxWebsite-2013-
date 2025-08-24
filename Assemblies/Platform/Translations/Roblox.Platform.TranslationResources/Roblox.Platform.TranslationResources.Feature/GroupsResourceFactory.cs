namespace Roblox.TranslationResources.Feature;

internal static class GroupsResourceFactory
{
	public const string FullNamespace = "Feature.Groups";

	public static IGroupsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new GroupsResources_de_de(state), 
			TranslationResourceLocale.en_us => new GroupsResources_en_us(state), 
			TranslationResourceLocale.es_es => new GroupsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new GroupsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new GroupsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new GroupsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new GroupsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new GroupsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new GroupsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new GroupsResources_zh_tw(state), 
			_ => new GroupsResources_en_us(state), 
		};
	}
}
