namespace Roblox.TranslationResources.Feature;

internal static class FriendsResourceFactory
{
	public const string FullNamespace = "Feature.Friends";

	public static IFriendsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new FriendsResources_de_de(state), 
			TranslationResourceLocale.en_us => new FriendsResources_en_us(state), 
			TranslationResourceLocale.es_es => new FriendsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new FriendsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new FriendsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new FriendsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new FriendsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new FriendsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new FriendsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new FriendsResources_zh_tw(state), 
			_ => new FriendsResources_en_us(state), 
		};
	}
}
