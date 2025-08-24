using Roblox.Platform.Localization.Core;
using Roblox.TranslationResources;

namespace Roblox.Platform.Localization.Accounts;

public static class TranslationResourceLocaleMapper
{
	/// <summary>
	/// Gets the default translation resource locale.
	/// </summary>
	/// <value>
	/// The default translation resource locale.
	/// </value>
	public static TranslationResourceLocale DefaultTranslationResourceLocale => TranslationResourceLocale.en_us;

	/// <summary>
	/// Maps a <see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" /> to a <see cref="T:Roblox.TranslationResources.TranslationResourceLocale" />.
	/// </summary>
	/// <param name="locale">The <see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" />.</param>
	/// <returns>A <see cref="T:Roblox.TranslationResources.TranslationResourceLocale" /> corresponding to a passed in <see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" />.</returns>
	public static TranslationResourceLocale MapToResourceLocale(SupportedLocaleEnum? locale)
	{
		return locale switch
		{
			SupportedLocaleEnum.de_de => TranslationResourceLocale.de_de, 
			SupportedLocaleEnum.en_us => TranslationResourceLocale.en_us, 
			SupportedLocaleEnum.es_es => TranslationResourceLocale.es_es, 
			SupportedLocaleEnum.fr_fr => TranslationResourceLocale.fr_fr, 
			SupportedLocaleEnum.ja_jp => TranslationResourceLocale.ja_jp, 
			SupportedLocaleEnum.ko_kr => TranslationResourceLocale.ko_kr, 
			SupportedLocaleEnum.pt_br => TranslationResourceLocale.pt_br, 
			SupportedLocaleEnum.zh_cn => TranslationResourceLocale.zh_cn, 
			SupportedLocaleEnum.zh_tw => TranslationResourceLocale.zh_tw, 
			SupportedLocaleEnum.zh_cjv => TranslationResourceLocale.zh_cjv, 
			_ => DefaultTranslationResourceLocale, 
		};
	}
}
