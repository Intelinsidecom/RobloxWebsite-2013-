namespace Roblox.TranslationResources.Feature;

internal static class PeopleListResourceFactory
{
	public const string FullNamespace = "Feature.PeopleList";

	public static IPeopleListResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PeopleListResources_de_de(state), 
			TranslationResourceLocale.en_us => new PeopleListResources_en_us(state), 
			TranslationResourceLocale.es_es => new PeopleListResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PeopleListResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PeopleListResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PeopleListResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PeopleListResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PeopleListResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PeopleListResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PeopleListResources_zh_tw(state), 
			_ => new PeopleListResources_en_us(state), 
		};
	}
}
