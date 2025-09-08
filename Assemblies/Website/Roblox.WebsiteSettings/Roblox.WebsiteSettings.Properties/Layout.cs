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
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Layout : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Layout defaultInstance = (Layout)SettingsBase.Synchronized(new Layout());

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

	public static Layout Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJqueryUISortableLibEnabled => (bool)this["IsJqueryUISortableLibEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsForumRedirectToFriendlyPageEnabled => (bool)this["IsForumRedirectToFriendlyPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameCardThumbnailConvertPngToJpegRolloutPercentage => (int)this["GameCardThumbnailConvertPngToJpegRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBabelPolyfillEnabled => (bool)this["IsBabelPolyfillEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BabelPolyfillEnabledOnBrowsersWhitelist => (string)this["BabelPolyfillEnabledOnBrowsersWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsAbuseReportReskinForDesktopEnabled => (bool)this["IsAbuseReportReskinForDesktopEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxThemesForSoothsayerEnabled => (bool)this["IsRobloxThemesForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RobloxThemesEnabledForUserIdWhitelist => (string)this["RobloxThemesEnabledForUserIdWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RobloxThemesRolloutPercentage => (int)this["RobloxThemesRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxThemesForGuestEnabled => (bool)this["IsRobloxThemesForGuestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewFaviconForSoothsayerEnabled => (bool)this["IsNewFaviconForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewFaviconRolloutPercentage => (int)this["NewFaviconRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxThemesInBrowsersForSoothsayerEnabled => (bool)this["IsRobloxThemesInBrowsersForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxThemesInBrowsersForBetaTesterEnabled => (bool)this["IsRobloxThemesInBrowsersForBetaTesterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RobloxThemesInBrowsersRolloutPercentage => (int)this["RobloxThemesInBrowsersRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxThemesForBetaTesterEnabled => (bool)this["IsRobloxThemesForBetaTesterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebpackEnabledComponentsCsvForAll => (string)this["WebpackEnabledComponentsCsvForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebpackEnabledComponentsCsvForSoothsayers => (string)this["WebpackEnabledComponentsCsvForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsTotalTradesInNavigationEnabledRolloutPercentage => (int)this["IsTotalTradesInNavigationEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewUserLandingAbTestingEnabled => (bool)this["IsNewUserLandingAbTestingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30000")]
	public int TimeoutOnAbtestingEnrollEndpoint => (int)this["TimeoutOnAbtestingEnrollEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreJavascriptConsoleErrorsEnabledForSoothsayer => (bool)this["AreJavascriptConsoleErrorsEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string JavascriptConsoleErrorsWhitelistUserIdsCsv => (string)this["JavascriptConsoleErrorsWhitelistUserIdsCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreJavascriptConsoleErrorsEnabledForAll => (bool)this["AreJavascriptConsoleErrorsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFriendsReactBundleEnabledOnFriendsPage => (bool)this["IsFriendsReactBundleEnabledOnFriendsPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FriendsReactBundleUserWhitelist => (string)this["FriendsReactBundleUserWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFriendsReactBundleEnabledForGuest => (bool)this["IsFriendsReactBundleEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFriendsReactBundelEnabledForSoothsayer => (bool)this["IsFriendsReactBundelEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FriendsReactBundleRolloutPercentage => (int)this["FriendsReactBundleRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FriendsReactWebAppEnabledForUserIdWhitelist => (string)this["FriendsReactWebAppEnabledForUserIdWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFriendsReactWebAppEnabledForSoothsayer => (bool)this["IsFriendsReactWebAppEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FriendsReactWebAppRolloutPercentage => (int)this["FriendsReactWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsES6CoreUtilitiesEnaledForGuest => (bool)this["IsES6CoreUtilitiesEnaledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsES6CoreUtilitiesEnabledForSoothsayer => (bool)this["IsES6CoreUtilitiesEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ES6CoreUtilitiesEnabledRolloutPercentage => (int)this["ES6CoreUtilitiesEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFriendsReactWebAppEnabledForGuest => (bool)this["IsFriendsReactWebAppEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReactVersionForFooterEnabledForSoothsayer => (bool)this["IsReactVersionForFooterEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsReactVersionForFooterEnabledForAll => (bool)this["IsReactVersionForFooterEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHinteractiveWebAppEnabledForGuest => (bool)this["IsHinteractiveWebAppEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHinteractiveWebAppEnabledForSoothsayer => (bool)this["IsHinteractiveWebAppEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int HinteractiveWebAppRolloutPercentage => (int)this["HinteractiveWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNavigationFromWebAppEnabledForGuest => (bool)this["IsNavigationFromWebAppEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNavigationFromWebAppEnabledForSoothsayer => (bool)this["IsNavigationFromWebAppEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NavigationFromWebAppRolloutPercentage => (int)this["NavigationFromWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNonSupportedLocalesEnabledForFooterForSoothsayer => (bool)this["IsNonSupportedLocalesEnabledForFooterForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNonSupportedLocalesEnabledForFooterForAll => (bool)this["IsNonSupportedLocalesEnabledForFooterForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ES6CoreUtilitiesPagesEnabled => (string)this["ES6CoreUtilitiesPagesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHinteractiveAbTestEnabled => (bool)this["IsHinteractiveAbTestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsES6CoreRobloxUtilitiesEnabled => (bool)this["IsES6CoreRobloxUtilitiesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsReactCoreScriptsEnabled => (bool)this["IsReactCoreScriptsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NavigationFromWebAppEnabledForUserIdWhitelist => (string)this["NavigationFromWebAppEnabledForUserIdWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NavigationFromWebAppEnabledForBrowserTrackerIdList => (string)this["NavigationFromWebAppEnabledForBrowserTrackerIdList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NavigationFromWebAppEnabledForBrowserTrackerIdRolloutPercentage => (int)this["NavigationFromWebAppEnabledForBrowserTrackerIdRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SentryRolloutPercentage => (int)this["SentryRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSentryEnabledForSoothsayer => (bool)this["IsSentryEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItemCardGrayLayerAbTestingEnabled => (bool)this["IsItemCardGrayLayerAbTestingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsItemCardGrayLayerEnabled => (bool)this["IsItemCardGrayLayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVoiceTestingPageForSoothsayerEnabled => (bool)this["IsVoiceTestingPageForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VoiceTestingPageEnabledForWhilteListUserIds => (string)this["VoiceTestingPageEnabledForWhilteListUserIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int VoiceTestingPageRolloutPercentage => (int)this["VoiceTestingPageRolloutPercentage"];

	internal Layout()
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
