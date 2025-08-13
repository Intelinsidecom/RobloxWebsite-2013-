namespace Roblox.TranslationResources.Feature;

internal static class CommentsResourceFactory
{
	public const string FullNamespace = "Feature.Comments";

	public static ICommentsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new CommentsResources_de_de(state), 
			TranslationResourceLocale.en_us => new CommentsResources_en_us(state), 
			TranslationResourceLocale.es_es => new CommentsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new CommentsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new CommentsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new CommentsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new CommentsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new CommentsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new CommentsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new CommentsResources_zh_tw(state), 
			_ => new CommentsResources_en_us(state), 
		};
	}
}
