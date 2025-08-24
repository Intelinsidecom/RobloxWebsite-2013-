namespace Roblox.TranslationResources.Feature;

internal static class PremiumMigrationWebResourceFactory
{
	public const string FullNamespace = "Feature.PremiumMigrationWeb";

	public static IPremiumMigrationWebResources GetResources(TranslationResourceLocale locale, TranslationResourceState state)
	{
		return locale switch
		{
			TranslationResourceLocale.de_de => new PremiumMigrationWebResources_de_de(state), 
			TranslationResourceLocale.en_us => new PremiumMigrationWebResources_en_us(state), 
			TranslationResourceLocale.es_es => new PremiumMigrationWebResources_es_es(state), 
			TranslationResourceLocale.fr_fr => new PremiumMigrationWebResources_fr_fr(state), 
			TranslationResourceLocale.ja_jp => new PremiumMigrationWebResources_ja_jp(state), 
			TranslationResourceLocale.ko_kr => new PremiumMigrationWebResources_ko_kr(state), 
			TranslationResourceLocale.pt_br => new PremiumMigrationWebResources_pt_br(state), 
			TranslationResourceLocale.zh_cjv => new PremiumMigrationWebResources_zh_cjv(state), 
			TranslationResourceLocale.zh_cn => new PremiumMigrationWebResources_zh_cn(state), 
			TranslationResourceLocale.zh_tw => new PremiumMigrationWebResources_zh_tw(state), 
			_ => new PremiumMigrationWebResources_en_us(state), 
		};
	}
}
