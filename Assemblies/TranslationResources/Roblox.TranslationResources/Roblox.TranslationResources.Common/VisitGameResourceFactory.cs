namespace Roblox.TranslationResources.Common;

internal static class VisitGameResourceFactory
{
	public const string FullNamespace = "Common.VisitGame";

	public static IVisitGameResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new VisitGameResources_de_de(state), 
			TranslationResourceLocale.en_us => new VisitGameResources_en_us(state), 
			TranslationResourceLocale.es_es => new VisitGameResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new VisitGameResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new VisitGameResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new VisitGameResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new VisitGameResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new VisitGameResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new VisitGameResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new VisitGameResources_zh_tw(state), 
			_ => new VisitGameResources_en_us(state), 
		};
	}
}
