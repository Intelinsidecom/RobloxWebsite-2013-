using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Web.Code.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
public sealed class Settings : ApplicationSettingsBase, ICookieConstraintSettings, IAccountLocaleInitializerSettings
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BillingServiceUrl => (string)this["BillingServiceUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int IpadMinimumVersionForGamePlay => (int)this["IpadMinimumVersionForGamePlay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int IpodMinimumVersionForGamePlay => (int)this["IpodMinimumVersionForGamePlay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int IphoneMinimumVersionForGamePlay => (int)this["IphoneMinimumVersionForGamePlay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IOSMinimumVersionForGamePlayCheckEnabled => (bool)this["IOSMinimumVersionForGamePlayCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectMobileGamesToWWW => (bool)this["RedirectMobileGamesToWWW"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IOSSmallScreenDevicesGamePlayEnabled => (bool)this["IOSSmallScreenDevicesGamePlayEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iPadNewGamesPageEnabled => (bool)this["iPadNewGamesPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IOSAllowGameOwnersToPlay => (bool)this["IOSAllowGameOwnersToPlay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iPhoneNewGamesPageEnabled => (bool)this["iPhoneNewGamesPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GoogleRecaptchaVerifyUrl => (string)this["GoogleRecaptchaVerifyUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseVerificationStyleGuide => (bool)this["UseVerificationStyleGuide"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IOSReceiptEncodingWorkaroundEnabled => (bool)this["IOSReceiptEncodingWorkaroundEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IOSLogAllReceipts => (bool)this["IOSLogAllReceipts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PermissionsClientApiKey => (string)this["PermissionsClientApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseFakeDataForGamesResults => (bool)this["UseFakeDataForGamesResults"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchGamesFromIE11Enabled => (bool)this["LaunchGamesFromIE11Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableTwoFactorAuthOnIpad => (bool)this["EnableTwoFactorAuthOnIpad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("MobileDefaultGameList")]
	public string MobileDefaultGameListExperimentName => (string)this["MobileDefaultGameListExperimentName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1,8")]
	public string MobileDefaultGameListExperimentVariation1CSV => (string)this["MobileDefaultGameListExperimentVariation1CSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("11,1")]
	public string MobileDefaultGameListExperimentControlCSV => (string)this["MobileDefaultGameListExperimentControlCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("11,8")]
	public string MobileDefaultGameListExperimentVariation2CSV => (string)this["MobileDefaultGameListExperimentVariation2CSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GooglePlayStorePaymentsEnabled => (bool)this["GooglePlayStorePaymentsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseWebSessionCookie => (bool)this["UseWebSessionCookie"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewSponsoredPageTemplateEnabled => (bool)this["NewSponsoredPageTemplateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FavoriteEventsSnsAwsAccessKeyAndSecretCSV => (string)this["FavoriteEventsSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FavoriteEventsSnsTopicArn => (string)this["FavoriteEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRecaptchaV2 => (bool)this["UseRecaptchaV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForcePassOnRecaptchaServerFailure => (bool)this["ForcePassOnRecaptchaServerFailure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebSessionSnsAwsAccessKeyAndSecretCSV => (string)this["WebSessionSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebSessionSnsTopicArn => (string)this["WebSessionSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishWebSessionEventsToSnsEnabled => (bool)this["PublishWebSessionEventsToSnsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BadgeAwardEventsSnsAwsAccessKeyAndSecretCSV => (string)this["BadgeAwardEventsSnsAwsAccessKeyAndSecretCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BadgeAwardEventsSnsTopicArn => (string)this["BadgeAwardEventsSnsTopicArn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublisherBadgeAwardEventsToSnsEnabled => (bool)this["PublisherBadgeAwardEventsToSnsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UseAuthCookieSentToAppLoginEndpoint => (bool)this["UseAuthCookieSentToAppLoginEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("o,b,l,x")]
	public string CookieConstraint_AllowedButtonValuesCSV => (string)this["CookieConstraint_AllowedButtonValuesCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AlwayReturnFinalAsTrueHeadshotThumbnailJsonEndpoint => (bool)this["AlwayReturnFinalAsTrueHeadshotThumbnailJsonEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DoesChromeVersionDetectionExcludeEdge => (bool)this["DoesChromeVersionDetectionExcludeEdge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGooglePlayPromotionEnabled => (bool)this["IsGooglePlayPromotionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MinifyAngularTemplates => (bool)this["MinifyAngularTemplates"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MergeAngularTemplates => (bool)this["MergeAngularTemplates"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PushAngularTemplatesToCdn => (bool)this["PushAngularTemplatesToCdn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldDeprecateMobileApiLoginEndpoint => (bool)this["ShouldDeprecateMobileApiLoginEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AddNewpasswordForSocialSignOnUserEnabled => (bool)this["AddNewpasswordForSocialSignOnUserEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("carrot6984cakeneim3k6gb3")]
	public string CookieConstraintCookieName => (string)this["CookieConstraintCookieName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsCookieConstraintEnabled => (bool)this["IsCookieConstraintEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Service Undergoing Maintenance")]
	public string CookieConstraintMessage => (string)this["CookieConstraintMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public double ItunesAppRatingDefault => (double)this["ItunesAppRatingDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("140000")]
	public long ItunesAppRatingCountDefault => (long)this["ItunesAppRatingCountDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("23:00:00")]
	public TimeSpan ItunesAppRatingValidResultCacheExpiration => (TimeSpan)this["ItunesAppRatingValidResultCacheExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan ItunesAppRatingInvalidResultCacheExpiration => (TimeSpan)this["ItunesAppRatingInvalidResultCacheExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://itunes.apple.com/lookup?id=431946152")]
	public string ItunesAppRatingApiEndpoint => (string)this["ItunesAppRatingApiEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRunningGamesForKeywordSearch => (bool)this["UseRunningGamesForKeywordSearch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int AssetThumbnailMultigetMaxCount => (int)this["AssetThumbnailMultigetMaxCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleInvisibleRecaptchaSignupEnabledForAll => (bool)this["GoogleInvisibleRecaptchaSignupEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GoogleInvisibleRecaptchaPublicKey => (string)this["GoogleInvisibleRecaptchaPublicKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GoogleInvisibleRecaptchaPrivateKey => (string)this["GoogleInvisibleRecaptchaPrivateKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("mouse")]
	public string CookieConstraintPassword => (string)this["CookieConstraintPassword"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1970-01-01")]
	public DateTime CookieConstraintPageCountDownUTCTime => (DateTime)this["CookieConstraintPageCountDownUTCTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3600000")]
	public int CookieConstraintRefreshRate => (int)this["CookieConstraintRefreshRate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("16.00:00:00")]
	public TimeSpan CookieConstraintExpiration => (TimeSpan)this["CookieConstraintExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleForWin10Enabled => (bool)this["DeviceHandleForWin10Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleForAndroidEnabled => (bool)this["DeviceHandleForAndroidEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleForIOSEnabled => (bool)this["DeviceHandleForIOSEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleApiProxyFriendFollowCheckEnabled => (bool)this["DeviceHandleApiProxyFriendFollowCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleWebCaptchaCheckEnabled => (bool)this["DeviceHandleWebCaptchaCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFavoriteEventStreamLoggingEnabled => (bool)this["IsFavoriteEventStreamLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifyingOutputCacheKeyEnabled => (bool)this["IsSimplifyingOutputCacheKeyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifyingOutputCacheKeyEnabledForAllUsers => (bool)this["IsSimplifyingOutputCacheKeyEnabledForAllUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSimplifyingOutputCacheKeyEnabledForSoothsayers => (bool)this["IsSimplifyingOutputCacheKeyEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SimplifyingOutputCacheKeyRolloutPerMillion => (int)this["SimplifyingOutputCacheKeyRolloutPerMillion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAppleBogusResponseDisabled => (bool)this["IsAppleBogusResponseDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBogusStatusProliferationDisabled => (bool)this["IsBogusStatusProliferationDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConsiderUnifiedStudioUserAgentEnabled => (bool)this["IsConsiderUnifiedStudioUserAgentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreWebsitePerEndpointMetricsEnabled => (bool)this["AreWebsitePerEndpointMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTrendingGamesEnabledForSoothsayers => (bool)this["IsTrendingGamesEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStaticFarmUsingConcurrentDictionaryForServingCss => (bool)this["IsStaticFarmUsingConcurrentDictionaryForServingCss"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CssBundleSalt => (string)this["CssBundleSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string JavascriptBundleSalt => (string)this["JavascriptBundleSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AngularTemplateBundleSalt => (string)this["AngularTemplateBundleSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJavascriptBundleVerificationEnabled => (bool)this["IsJavascriptBundleVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAllFilesBundleVerificationEnabled => (bool)this["IsAllFilesBundleVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCssBundleVerificationEnabled => (bool)this["IsCssBundleVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int DeviceHandleEventStreamLogPercent => (int)this["DeviceHandleEventStreamLogPercent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsJsBundleHasErrorDetectionEnabled => (bool)this["IsJsBundleHasErrorDetectionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBundleVerificationCdnLoggingEnabled => (bool)this["IsBundleVerificationCdnLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CookieConstraintIpBypassRangeCsv => (string)this["CookieConstraintIpBypassRangeCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUsingGameInstanceHelper => (bool)this["IsUsingGameInstanceHelper"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUsingPrivateServerHelper => (bool)this["IsUsingPrivateServerHelper"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPurchaseVipServerUsingPrivateServerHelper => (bool)this["IsPurchaseVipServerUsingPrivateServerHelper"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool RecaptchaEnabledForSignup => (bool)this["RecaptchaEnabledForSignup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool RecaptchaEnabledForLogin => (bool)this["RecaptchaEnabledForLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool RecaptchaEnabledForUserAction => (bool)this["RecaptchaEnabledForUserAction"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GetUniversesUpdateRolloutPercent => (int)this["GetUniversesUpdateRolloutPercent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SessionCookieDomainSetDomainOnDeleteEnabled => (bool)this["SessionCookieDomainSetDomainOnDeleteEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsWebAppBundleVerificationEnabled => (bool)this["IsWebAppBundleVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameServerCookieConstraintBypassEnabled => (bool)this["IsGameServerCookieConstraintBypassEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFeaturedSearchEnabled => (bool)this["IsFeaturedSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconForSoothsayerEnabled => (bool)this["IsNewRobuxIconForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewRobuxIconRolloutPercentage => (int)this["NewRobuxIconRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconForGuestEnabled => (bool)this["IsNewRobuxIconForGuestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconForAllEnabled => (bool)this["IsNewRobuxIconForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccessingRequestContextRolloutPercentage => (int)this["AccessingRequestContextRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NewRobuxIconDesktopAbTestName => (string)this["NewRobuxIconDesktopAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewRobuxIconDesktopAbTestVariation => (int)this["NewRobuxIconDesktopAbTestVariation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconEnabledForGoogle => (bool)this["IsNewRobuxIconEnabledForGoogle"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconEnabledForIOS => (bool)this["IsNewRobuxIconEnabledForIOS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconEnabledForAmazon => (bool)this["IsNewRobuxIconEnabledForAmazon"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewRobuxIconEnabledForUwp => (bool)this["IsNewRobuxIconEnabledForUwp"];

	internal Settings()
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
