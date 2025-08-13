namespace Roblox.TranslationResources.Feature;

internal static class SurveysGameRatingsResourceFactory
{
	public const string FullNamespace = "Feature.SurveysGameRatings";

	public static ISurveysGameRatingsResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new SurveysGameRatingsResources_de_de(state), 
			TranslationResourceLocale.en_us => new SurveysGameRatingsResources_en_us(state), 
			TranslationResourceLocale.es_es => new SurveysGameRatingsResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new SurveysGameRatingsResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new SurveysGameRatingsResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new SurveysGameRatingsResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new SurveysGameRatingsResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new SurveysGameRatingsResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new SurveysGameRatingsResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new SurveysGameRatingsResources_zh_tw(state), 
			_ => new SurveysGameRatingsResources_en_us(state), 
		};
	}
}
