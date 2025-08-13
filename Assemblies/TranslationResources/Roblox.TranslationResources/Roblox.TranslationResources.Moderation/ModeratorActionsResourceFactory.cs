namespace Roblox.TranslationResources.Moderation;

internal static class ModeratorActionsResourceFactory
{
	public const string FullNamespace = "Moderation.ModeratorActions";

	public static IModeratorActionsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new ModeratorActionsResources_de_de(state), 
			TranslationResourceLocale.en_us => new ModeratorActionsResources_en_us(state), 
			TranslationResourceLocale.es_es => new ModeratorActionsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new ModeratorActionsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new ModeratorActionsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new ModeratorActionsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new ModeratorActionsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new ModeratorActionsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new ModeratorActionsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new ModeratorActionsResources_zh_tw(state), 
			_ => new ModeratorActionsResources_en_us(state), 
		};
	}
}
