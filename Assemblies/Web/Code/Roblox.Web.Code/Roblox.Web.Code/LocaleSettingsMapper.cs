using System;
using System.Collections.Generic;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Core;

namespace Roblox.Web.Code;

public class LocaleSettingsMapper : ILocaleSettingsMapper
{
	private Dictionary<SupportedLocaleEnum, ILocaleSettings> _LocaleSettingsMap;

	private ILocaleRolloutSettings _LocaleRolloutSettings;

	private IUgcLocaleRolloutSettings _UgcLocaleRolloutSettings;

	public LocaleSettingsMapper(ILocaleRolloutSettings localeRolloutSettings, IUgcLocaleRolloutSettings ugcLocaleRolloutSettings)
	{
		_LocaleRolloutSettings = localeRolloutSettings ?? throw new ArgumentNullException("localeRolloutSettings");
		_UgcLocaleRolloutSettings = ugcLocaleRolloutSettings ?? throw new ArgumentNullException("ugcLocaleRolloutSettings");
		_LocaleSettingsMap = GetLocaleSettingsMap();
	}

	private Dictionary<SupportedLocaleEnum, ILocaleSettings> GetLocaleSettingsMap()
	{
		return new Dictionary<SupportedLocaleEnum, ILocaleSettings>
		{
			{
				SupportedLocaleEnum.en_us,
				new LocaleSettings(() => "0.0.0", () => "0.0.0", () => "0.0.0", () => "0.0.0", () => true, () => true, () => true, () => true, () => true, () => true)
			},
			{
				SupportedLocaleEnum.es_es,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableSpanishOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableSpanishOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableSpanishFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableSpanishFullExperience, () => _LocaleRolloutSettings.IsSpanishLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsSpanishLocaleEnabledForAll, () => _LocaleRolloutSettings.IsSpanishLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsSpanishLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcSpanishLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcSpanishLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.fr_fr,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableFrenchOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableFrenchOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableFrenchFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableFrenchFullExperience, () => _LocaleRolloutSettings.IsFrenchLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsFrenchLocaleEnabledForAll, () => _LocaleRolloutSettings.IsFrenchLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsFrenchLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcFrenchLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcFrenchLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.id_id,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableIndonesianOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableIndonesianOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableIndonesianFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableIndonesianFullExperience, () => _LocaleRolloutSettings.IsIndonesianLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsIndonesianLocaleEnabledForAll, () => _LocaleRolloutSettings.IsIndonesianLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsIndonesianLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcIndonesianLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcIndonesianLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.it_it,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableItalianOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableItalianOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableItalianFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableItalianFullExperience, () => _LocaleRolloutSettings.IsItalianLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsItalianLocaleEnabledForAll, () => _LocaleRolloutSettings.IsItalianLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsItalianLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcItalianLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcItalianLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.ja_jp,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableJapaneseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableJapaneseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableJapaneseFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableJapaneseFullExperience, () => _LocaleRolloutSettings.IsJapaneseLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsJapaneseLocaleEnabledForAll, () => _LocaleRolloutSettings.IsJapaneseLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsJapaneseLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcJapaneseLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcJapaneseLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.ko_kr,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableKoreanOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableKoreanOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableKoreanFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableKoreanFullExperience, () => _LocaleRolloutSettings.IsKoreanLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsKoreanLocaleEnabledForAll, () => _LocaleRolloutSettings.IsKoreanLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsKoreanLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcKoreanLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcKoreanLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.ru_ru,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableRussianOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableRussianOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableRussianFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableRussianFullExperience, () => _LocaleRolloutSettings.IsRussianLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsRussianLocaleEnabledForAll, () => _LocaleRolloutSettings.IsRussianLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsRussianLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcRussianLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcRussianLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.th_th,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableThaiOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableThaiOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableThaiFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableThaiFullExperience, () => _LocaleRolloutSettings.IsThaiLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsThaiLocaleEnabledForAll, () => _LocaleRolloutSettings.IsThaiLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsThaiLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcThaiLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcThaiLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.tr_tr,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableTurkishOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableTurkishOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableTurkishFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableTurkishFullExperience, () => _LocaleRolloutSettings.IsTurkishLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsTurkishLocaleEnabledForAll, () => _LocaleRolloutSettings.IsTurkishLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsTurkishLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcTurkishLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcTurkishLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.vi_vn,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableVietnameseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableVietnameseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableVietnameseFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableVietnameseFullExperience, () => _LocaleRolloutSettings.IsVietnameseLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsVietnameseLocaleEnabledForAll, () => _LocaleRolloutSettings.IsVietnameseLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsVietnameseLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcVietnameseLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcVietnameseLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.pt_br,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnablePortugueseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnablePortugueseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnablePortugueseFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnablePortugueseFullExperience, () => _LocaleRolloutSettings.IsPortugueseLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsPortugueseLocaleEnabledForAll, () => _LocaleRolloutSettings.IsPortugueseLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsPortugueseLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcPortugueseLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcPortugueseLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.de_de,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableGermanOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableGermanOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableGermanFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableGermanFullExperience, () => _LocaleRolloutSettings.IsGermanLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsGermanLocaleEnabledForAll, () => _LocaleRolloutSettings.IsGermanLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsGermanLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcGermanLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcGermanLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.zh_cn,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableSimplifiedChineseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableSimplifiedChineseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableSimplifiedChineseFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableSimplifiedChineseFullExperience, () => _LocaleRolloutSettings.IsSimplifiedChineseLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsSimplifiedChineseLocaleEnabledForAll, () => _LocaleRolloutSettings.IsSimplifiedChineseLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsSimplifiedChineseLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcSimplifiedChineseLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcSimplifiedChineseLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.zh_tw,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableTraditionalChineseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableTraditionalChineseOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableTraditionalChineseFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableTraditionalChineseFullExperience, () => _LocaleRolloutSettings.IsTraditionalChineseLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsTraditionalChineseLocaleEnabledForAll, () => _LocaleRolloutSettings.IsTraditionalChineseLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsTraditionalChineseLocaleEnabledOnDesktopForFullExperience, () => _UgcLocaleRolloutSettings.IsUgcTraditionalChineseLocaleEnabledForSoothsayers, () => _UgcLocaleRolloutSettings.IsUgcTraditionalChineseLocaleEnabledForAll)
			},
			{
				SupportedLocaleEnum.zh_cjv,
				new LocaleSettings(() => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableCjvOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableCjvOnSignupAndLogin, () => _LocaleRolloutSettings.MinimumAndroidAppVersionToEnableCjvFullExperience, () => _LocaleRolloutSettings.MinimumIOSAppVersionToEnableCjvFullExperience, () => _LocaleRolloutSettings.IsCjvLocaleEnabledForSoothsayers, () => _LocaleRolloutSettings.IsCjvLocaleEnabledForAll, () => _LocaleRolloutSettings.IsCjvLocaleEnabledOnDesktopForSignupAndLogin, () => _LocaleRolloutSettings.IsCjvLocaleEnabledOnDesktopForFullExperience, () => false, () => false)
			}
		};
	}

	public ILocaleSettings GetLocaleSettings(SupportedLocaleEnum? supportedLocaleEnum)
	{
		if (!supportedLocaleEnum.HasValue)
		{
			return null;
		}
		if (_LocaleSettingsMap.TryGetValue(supportedLocaleEnum.Value, out var localeSettings))
		{
			return localeSettings;
		}
		return null;
	}
}
