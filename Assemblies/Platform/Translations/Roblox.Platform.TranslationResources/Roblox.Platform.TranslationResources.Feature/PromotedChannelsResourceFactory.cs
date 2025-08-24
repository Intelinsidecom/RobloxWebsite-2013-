namespace Roblox.TranslationResources.Feature;

internal static class PromotedChannelsResourceFactory
{
	public const string FullNamespace = "Feature.PromotedChannels";

	public static IPromotedChannelsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PromotedChannelsResources_de_de(state), 
			TranslationResourceLocale.en_us => new PromotedChannelsResources_en_us(state), 
			TranslationResourceLocale.es_es => new PromotedChannelsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PromotedChannelsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PromotedChannelsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PromotedChannelsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PromotedChannelsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PromotedChannelsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PromotedChannelsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PromotedChannelsResources_zh_tw(state), 
			_ => new PromotedChannelsResources_en_us(state), 
		};
	}
}
