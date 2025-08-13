using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Platform.Localization.Accounts.Properties;

[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class LocaleRolloutSettings : ApplicationSettingsBase, ILocaleRolloutSettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static LocaleRolloutSettings defaultInstance = (LocaleRolloutSettings)SettingsBase.Synchronized(new LocaleRolloutSettings());

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	public static LocaleRolloutSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSpanishLocaleEnabledForSoothsayers => (bool)this["IsSpanishLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableSpanishOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableSpanishOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableSpanishFullExperience => (string)this["MinimumIOSAppVersionToEnableSpanishFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableSpanishOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableSpanishOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableSpanishFullExperience => (string)this["MinimumAndroidAppVersionToEnableSpanishFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSpanishLocaleEnabledForAll => (bool)this["IsSpanishLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnablePortugueseOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnablePortugueseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnablePortugueseOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnablePortugueseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableThaiOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableThaiOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableThaiOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableThaiOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableRussianOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableRussianOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableRussianOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableRussianOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableIndonesianOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableIndonesianOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableIndonesianOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableIndonesianOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableVietnameseOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableVietnameseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableVietnameseOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableVietnameseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableTurkishOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableTurkishOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableTurkishOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableTurkishOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableKoreanOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableKoreanOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableKoreanOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableKoreanOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableGermanOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableGermanOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableGermanOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableGermanOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableFrenchOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableFrenchOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableFrenchOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableFrenchOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableItalianOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableItalianOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableItalianOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableItalianOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableJapaneseOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableJapaneseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableJapaneseOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableJapaneseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableFrenchFullExperience => (string)this["MinimumAndroidAppVersionToEnableFrenchFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableFrenchFullExperience => (string)this["MinimumIOSAppVersionToEnableFrenchFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFrenchLocaleEnabledForSoothsayers => (bool)this["IsFrenchLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFrenchLocaleEnabledForAll => (bool)this["IsFrenchLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableIndonesianFullExperience => (string)this["MinimumAndroidAppVersionToEnableIndonesianFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableIndonesianFullExperience => (string)this["MinimumIOSAppVersionToEnableIndonesianFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIndonesianLocaleEnabledForSoothsayers => (bool)this["IsIndonesianLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIndonesianLocaleEnabledForAll => (bool)this["IsIndonesianLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableItalianFullExperience => (string)this["MinimumAndroidAppVersionToEnableItalianFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableItalianFullExperience => (string)this["MinimumIOSAppVersionToEnableItalianFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItalianLocaleEnabledForSoothsayers => (bool)this["IsItalianLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItalianLocaleEnabledForAll => (bool)this["IsItalianLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableJapaneseFullExperience => (string)this["MinimumAndroidAppVersionToEnableJapaneseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableJapaneseFullExperience => (string)this["MinimumIOSAppVersionToEnableJapaneseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJapaneseLocaleEnabledForSoothsayers => (bool)this["IsJapaneseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJapaneseLocaleEnabledForAll => (bool)this["IsJapaneseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableKoreanFullExperience => (string)this["MinimumAndroidAppVersionToEnableKoreanFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableKoreanFullExperience => (string)this["MinimumIOSAppVersionToEnableKoreanFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKoreanLocaleEnabledForSoothsayers => (bool)this["IsKoreanLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKoreanLocaleEnabledForAll => (bool)this["IsKoreanLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableRussianFullExperience => (string)this["MinimumAndroidAppVersionToEnableRussianFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableRussianFullExperience => (string)this["MinimumIOSAppVersionToEnableRussianFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRussianLocaleEnabledForSoothsayers => (bool)this["IsRussianLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRussianLocaleEnabledForAll => (bool)this["IsRussianLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableThaiFullExperience => (string)this["MinimumAndroidAppVersionToEnableThaiFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableThaiFullExperience => (string)this["MinimumIOSAppVersionToEnableThaiFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThaiLocaleEnabledForSoothsayers => (bool)this["IsThaiLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThaiLocaleEnabledForAll => (bool)this["IsThaiLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableTurkishFullExperience => (string)this["MinimumAndroidAppVersionToEnableTurkishFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableTurkishFullExperience => (string)this["MinimumIOSAppVersionToEnableTurkishFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTurkishLocaleEnabledForSoothsayers => (bool)this["IsTurkishLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTurkishLocaleEnabledForAll => (bool)this["IsTurkishLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableVietnameseFullExperience => (string)this["MinimumAndroidAppVersionToEnableVietnameseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableVietnameseFullExperience => (string)this["MinimumIOSAppVersionToEnableVietnameseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVietnameseLocaleEnabledForSoothsayers => (bool)this["IsVietnameseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVietnameseLocaleEnabledForAll => (bool)this["IsVietnameseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnablePortugueseFullExperience => (string)this["MinimumAndroidAppVersionToEnablePortugueseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnablePortugueseFullExperience => (string)this["MinimumIOSAppVersionToEnablePortugueseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPortugueseLocaleEnabledForSoothsayers => (bool)this["IsPortugueseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPortugueseLocaleEnabledForAll => (bool)this["IsPortugueseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableGermanFullExperience => (string)this["MinimumAndroidAppVersionToEnableGermanFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableGermanFullExperience => (string)this["MinimumIOSAppVersionToEnableGermanFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGermanLocaleEnabledForSoothsayers => (bool)this["IsGermanLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGermanLocaleEnabledForAll => (bool)this["IsGermanLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSpanishLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsSpanishLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSpanishLocaleEnabledOnDesktopForFullExperience => (bool)this["IsSpanishLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGermanLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsGermanLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGermanLocaleEnabledOnDesktopForFullExperience => (bool)this["IsGermanLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIndonesianLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsIndonesianLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIndonesianLocaleEnabledOnDesktopForFullExperience => (bool)this["IsIndonesianLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItalianLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsItalianLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItalianLocaleEnabledOnDesktopForFullExperience => (bool)this["IsItalianLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJapaneseLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsJapaneseLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJapaneseLocaleEnabledOnDesktopForFullExperience => (bool)this["IsJapaneseLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKoreanLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsKoreanLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKoreanLocaleEnabledOnDesktopForFullExperience => (bool)this["IsKoreanLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPortugueseLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsPortugueseLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPortugueseLocaleEnabledOnDesktopForFullExperience => (bool)this["IsPortugueseLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRussianLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsRussianLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRussianLocaleEnabledOnDesktopForFullExperience => (bool)this["IsRussianLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThaiLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsThaiLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThaiLocaleEnabledOnDesktopForFullExperience => (bool)this["IsThaiLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTurkishLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsTurkishLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTurkishLocaleEnabledOnDesktopForFullExperience => (bool)this["IsTurkishLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVietnameseLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsVietnameseLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVietnameseLocaleEnabledOnDesktopForFullExperience => (bool)this["IsVietnameseLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFrenchLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsFrenchLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFrenchLocaleEnabledOnDesktopForFullExperience => (bool)this["IsFrenchLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsResetOfSupportedLocaleAllowed => (bool)this["IsResetOfSupportedLocaleAllowed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifiedChineseLocaleEnabledForAll => (bool)this["IsSimplifiedChineseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifiedChineseLocaleEnabledForSoothsayers => (bool)this["IsSimplifiedChineseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifiedChineseLocaleEnabledOnDesktopForFullExperience => (bool)this["IsSimplifiedChineseLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifiedChineseLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsSimplifiedChineseLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableSimplifiedChineseFullExperience => (string)this["MinimumAndroidAppVersionToEnableSimplifiedChineseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableSimplifiedChineseOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableSimplifiedChineseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableSimplifiedChineseFullExperience => (string)this["MinimumIOSAppVersionToEnableSimplifiedChineseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableSimplifiedChineseOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableSimplifiedChineseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTraditionalChineseLocaleEnabledForAll => (bool)this["IsTraditionalChineseLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTraditionalChineseLocaleEnabledForSoothsayers => (bool)this["IsTraditionalChineseLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTraditionalChineseLocaleEnabledOnDesktopForFullExperience => (bool)this["IsTraditionalChineseLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTraditionalChineseLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsTraditionalChineseLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableTraditionalChineseFullExperience => (string)this["MinimumAndroidAppVersionToEnableTraditionalChineseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableTraditionalChineseOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableTraditionalChineseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableTraditionalChineseFullExperience => (string)this["MinimumIOSAppVersionToEnableTraditionalChineseFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableTraditionalChineseOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableTraditionalChineseOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCjvLocaleEnabledForAll => (bool)this["IsCjvLocaleEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCjvLocaleEnabledForSoothsayers => (bool)this["IsCjvLocaleEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCjvLocaleEnabledOnDesktopForFullExperience => (bool)this["IsCjvLocaleEnabledOnDesktopForFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCjvLocaleEnabledOnDesktopForSignupAndLogin => (bool)this["IsCjvLocaleEnabledOnDesktopForSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableCjvFullExperience => (string)this["MinimumAndroidAppVersionToEnableCjvFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumAndroidAppVersionToEnableCjvOnSignupAndLogin => (string)this["MinimumAndroidAppVersionToEnableCjvOnSignupAndLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableCjvFullExperience => (string)this["MinimumIOSAppVersionToEnableCjvFullExperience"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MinimumIOSAppVersionToEnableCjvOnSignupAndLogin => (string)this["MinimumIOSAppVersionToEnableCjvOnSignupAndLogin"];

	internal LocaleRolloutSettings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
