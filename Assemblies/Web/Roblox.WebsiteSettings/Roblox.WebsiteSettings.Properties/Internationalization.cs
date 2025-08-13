using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Internationalization : ApplicationSettingsBase
{
	private static Internationalization defaultInstance = (Internationalization)SettingsBase.Synchronized(new Internationalization());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Internationalization Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("en-us")]
	public string DefaultI18nLocaleCode => (string)this["DefaultI18nLocaleCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("English (US)")]
	public string DefaultI18nLanguageName => (string)this["DefaultI18nLanguageName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocaleSwitcherEnabledForAll => (bool)this["IsLocaleSwitcherEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocaleSwitcherEnabledForSoothsayers => (bool)this["IsLocaleSwitcherEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocaleSwitcherForAccountSettingsEnabledForSoothsayer => (bool)this["IsLocaleSwitcherForAccountSettingsEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocaleSwitcherForAccountSettingsEnabledForAll => (bool)this["IsLocaleSwitcherForAccountSettingsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForSoothsayer => (bool)this["IsI18nEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForAll => (bool)this["IsI18nEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string I18nEnabledPagesForAllCSV => (string)this["I18nEnabledPagesForAllCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("es-es")]
	public string SpanishLocaleValue => (string)this["SpanishLocaleValue"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForNotificationStream => (bool)this["IsI18nEnabledForNotificationStream"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string I18nEnabledPagesForSoothsayerCSV => (string)this["I18nEnabledPagesForSoothsayerCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserLocaleCachingRolloutPerMillion => (int)this["UserLocaleCachingRolloutPerMillion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nJSEnabled => (bool)this["IsI18nJSEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForTosPopup => (bool)this["IsI18nEnabledForTosPopup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPassLocaleThroughSignupEnabled => (bool)this["IsPassLocaleThroughSignupEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForContactUpsell => (bool)this["IsI18nEnabledForContactUpsell"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TranslationStateCachingRolloutPerMillion => (int)this["TranslationStateCachingRolloutPerMillion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForShopAmazonDialog => (bool)this["IsI18nEnabledForShopAmazonDialog"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsResetOfSupportedLocaleAllowed => (bool)this["IsResetOfSupportedLocaleAllowed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForAvatar => (bool)this["IsI18nEnabledForAvatar"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForInventory => (bool)this["IsI18nEnabledForInventory"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJSBundlingEnabledForAvatar => (bool)this["IsJSBundlingEnabledForAvatar"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTranslatorContextMenuEnabledForSoothsayer => (bool)this["IsTranslatorContextMenuEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTranslatorContextMenuEnabledForBetaTesters => (bool)this["IsTranslatorContextMenuEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TranslatorContextMenuEnabledRolloutPercentage => (int)this["TranslatorContextMenuEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TranslationUIBulkUploadAllowedUserIds => (string)this["TranslationUIBulkUploadAllowedUserIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCsvDownloadForTranslationUIEnabledForSoothsayer => (bool)this["IsCsvDownloadForTranslationUIEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCsvDownloadForTranslationUIEnabledForAll => (bool)this["IsCsvDownloadForTranslationUIEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TranslationMetadataAccessUserIds => (string)this["TranslationMetadataAccessUserIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDateTimeI18nPickerEnabledForSoothsayers => (bool)this["IsDateTimeI18nPickerEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUnlocalizedRoutingForAssetExplorerEnabled => (bool)this["IsUnlocalizedRoutingForAssetExplorerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEffectiveLocaleEnabledInPageLoadEvent => (bool)this["IsEffectiveLocaleEnabledInPageLoadEvent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsErrorCodeReturnedFromCommentsPostEndpoint => (bool)this["IsErrorCodeReturnedFromCommentsPostEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsI18nEnabledForGameClientBrowserPage => (bool)this["IsI18nEnabledForGameClientBrowserPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSettingBasedHelpPageLinkLocalizationEnabled => (bool)this["IsSettingBasedHelpPageLinkLocalizationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsServingIntlCoreFromWebAppEnabledForSoothsayer => (bool)this["IsServingIntlCoreFromWebAppEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ServingIntlCoreFromWebAppEnabledRolloutPercentage => (int)this["ServingIntlCoreFromWebAppEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsServingIntlCoreFromWebAppEnabledForGuest => (bool)this["IsServingIntlCoreFromWebAppEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDateTimeI18nEnabledForSoothsayers => (bool)this["IsDateTimeI18nEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DateTimeI18nRolloutPercentage => (int)this["DateTimeI18nRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTranslationManagementPageEnabledForSoothsayer => (bool)this["IsTranslationManagementPageEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TranslationManagementPageEnabledRolloutPercentage => (int)this["TranslationManagementPageEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DateTimeI18nPickerRolloutPercentage => (int)this["DateTimeI18nPickerRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTranslatorPortalPageEnabledForSoothsayer => (bool)this["IsTranslatorPortalPageEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TranslatorPortalPageRolloutPercentage => (int)this["TranslatorPortalPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsServingIntlUtilsFromWebAppEnabledForSoothsayer => (bool)this["IsServingIntlUtilsFromWebAppEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsServingIntlUtilsFromWebAppEnabledForGuest => (bool)this["IsServingIntlUtilsFromWebAppEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ServingIntlUtilsFromWebAppEnabledRolloutPercentage => (int)this["ServingIntlUtilsFromWebAppEnabledRolloutPercentage"];

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

	internal Internationalization()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
