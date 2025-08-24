namespace Roblox.TranslationResources.Feature;

internal static class PremiumMigrationResourceFactory
{
	public const string FullNamespace = "Feature.PremiumMigration";

	public static IPremiumMigrationResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PremiumMigrationResources_de_de(state), 
			TranslationResourceLocale.en_us => new PremiumMigrationResources_en_us(state), 
			TranslationResourceLocale.es_es => new PremiumMigrationResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PremiumMigrationResources_fr_fr(state), 
			TranslationResourceLocale.it_it => new PremiumMigrationResources_it_it(state), 
			TranslationResourceLocale.ja_jp => new PremiumMigrationResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PremiumMigrationResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PremiumMigrationResources_pt_br(state), 
			TranslationResourceLocale.ru_ru => new PremiumMigrationResources_ru_ru(state), 
			TranslationResourceLocale.zh_cjv => new PremiumMigrationResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PremiumMigrationResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PremiumMigrationResources_zh_tw(state), 
			_ => new PremiumMigrationResources_en_us(state), 
		};
	}
}
