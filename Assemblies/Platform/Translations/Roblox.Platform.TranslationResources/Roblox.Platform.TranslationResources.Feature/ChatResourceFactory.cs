namespace Roblox.TranslationResources.Feature;

internal static class ChatResourceFactory
{
	public const string FullNamespace = "Feature.Chat";

	public static IChatResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ChatResources_de_de(state), 
			TranslationResourceLocale.en_us => new ChatResources_en_us(state), 
			TranslationResourceLocale.es_es => new ChatResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ChatResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ChatResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ChatResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ChatResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ChatResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ChatResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ChatResources_zh_tw(state), 
			_ => new ChatResources_en_us(state), 
		};
	}
}
