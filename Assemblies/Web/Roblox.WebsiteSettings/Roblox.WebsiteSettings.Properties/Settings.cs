using System;
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
public sealed class Settings : ApplicationSettingsBase, ISettings, ICapturePersonalInfoScreenModelPopulatorSettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:3966")]
	public string ApplicationURL => (string)this["ApplicationURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int FriendLookupPageSize => (int)this["FriendLookupPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int MaxFriendLookupsForOnlineList => (int)this["MaxFriendLookupsForOnlineList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FriendsTabEnabled => (bool)this["FriendsTabEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableDecalCreation => (bool)this["EnableDecalCreation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IgnoreErrorsForKeepAlivesFolder => (bool)this["IgnoreErrorsForKeepAlivesFolder"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableNewSignupPage => (bool)this["EnableNewSignupPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://www.youtube.com/v/OBUlpvyInzg&amp;hl=en&amp;fs=1&amp;rel=0&amp;color1=0x3a3a3a&amp;color2=0x999999")]
	public string DefaultHomePageVideoUrl => (string)this["DefaultHomePageVideoUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupAdvertisingEnabled => (bool)this["GroupAdvertisingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ExtraForumAdsEnabled => (bool)this["ExtraForumAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SafariPluginIsEnabled => (bool)this["SafariPluginIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FirefoxPluginIsEnabled => (bool)this["FirefoxPluginIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int BCPrepaidPromoNoCancelTerm => (int)this["BCPrepaidPromoNoCancelTerm"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int BCPrepaidPromoValidDays => (int)this["BCPrepaidPromoValidDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsTrafficTrackingEnabled => (bool)this["GoogleAnalyticsTrafficTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UA-11419793-2")]
	public string AsyncAnalyticsAccountCode => (string)this["AsyncAnalyticsAccountCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsGoalTrackingEnabled => (bool)this["GoogleAnalyticsGoalTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FacebookLikeOff => (bool)this["FacebookLikeOff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BC6And12MonthsRecurOff => (bool)this["BC6And12MonthsRecurOff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("41324860")]
	public int LandingPageFeaturedGameID => (int)this["LandingPageFeaturedGameID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ChromePluginIsEnabled => (bool)this["ChromePluginIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WindowsSafariPluginIsEnabled => (bool)this["WindowsSafariPluginIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CreditCardExpireNagScreenEnabled => (bool)this["CreditCardExpireNagScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableTags => (bool)this["EnableTags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int MinimumNumberOfVotesForTagToAppear => (int)this["MinimumNumberOfVotesForTagToAppear"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int MaximumNumberTagsToShowOnProductPage => (int)this["MaximumNumberTagsToShowOnProductPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrimaryGroupsEnabled => (bool)this["PrimaryGroupsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("&tFr$2DDFQ")]
	public string ClientVersionConfigUpdateAccessKey => (string)this["ClientVersionConfigUpdateAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingBrowserIdentityEnabled => (bool)this["TrackingBrowserIdentityEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingKontagentEnabled => (bool)this["TrackingKontagentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("18f3bc55df5048fdae1b6957382375ef")]
	public string TrackingKontagentAPIKey => (string)this["TrackingKontagentAPIKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("test-server.kontagent.net/api/v1/")]
	public string TrackingKontagentRestUrl => (string)this["TrackingKontagentRestUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CookieStoreEnabled => (bool)this["CookieStoreEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DebounceMultipleFriendInvitationsEnabled => (bool)this["DebounceMultipleFriendInvitationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingErrorsEnabled => (bool)this["TrackingErrorsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("90")]
	public int DmpHandlerTimeoutInSeconds => (int)this["DmpHandlerTimeoutInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MacFirefoxPluginIsEnabled => (bool)this["MacFirefoxPluginIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MacChromePluginIsEnabled => (bool)this["MacChromePluginIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("18f3bc55df5048fdae1b6957382375ef")]
	public string TrackingKontagentStagingAPIKey => (string)this["TrackingKontagentStagingAPIKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingGoogleAnalyticsEnabled => (bool)this["TrackingGoogleAnalyticsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumLowRelevanceScoreForTags => (int)this["MaximumLowRelevanceScoreForTags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaximumMediumRelevanceScoreForTags => (int)this["MaximumMediumRelevanceScoreForTags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingCardRedemptionEnabled => (bool)this["TrackingCardRedemptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Dmp2")]
	public string DmpHandlerSimpleDB => (string)this["DmpHandlerSimpleDB"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14")]
	public int SuperChargeProductID1 => (int)this["SuperChargeProductID1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("16")]
	public int SuperChargeProductID2 => (int)this["SuperChargeProductID2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("18")]
	public int SuperChargeProductID3 => (int)this["SuperChargeProductID3"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TrackingKontagentStagingEvents => (string)this["TrackingKontagentStagingEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingGoogleConversionEnabled => (bool)this["TrackingGoogleConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:3966/Tracker/Conversion/GoogleConversion.aspx")]
	public string TrackingGoogleConversionSource => (string)this["TrackingGoogleConversionSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingBingConversionEnabled => (bool)this["TrackingBingConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:3966/Tracker/Conversion/BingConversion.aspx")]
	public string TrackingBingConversionSource => (string)this["TrackingBingConversionSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowMaxPlayers => (bool)this["ShowMaxPlayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TeleportsLuaGUIEnabled => (bool)this["TeleportsLuaGUIEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UA-486632-5")]
	public string Async2AnalyticsAccountCode => (string)this["Async2AnalyticsAccountCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool Roblox2GAProfilePageViewEnabled => (bool)this["Roblox2GAProfilePageViewEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool KontagentCPCNewUserEventEnabled => (bool)this["KontagentCPCNewUserEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingAd4GameConversionEnabled => (bool)this["TrackingAd4GameConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingRevenueAdsConversionEnabled => (bool)this["TrackingRevenueAdsConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EpicAdvertisingConversionEnabled => (bool)this["EpicAdvertisingConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingValueClickConversionEnabled => (bool)this["TrackingValueClickConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectBillingPagesEnabled => (bool)this["RedirectBillingPagesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool SmallHeaderModification => (bool)this["SmallHeaderModification"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int ClickTrackerDelay => (int)this["ClickTrackerDelay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClickTrackerLogEvent => (bool)this["ClickTrackerLogEvent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClickTrackerLogPageview => (bool)this["ClickTrackerLogPageview"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Click")]
	public string ClickTrackerEventCategory => (string)this["ClickTrackerEventCategory"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClickTrackerEventAction => (string)this["ClickTrackerEventAction"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClickTrackerEnabled => (bool)this["ClickTrackerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ClickTrackerGAInstance => (string)this["ClickTrackerGAInstance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int GiftCardPageExpirationDays => (int)this["GiftCardPageExpirationDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ROBLOXSetIDs => (string)this["ROBLOXSetIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MinimizeActivePlaces => (bool)this["MinimizeActivePlaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ActivePlacesDefaultMinimize => (bool)this["ActivePlacesDefaultMinimize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShutDownAllGamesEnabled => (bool)this["ShutDownAllGamesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FacebookLikeButtonOnHomePageEnabled => (bool)this["FacebookLikeButtonOnHomePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DefaultMinimizeActivePlaces => (bool)this["DefaultMinimizeActivePlaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/xdskatepark/flvplayer/swfobject.js")]
	public string TakeoverVideoJSPath => (string)this["TakeoverVideoJSPath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/xdskatepark/flvplayer/player.swf")]
	public string TakeoverVideoPlayerSWF => (string)this["TakeoverVideoPlayerSWF"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CollectibleItemSortEnabled => (bool)this["CollectibleItemSortEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int CatalogResultsPerPage => (int)this["CatalogResultsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UA-26810151-1")]
	public string Async3AnalyticsAccountCode => (string)this["Async3AnalyticsAccountCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayUserAccessLevel => (bool)this["DisplayUserAccessLevel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ABCHomePagePlayTestEnabled => (bool)this["ABCHomePagePlayTestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("41324860")]
	public int LandingPageFeaturedGameIDAB => (int)this["LandingPageFeaturedGameIDAB"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewsletterUnder13OptIn => (bool)this["NewsletterUnder13OptIn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingSeccoPixelEnabled => (bool)this["TrackingSeccoPixelEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte CapturePersonalInfoNagLevel => (byte)this["CapturePersonalInfoNagLevel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayFacebookLogin => (bool)this["DisplayFacebookLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RixtyBCEnabled => (bool)this["RixtyBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectAuthenticatedUsersToMyHome => (bool)this["RedirectAuthenticatedUsersToMyHome"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WindowsOperaPluginEnabled => (bool)this["WindowsOperaPluginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MacOperaPluginEnabled => (bool)this["MacOperaPluginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdatedBillingSearchEnabled => (bool)this["UpdatedBillingSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int BulkAccountModerationLimit => (int)this["BulkAccountModerationLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BulkAccountModerationEnabled => (bool)this["BulkAccountModerationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendEmailOnErrorCausingAbuseReports => (bool)this["SendEmailOnErrorCausingAbuseReports"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PushStaticImagesToS3 => (bool)this["PushStaticImagesToS3"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClickTrackerOnHomePage => (bool)this["ClickTrackerOnHomePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClickTrackerOnLandingSignup => (bool)this["ClickTrackerOnLandingSignup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SpecificAdsOnUserPageUserID => (int)this["SpecificAdsOnUserPageUserID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SpecificAdsOnUserPageEnabled => (bool)this["SpecificAdsOnUserPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_User_Top_728x90")]
	public string SpecificAdsOnUserPageBannerSlot => (string)this["SpecificAdsOnUserPageBannerSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_MyRoblox_Middle_300x250")]
	public string SpecificAdsOnUserPageMidSlot => (string)this["SpecificAdsOnUserPageMidSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BCPageAsyncEnabled => (bool)this["BCPageAsyncEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowUsersWhatTheyCanGetWithCredit => (bool)this["ShowUsersWhatTheyCanGetWithCredit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowOptionToAppealBans => (bool)this["ShowOptionToAppealBans"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Item_Right_160x600")]
	public string SpecificAdsOnUserPageSkyscraperSlot => (string)this["SpecificAdsOnUserPageSkyscraperSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool Over13BannerIconDisplayEnabled => (bool)this["Over13BannerIconDisplayEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LandingGamesWTRBPlaceID => (int)this["LandingGamesWTRBPlaceID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LandingGamesSFOTHPlaceID => (int)this["LandingGamesSFOTHPlaceID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClickTrackerOnLandingGames => (bool)this["ClickTrackerOnLandingGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseNewBokuProducts => (bool)this["UseNewBokuProducts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HomepageTakeoverBackgroundEnabled => (bool)this["HomepageTakeoverBackgroundEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string HomepageTakeoverBackgroundCss => (string)this["HomepageTakeoverBackgroundCss"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IframeBrowsingEnabled => (bool)this["IframeBrowsingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ModerationAuditTrail => (bool)this["ModerationAuditTrail"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowUsersToChangeBirthday => (bool)this["AllowUsersToChangeBirthday"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14")]
	public int SuperChargeProductABTestID1 => (int)this["SuperChargeProductABTestID1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("16")]
	public int SuperChargeProductABTestID2 => (int)this["SuperChargeProductABTestID2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("18")]
	public int SuperChargeProductABTestID3 => (int)this["SuperChargeProductABTestID3"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32")]
	public int MaximumYouTubeVideoUploadLengthInSeconds => (int)this["MaximumYouTubeVideoUploadLengthInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisallowNonRobloxComDomains => (bool)this["DisallowNonRobloxComDomains"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int RobuxCostToAddYouTubeVideoMediaItem => (int)this["RobuxCostToAddYouTubeVideoMediaItem"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingUnderdogConversionEnabled => (bool)this["TrackingUnderdogConversionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableIframeLogin => (bool)this["EnableIframeLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamecardPageVisibleUnAuth => (bool)this["GamecardPageVisibleUnAuth"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int AdjustUserCurrencyFloodCheckerLimit => (int)this["AdjustUserCurrencyFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AdjustUserCurrencyFloodCheckerExpiryTime => (TimeSpan)this["AdjustUserCurrencyFloodCheckerExpiryTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int MaximumRobuxGrantAllowed => (int)this["MaximumRobuxGrantAllowed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int MaximumTicketGrantAllowed => (int)this["MaximumTicketGrantAllowed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaximumCreditGrantAllowed => (int)this["MaximumCreditGrantAllowed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HomepageGutterAdsEnabled => (bool)this["HomepageGutterAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RequireSecurePwds => (bool)this["RequireSecurePwds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPageGutterAdsEnabled => (bool)this["GamesPageGutterAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewMoneyPagePercentage => (int)this["NewMoneyPagePercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewMoneyMyTransactionsPageEnabled => (bool)this["NewMoneyMyTransactionsPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewMoneySummaryPageEnabled => (bool)this["NewMoneySummaryPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewMoneyPageAdvSummaryEnabled => (bool)this["NewMoneyPageAdvSummaryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SetsShowOnProfilePage => (bool)this["SetsShowOnProfilePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DaysBetweenNags => (int)this["DaysBetweenNags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableUserAgeUpNotification => (bool)this["EnableUserAgeUpNotification"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DelayBetweenAgeUpNotification => (int)this["DelayBetweenAgeUpNotification"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableMongoEventLoggingOnSecurePage => (bool)this["EnableMongoEventLoggingOnSecurePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int SiteTouchDiffThresholdInHours => (int)this["SiteTouchDiffThresholdInHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SiteTouchUseLocalStorage => (bool)this["SiteTouchUseLocalStorage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SiteTouchEventsEnabled => (bool)this["SiteTouchEventsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int RobuxCostToAddImageMediaItem => (int)this["RobuxCostToAddImageMediaItem"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TakeoverEnabled => (bool)this["TakeoverEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://roblox.zendesk.com/entries/21153041-video-advertisment-policy")]
	public string VideoPolicyUrl => (string)this["VideoPolicyUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ServicesApiKey => (string)this["ServicesApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IncludeForum => (bool)this["IncludeForum"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RefactorErrorTracking => (bool)this["RefactorErrorTracking"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MinifyJavaScriptFiles => (bool)this["MinifyJavaScriptFiles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCdnForJavaScriptLibraries => (bool)this["UseCdnForJavaScriptLibraries"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool MergeJavaScriptFiles => (bool)this["MergeJavaScriptFiles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PushJavaScriptFilesToS3 => (bool)this["PushJavaScriptFilesToS3"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdminAssetGrantEnabled => (bool)this["AdminAssetGrantEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int FloodcheckPerHourImpersonateUser => (int)this["FloodcheckPerHourImpersonateUser"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int FloodcheckPerHourGrantAsset => (int)this["FloodcheckPerHourGrantAsset"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MyMessagesValidatePageSize => (bool)this["MyMessagesValidatePageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10,20,50,100")]
	public string MyMessagesValidPageSizes => (string)this["MyMessagesValidPageSizes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int MyMessagesMaxAllowedMovedPerRequest => (int)this["MyMessagesMaxAllowedMovedPerRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MyMessagesLimitAllowedMovedPerRequest => (bool)this["MyMessagesLimitAllowedMovedPerRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackingSeccoPixel2Enabled => (bool)this["TrackingSeccoPixel2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GamesPageGutterAdsTargetGroup => (int)this["GamesPageGutterAdsTargetGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableQTStudioAuthFix => (bool)this["EnableQTStudioAuthFix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetRecommenderOnItemPageEnabled => (bool)this["AssetRecommenderOnItemPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TwitterFollowButtonOnHomePageEnabled => (bool)this["TwitterFollowButtonOnHomePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackUserAdsBySegment => (bool)this["TrackUserAdsBySegment"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public double PercentChanceServeUserAdToBC => (double)this["PercentChanceServeUserAdToBC"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.1")]
	public double PercentChanceServeUserAd => (double)this["PercentChanceServeUserAd"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPageTakeoverBackgroundEnabled => (bool)this["GamesPageTakeoverBackgroundEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageTakeoverBackgroundCSS => (string)this["GamesPageTakeoverBackgroundCSS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShowBCOnlyGamesOnGamesPage => (bool)this["ShowBCOnlyGamesOnGamesPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGutterAdsTakeoverLink => (string)this["GamesPageGutterAdsTakeoverLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGutterAdsTakeoverSquareImg => (string)this["GamesPageGutterAdsTakeoverSquareImg"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGutterAdsTakeoverLeftImg => (string)this["GamesPageGutterAdsTakeoverLeftImg"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGutterAdsTakeoverRightImg => (string)this["GamesPageGutterAdsTakeoverRightImg"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGutterAdsTakeoverMouseover => (string)this["GamesPageGutterAdsTakeoverMouseover"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGutterAdsTakeoverTopBannerImg => (string)this["GamesPageGutterAdsTakeoverTopBannerImg"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableFeedBoughtItem => (bool)this["EnableFeedBoughtItem"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableFeedNewPlace => (bool)this["EnableFeedNewPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableStudioAdminBuild => (bool)this["EnableStudioAdminBuild"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FixChangePwdModal => (bool)this["FixChangePwdModal"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TwitterButtonOnItemPageEnabled => (bool)this["TwitterButtonOnItemPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdateBuildToEdit => (bool)this["UpdateBuildToEdit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PlayAsGuestEnabled => (bool)this["PlayAsGuestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MinifyCSS => (bool)this["MinifyCSS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MergeCSS => (bool)this["MergeCSS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SaveCSSToTemporaryStore => (bool)this["SaveCSSToTemporaryStore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ClientToolboxRedesignEnabled => (bool)this["ClientToolboxRedesignEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RecentlyInsertedAssetEnabled => (bool)this["RecentlyInsertedAssetEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int RecentlyInsertedAssetPageSize => (int)this["RecentlyInsertedAssetPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RobloxStudioExtensionForBreakpad => (bool)this["RobloxStudioExtensionForBreakpad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int NewCatalogResultsPerPage => (int)this["NewCatalogResultsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MonitorJavaScriptAndCssFileChanges => (bool)this["MonitorJavaScriptAndCssFileChanges"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowOnlineFriendCountOnChatTab => (bool)this["ShowOnlineFriendCountOnChatTab"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamePassesEnabled => (bool)this["GamePassesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowPrivateSalesPrice => (bool)this["ShowPrivateSalesPrice"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseIDsRatherThanBitOrdinalsForCatalogSolrFilters => (bool)this["UseIDsRatherThanBitOrdinalsForCatalogSolrFilters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FixIOSMistakenForMac => (bool)this["FixIOSMistakenForMac"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("45000")]
	public int CookieStoreIdleIntervalMs => (int)this["CookieStoreIdleIntervalMs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ProductPromotionsOnPlacePageEnabled => (bool)this["ProductPromotionsOnPlacePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int ProductPromotionsPerPlaceMax => (int)this["ProductPromotionsPerPlaceMax"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("#")]
	public string Drop105BlogPost => (string)this["Drop105BlogPost"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPageNewMenuLayoutEnabled => (bool)this["GamesPageNewMenuLayoutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("setup.roblox.com")]
	public string ClientInstallHost => (string)this["ClientInstallHost"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.25")]
	public double VideoRefundHandlingFee => (double)this["VideoRefundHandlingFee"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ModelInsertCountFloodcheckEnabled => (bool)this["ModelInsertCountFloodcheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowVideoRefund => (bool)this["ShowVideoRefund"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowDoublePurchaseConfirmation => (bool)this["ShowDoublePurchaseConfirmation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowArchiveTabRemovalBanner => (bool)this["ShowArchiveTabRemovalBanner"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public int FloodCheckPerHourVideoRefund => (int)this["FloodCheckPerHourVideoRefund"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdBuyConfirmationEnabled => (bool)this["AdBuyConfirmationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iPadOnlyCatalogItemsEnabled => (bool)this["iPadOnlyCatalogItemsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowBuildTransitionBannerOnMyPlaces => (bool)this["ShowBuildTransitionBannerOnMyPlaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableInAppPurchases => (bool)this["EnableInAppPurchases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableRobuxInAppPurchase => (bool)this["EnableRobuxInAppPurchase"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long WalmartPromoAssetID => (long)this["WalmartPromoAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IPadOnlyItemsOnAllBrowsers => (bool)this["IPadOnlyItemsOnAllBrowsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPageOPAPushdownEnabled => (bool)this["GamesPageOPAPushdownEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPageOPAAgeTargetingEnabled => (bool)this["GamesPageOPAAgeTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackPlaceUploadsUsingEphemeralCounter => (bool)this["TrackPlaceUploadsUsingEphemeralCounter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GPTTagsEnabled => (bool)this["GPTTagsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iQUTrackingEnabled => (bool)this["iQUTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:57991")]
	public string SiteURLBase => (string)this["SiteURLBase"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackModelUploadsUsingEphemeralCounter => (bool)this["TrackModelUploadsUsingEphemeralCounter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ModelInsertCountFloodcheckLimit => (int)this["ModelInsertCountFloodcheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ModelInsertCountFloodcheckExpiry => (TimeSpan)this["ModelInsertCountFloodcheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int ECPMRecommendationResultsMultiplier => (int)this["ECPMRecommendationResultsMultiplier"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FenixTrackingEnabled => (bool)this["FenixTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShizmooCacheBusterEnabled => (bool)this["ShizmooCacheBusterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CatalogGutterAdsEnabled => (bool)this["CatalogGutterAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MyHomeGutterAdsEnabled => (bool)this["MyHomeGutterAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iPad1And3MonthBCEnabled => (bool)this["iPad1And3MonthBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FixWildCardSearchWithCapitalLetter => (bool)this["FixWildCardSearchWithCapitalLetter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EditButtonOpensStudioOnWindowsEnabled => (bool)this["EditButtonOpensStudioOnWindowsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EditButtonOpensStudioOnMacEnabled => (bool)this["EditButtonOpensStudioOnMacEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameLaunchLocationTrackingEnabled => (bool)this["GameLaunchLocationTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserCheckControllerEnabled => (bool)this["UserCheckControllerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdRollReTrackingPixelEnabled => (bool)this["AdRollReTrackingPixelEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool YellowHammerRetrackingEnabled => (bool)this["YellowHammerRetrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GPTGutterTargetingEnabled => (bool)this["GPTGutterTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowJPEGForImageInModeration => (bool)this["ShowJPEGForImageInModeration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BokuInternationalProductsEnabled => (bool)this["BokuInternationalProductsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CountrySettingsEnabled => (bool)this["CountrySettingsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SponsoredPageUseItemsTable => (bool)this["SponsoredPageUseItemsTable"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public DateTime ShowBCOnlyGamesUserCutoff => (DateTime)this["ShowBCOnlyGamesUserCutoff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IPadFollowEnabled => (bool)this["IPadFollowEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14")]
	public int ShowBCNagScreenDaysBeforeExpiration => (int)this["ShowBCNagScreenDaysBeforeExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("31")]
	public int ShowBCNagScreenDaysAfterExpiration => (int)this["ShowBCNagScreenDaysAfterExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CatalogSplashPageWithBoostedItemsForDevelopers => (bool)this["CatalogSplashPageWithBoostedItemsForDevelopers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CatalogSaleEnabled => (bool)this["CatalogSaleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CatalogSaleItemsCSV => (string)this["CatalogSaleItemsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewStudioPublishFlowEnabled => (bool)this["NewStudioPublishFlowEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewStudioLoginEnabled => (bool)this["NewStudioLoginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FacebookExpiredTokenScreenEnabled => (bool)this["FacebookExpiredTokenScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.3")]
	public float DefaultAffiliatePercentageFee => (float)this["DefaultAffiliatePercentageFee"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BigPlayNowMVC => (bool)this["BigPlayNowMVC"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GranularAgeTargetingEnabled => (bool)this["GranularAgeTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioCopyLinkOnAddonsPageEnabled => (bool)this["StudioCopyLinkOnAddonsPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeferRunningGamesListLoad => (bool)this["DeferRunningGamesListLoad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long RobloLogoEggAssetID => (long)this["RobloLogoEggAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string StudioEggAssetIDsCSV => (string)this["StudioEggAssetIDsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long AdvertEggAssetID => (long)this["AdvertEggAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EasterEggHuntEnabled => (bool)this["EasterEggHuntEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("110132408")]
	public long EasterEggGameID => (long)this["EasterEggGameID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double PercentChanceServeInHouseAdToBC => (double)this["PercentChanceServeInHouseAdToBC"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50000")]
	public int MaxPrivateMessageLength => (int)this["MaxPrivateMessageLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SpecificAdsOnUserPage2UserID => (int)this["SpecificAdsOnUserPage2UserID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SpecificAdsOnUserPage2Enabled => (bool)this["SpecificAdsOnUserPage2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_User_Top_728x90")]
	public string SpecificAdsOnUserPage2BannerSlot => (string)this["SpecificAdsOnUserPage2BannerSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_MyRoblox_Middle_300x250")]
	public string SpecificAdsOnUserPage2MidSlot => (string)this["SpecificAdsOnUserPage2MidSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Item_Right_160x600")]
	public string SpecificAdsOnUserPage2SkyscraperSlot => (string)this["SpecificAdsOnUserPage2SkyscraperSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BCExpirationModalPeriodicNagEnabled => (bool)this["BCExpirationModalPeriodicNagEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public int BCExpirationModalDaysBetweenNagsBeforeExpiration => (int)this["BCExpirationModalDaysBetweenNagsBeforeExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7,31")]
	public string BCExpirationModalNagDaysAfterExpiration => (string)this["BCExpirationModalNagDaysAfterExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogOldUserCheckEnabled => (bool)this["LogOldUserCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableTwoFactorAuthOnWebsite => (bool)this["EnableTwoFactorAuthOnWebsite"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PermissionsServiceEnabled => (bool)this["PermissionsServiceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PermissionsServiceABOverrideEnabled => (bool)this["PermissionsServiceABOverrideEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PingPresenceFromChat => (bool)this["PingPresenceFromChat"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioPublishedProjectsGearMenuEnabled => (bool)this["StudioPublishedProjectsGearMenuEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2013-04-16")]
	public DateTime BCExpirationModalNagStartDate => (DateTime)this["BCExpirationModalNagStartDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PermissionsServiceEndpoint => (string)this["PermissionsServiceEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public DateTime CommentVerifiedEmailABCutoff => (DateTime)this["CommentVerifiedEmailABCutoff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignOutFromAllSessionEnabled => (bool)this["SignOutFromAllSessionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SignOutFromAllSessionForPrivilegedUsers => (bool)this["SignOutFromAllSessionForPrivilegedUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("localhost")]
	public string GPTEnvironmentAttribute => (string)this["GPTEnvironmentAttribute"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseStudioNewModelPublishFlow => (bool)this["UseStudioNewModelPublishFlow"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdGameGenreTargetingEnabled => (bool)this["AdGameGenreTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CatalogEmptySearchEnabled => (bool)this["CatalogEmptySearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MACBanUsersModuleEnabled => (bool)this["MACBanUsersModuleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iPad1And3MonthTBCEnabled => (bool)this["iPad1And3MonthTBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool iPad1And3MonthOBCEnabled => (bool)this["iPad1And3MonthOBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioVersionHistoryOnConfigurePageEnabled => (bool)this["StudioVersionHistoryOnConfigurePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DataDrivenTrackingPixelsEnabled => (bool)this["DataDrivenTrackingPixelsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AutomaticAgeUpEnabled => (bool)this["AutomaticAgeUpEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BCOnlyCheckboxEnabled => (bool)this["BCOnlyCheckboxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseNewUploadController => (bool)this["UseNewUploadController"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte VerifiedEmailToCommentPercentage => (byte)this["VerifiedEmailToCommentPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int AssetScrubWarningThreshold => (int)this["AssetScrubWarningThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UnifyStudioCreatePages => (bool)this["UnifyStudioCreatePages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetMediaCleanup => (bool)this["AssetMediaCleanup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerifiedEmailToPost => (bool)this["VerifiedEmailToPost"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LimitCCPurchaseByIP => (bool)this["LimitCCPurchaseByIP"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SearchUserWidgetMaxSize => (int)this["SearchUserWidgetMaxSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ElasticsearchEndpoint => (string)this["ElasticsearchEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseNewUploadControllerForElevatedAccounts => (bool)this["UseNewUploadControllerForElevatedAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PayToPlayPlacesEnabled => (bool)this["PayToPlayPlacesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int PayToPlayRequiredAccountAgeDays => (int)this["PayToPlayRequiredAccountAgeDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int MaxFilteredPurchasedGames => (int)this["MaxFilteredPurchasedGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public byte MinBCRequirementToSellPlaces => (byte)this["MinBCRequirementToSellPlaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PermissionsServiceForAppsPlaceAccessEnabled => (bool)this["PermissionsServiceForAppsPlaceAccessEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public long PlaceInviteOnlyUserLimit => (long)this["PlaceInviteOnlyUserLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int CommentsMaxNewlineLimit => (int)this["CommentsMaxNewlineLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int CommentsMaxCharacterLimit => (int)this["CommentsMaxCharacterLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPage970BannerAdEnabled => (bool)this["GamesPage970BannerAdEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerifiedEmailToMessage => (bool)this["VerifiedEmailToMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaidGamesInMembershipGrid => (bool)this["PaidGamesInMembershipGrid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReduceGameLuaHandlerHits => (bool)this["ReduceGameLuaHandlerHits"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CashOutEnabled => (bool)this["CashOutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50000,100000,250000,500000")]
	public string CashOutRobuxValues => (string)this["CashOutRobuxValues"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommentUrlFilterIsEnabled => (bool)this["CommentUrlFilterIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BuildPageMVCEnabled => (bool)this["BuildPageMVCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UnifyStudioConfigurePage => (bool)this["UnifyStudioConfigurePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommentsDisplayOwnershipIcon => (bool)this["CommentsDisplayOwnershipIcon"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VotingDisabledAssets => (string)this["VotingDisabledAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GiftCardRedemptionEnabled => (bool)this["GiftCardRedemptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseGameCardMerchantDisplays => (bool)this["UseGameCardMerchantDisplays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommentsNoFloodcheckForCreator => (bool)this["CommentsNoFloodcheckForCreator"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReturnNullForCurrentUserInStudio => (bool)this["ReturnNullForCurrentUserInStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SuccessfulGameJoinGameCounterEnabled => (bool)this["SuccessfulGameJoinGameCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PreventMacAddressCSRFEnabled => (bool)this["PreventMacAddressCSRFEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommentsDisplayOwnershipIcon1 => (bool)this["CommentsDisplayOwnershipIcon1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int ScriptSignatureFormatVersion => (int)this["ScriptSignatureFormatVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PreventMacAddressCSRFEnabled1 => (bool)this["PreventMacAddressCSRFEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("roblox.com")]
	public string AllowedDomainsList => (string)this["AllowedDomainsList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectUnder13sToSubDomainEnabled => (bool)this["RedirectUnder13sToSubDomainEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedirectUnder13sToSubDomainUrl => (string)this["RedirectUnder13sToSubDomainUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WorkshopFirstOnGameSortEnabled => (bool)this["WorkshopFirstOnGameSortEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long WorkshopAssetID => (long)this["WorkshopAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MessageSentTabEnabled => (bool)this["MessageSentTabEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CookieConstraint_DomainSuffix => (string)this["CookieConstraint_DomainSuffix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int MaxAudioSizeInSeconds => (int)this["MaxAudioSizeInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4096")]
	public int MaxAudioSizeInKb => (int)this["MaxAudioSizeInKb"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php/How_to_upload_audio")]
	public string AudioWikiUrl => (string)this["AudioWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue(".aspx")]
	public string CookieConstraint_ProtectedPageExtension => (string)this["CookieConstraint_ProtectedPageExtension"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/Login/FulfillConstraint.aspx")]
	public string CookieConstraint_RedirectURL => (string)this["CookieConstraint_RedirectURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ChangeUsernameEnabled => (bool)this["ChangeUsernameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeveloperExchangePageEnabled => (bool)this["DeveloperExchangePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BuildPageStudioWidgetEnabled => (bool)this["BuildPageStudioWidgetEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MessagesNotificationRebrandEnabled => (bool)this["MessagesNotificationRebrandEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PluginCatalogSearchEnabled => (bool)this["PluginCatalogSearchEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ChangeProductPriceFloodCheckerEnabled => (bool)this["ChangeProductPriceFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StorePlayerIpAddressBeforeJoiningPlaces => (bool)this["StorePlayerIpAddressBeforeJoiningPlaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RobloxAdjustmentInSummaryEnabled => (bool)this["RobloxAdjustmentInSummaryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeveloperProductsEnabled => (bool)this["DeveloperProductsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long DeveloperProductsShopID => (long)this["DeveloperProductsShopID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long DeveloperProductsPlaceID => (long)this["DeveloperProductsPlaceID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsSetDomainNameEnabled => (bool)this["GoogleAnalyticsSetDomainNameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("roblox.com")]
	public string GoogleAnalyticsDomainName => (string)this["GoogleAnalyticsDomainName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdateSingularityUniverseOnPlaceUpdate => (bool)this["UpdateSingularityUniverseOnPlaceUpdate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishPluginsEnabled => (bool)this["PublishPluginsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DefaultWeeklyRatings => (bool)this["DefaultWeeklyRatings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdateSingularityUniverseOnPlaceUpdate1 => (bool)this["UpdateSingularityUniverseOnPlaceUpdate1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int CommentFloodCheckLimit => (int)this["CommentFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan CommentFloodCheckExpiry => (TimeSpan)this["CommentFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int MinRobuxBidOnUserAd => (int)this["MinRobuxBidOnUserAd"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PurchaseUserAdsWithRobuxEnabled => (bool)this["PurchaseUserAdsWithRobuxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SetPlaceIDInVisitScript => (bool)this["SetPlaceIDInVisitScript"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SetPlaceIDInPlaySoloScript => (bool)this["SetPlaceIDInPlaySoloScript"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCorpSiteForParentsLinks => (bool)this["UseCorpSiteForParentsLinks"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ToolboxSortByRatingsEnabled => (bool)this["ToolboxSortByRatingsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowAppBannerInIOSSafari => (bool)this["ShowAppBannerInIOSSafari"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~/images/Landing/rectangle_image_ABCDTest.jpg")]
	public string DefaultLandingPageImagePath => (string)this["DefaultLandingPageImagePath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchAppFromiOSBrowserEnabled => (bool)this["LaunchAppFromiOSBrowserEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RubiconJavascriptEnabled => (bool)this["RubiconJavascriptEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeveloperProductsForExperimentalUsersEnabled => (bool)this["DeveloperProductsForExperimentalUsersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeveloperProductsForElevatedAccountsEnabled => (bool)this["DeveloperProductsForElevatedAccountsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrivateGameInstancesEnabled => (bool)this["PrivateGameInstancesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrivateGameInstancesEnabledForElevatedAccounts => (bool)this["PrivateGameInstancesEnabledForElevatedAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PrivateGameInstanceEnabledPlaceIdsCSV => (string)this["PrivateGameInstanceEnabledPlaceIdsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public double AudioDurationBufferInSeconds => (double)this["AudioDurationBufferInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserAnimationsEnabled => (bool)this["UserAnimationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishAnimationsEnabled => (bool)this["PublishAnimationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PluginAssetUploadEnabled => (bool)this["PluginAssetUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DeveloperProductsHelpUrl => (string)this["DeveloperProductsHelpUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CreationContextReadEnabled => (bool)this["CreationContextReadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RobuxCostForAnimationUpload => (int)this["RobuxCostForAnimationUpload"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ABFramework2014Enabled => (bool)this["ABFramework2014Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public string WorsenPerformanceDelayAmountMilliseconds => (string)this["WorsenPerformanceDelayAmountMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public double WorsenPerformanceWindowHours => (double)this["WorsenPerformanceWindowHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageFeaturedGamesIDs => (string)this["GamesPageFeaturedGamesIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageFeaturedGamesDescriptions => (string)this["GamesPageFeaturedGamesDescriptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long GamesPageFeaturedGamesSessionDurationInSeconds => (long)this["GamesPageFeaturedGamesSessionDurationInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RestrictSavePlaceToUniverseCreation => (bool)this["RestrictSavePlaceToUniverseCreation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int EmailEntryPromptDisplayDelayInMs => (int)this["EmailEntryPromptDisplayDelayInMs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ABBetterStartingAvatarGirlAssets1 => (string)this["ABBetterStartingAvatarGirlAssets1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ABBetterStartingAvatarBoyAssets1 => (string)this["ABBetterStartingAvatarBoyAssets1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ABBetterStartingAvatarGirlAssets2 => (string)this["ABBetterStartingAvatarGirlAssets2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ABBetterStartingAvatarBoyAssets2 => (string)this["ABBetterStartingAvatarBoyAssets2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~/images/Landing/Landing-Page-Test-Avatar-01.jpg")]
	public string LandingPageStaticContentTestImage1Link => (string)this["LandingPageStaticContentTestImage1Link"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~/images/Landing/Landing-Page-Test-Avatar-02.jpg")]
	public string LandingPageStaticContentTestImage2Link => (string)this["LandingPageStaticContentTestImage2Link"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~/images/Landing/Landing-Page-Test-image-02.jpg")]
	public string LandingPageStaticContentTestImage3Link => (string)this["LandingPageStaticContentTestImage3Link"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("~/images/Landing/Landing-Page-Test-image-03.jpg")]
	public string LandingPageStaticContentTestImage4Link => (string)this["LandingPageStaticContentTestImage4Link"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Join 50 million other players|Build your own games for iPad, PC and Mac|Create and customize your own avatar")]
	public string LandingPageStaticContentTestText1 => (string)this["LandingPageStaticContentTestText1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX is completely free|Play millions of games|Join 50 million other players")]
	public string LandingPageStaticContentTestText2 => (string)this["LandingPageStaticContentTestText2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://www.youtube.com/v/OBUlpvyInzg&amp;hl=en&amp;fs=1&amp;rel=0&amp;color1=0x3a3a3a&amp;color2=0x999999")]
	public string ABTestNewVideoUrl => (string)this["ABTestNewVideoUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SponsoredPagesForCountryEnabled => (bool)this["SponsoredPagesForCountryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IPToCountryLookupPercentage => (int)this["IPToCountryLookupPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Murder Mystery|ROBLOXBattle|Natural Disaster Survival")]
	public string GamesPageFeaturedGamesNames => (string)this["GamesPageFeaturedGamesNames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/images/GamesPage/murder_mystery_420x236.jpg|/images/GamesPage/roblox_battle_420x236.jpg|/images/GamesPage/natural_disaster_survival_320x180.png")]
	public string GamesPageFeaturedGamesImageURLs => (string)this["GamesPageFeaturedGamesImageURLs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FloorAdOnHomePageEnabled => (bool)this["FloorAdOnHomePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InstanceReportsEnabled => (bool)this["InstanceReportsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.Billing.CanadaPricePoints")]
	public string CanadaPricePointsABTestName => (string)this["CanadaPricePointsABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan ClientPresencePingInterval => (TimeSpan)this["ClientPresencePingInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/entries/22631829")]
	public string PrivacyModeHelpUrl => (string)this["PrivacyModeHelpUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SponsoredPagesGuestIPLookupEnabled => (bool)this["SponsoredPagesGuestIPLookupEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Dummy.NewUsers.GamesPage.MixedTest1")]
	public string DummyABTestGamesPageAuthenticatedAndUnauthenticatedUsersTest1Name => (string)this["DummyABTestGamesPageAuthenticatedAndUnauthenticatedUsersTest1Name"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Dummy.NewUsers.GamesPage.AuthOnlyTest1")]
	public string DummyABTestGamesPageAuthenticatedUsersOnlyTest1Name => (string)this["DummyABTestGamesPageAuthenticatedUsersOnlyTest1Name"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Dummy.NewUsers.DevelopPage.Test1")]
	public string DummyABTestDevelopPageTest1Name => (string)this["DummyABTestDevelopPageTest1Name"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RecurrByDefaultOn6And12MonthBC => (bool)this["RecurrByDefaultOn6And12MonthBC"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool JavascriptSuppressConsoleError => (bool)this["JavascriptSuppressConsoleError"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("{}")]
	public string InstallerCdnsAndPercentagesJson => (string)this["InstallerCdnsAndPercentagesJson"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UTPAssetUpdateProtectionEnabled => (bool)this["UTPAssetUpdateProtectionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetBasedAdTargetingEnabled => (bool)this["AssetBasedAdTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool HomePageTakeoverAd970Enabled => (bool)this["HomePageTakeoverAd970Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("SignUp.BetterStartingAvatar2")]
	public string BetterStartingAvatarABTestName => (string)this["BetterStartingAvatarABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.GamesPage.ReplaceWithFeaturedGames2")]
	public string FeaturedGamesPageABTestName => (string)this["FeaturedGamesPageABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.GamesPage.WorsenPerformance2")]
	public string WorsenGamesPagePerformanceABTestName => (string)this["WorsenGamesPagePerformanceABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.Signup.EmailExperiments2")]
	public string EmailExperimentsABTestName => (string)this["EmailExperimentsABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.LandingPageStaticContentTest2")]
	public string LandingPageStaticContentABTestName => (string)this["LandingPageStaticContentABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.RequireSignUpEmail2")]
	public string RequireSignUpEmailABTestName => (string)this["RequireSignUpEmailABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsCollectSpeedHundredPercent => (bool)this["GoogleAnalyticsCollectSpeedHundredPercent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsDisableRoblox2 => (bool)this["GoogleAnalyticsDisableRoblox2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsReplaceUrchinWithGAJS => (bool)this["GoogleAnalyticsReplaceUrchinWithGAJS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PointsDisplayEnabled => (bool)this["PointsDisplayEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://localhost:9000/")]
	public string PointsElasticSearchEndpoint => (string)this["PointsElasticSearchEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LeaderboardsEnabled => (bool)this["LeaderboardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BlockXmlCommentsInAssetUploads => (bool)this["BlockXmlCommentsInAssetUploads"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LeaderboardsEnabledForSoothsayers => (bool)this["LeaderboardsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LeaderboardsLastWeekLastMonthEnabled => (bool)this["LeaderboardsLastWeekLastMonthEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LeaderboardsLastWeekLastMonthEnabledForSoothsayers => (bool)this["LeaderboardsLastWeekLastMonthEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowProcessingOfPremiumFeaturesLinkedToGiftCards => (bool)this["AllowProcessingOfPremiumFeaturesLinkedToGiftCards"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.AccountsPage.MVCAccountPage")]
	public string AccountPageMVCPageABTestName => (string)this["AccountPageMVCPageABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.LandingPage.WomAttribution")]
	public string WOMAttributionLandingPageABTestName => (string)this["WOMAttributionLandingPageABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ImpressionsRolloutPercentage => (int)this["ImpressionsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.LandingPage.WomAttribution")]
	public string WOMAttributionLandingPageABTestName1 => (string)this["WOMAttributionLandingPageABTestName1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Sorry, this transaction could not be completed due to its high value.")]
	public string FraudDetectorUserFacingErrorMessage => (string)this["FraudDetectorUserFacingErrorMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PerGameLeaderboardsEnabled => (bool)this["PerGameLeaderboardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PerGameLeaderboardsEnabledForSoothsayers => (bool)this["PerGameLeaderboardsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PerGameLeaderboardsPercentageRollout => (int)this["PerGameLeaderboardsPercentageRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TrackClientSideInsertsInEphemeralCountersPercentage => (int)this["TrackClientSideInsertsInEphemeralCountersPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int LeaderboardsPageSize => (int)this["LeaderboardsPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("40")]
	public int LeaderboardsMyRankPageSize => (int)this["LeaderboardsMyRankPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesPageDefaultTopPaidToWeekly => (bool)this["GamesPageDefaultTopPaidToWeekly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.LandingPage.Animated2014")]
	public string Animated2014LandingPageABTestName => (string)this["Animated2014LandingPageABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("//www.roblox.com")]
	public string BloxconRedirectURL => (string)this["BloxconRedirectURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OwnersCanShutDownGamesEnabled => (bool)this["OwnersCanShutDownGamesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool FriendCreationEnabled => (bool)this["FriendCreationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseNewPlatformGameSort => (bool)this["UseNewPlatformGameSort"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.ShowDebitCardAsAPaymentMethod")]
	public string ABTestNameShowDebitCardAsAPaymentMethod => (string)this["ABTestNameShowDebitCardAsAPaymentMethod"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PreventCharacterBodyColorsFromCachingPermanentlyEnabled => (bool)this["PreventCharacterBodyColorsFromCachingPermanentlyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseNewPlatformGameSortForAllUsers => (bool)this["UseNewPlatformGameSortForAllUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TieProductsWithGamesInsteadOfPlaces => (bool)this["TieProductsWithGamesInsteadOfPlaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("240")]
	public int SessionCookieExpiresMins => (int)this["SessionCookieExpiresMins"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SessionCookiesEnabled => (bool)this["SessionCookiesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RbxSession")]
	public string SessionCookieName => (string)this["SessionCookieName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InHouseContentFilterEnabledForSoothsayers => (bool)this["InHouseContentFilterEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ExistingUsers.CatalogPage.Ecpm")]
	public string CatalogEcpmAbTestName => (string)this["CatalogEcpmAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CurrentPluginVersion => (string)this["CurrentPluginVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AdBasedAssetGrantingSettings => (string)this["AdBasedAssetGrantingSettings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AdBasedAssetGrantingEnabledForSoothsayersOnly => (bool)this["AdBasedAssetGrantingEnabledForSoothsayersOnly"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ThreeDeeThumbsEnabled => (bool)this["ThreeDeeThumbsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ThreeDeeThumbsResetEnabledEveryPage => (bool)this["ThreeDeeThumbsResetEnabledEveryPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CloseAllModerationReportsOptionDisabled => (bool)this["CloseAllModerationReportsOptionDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int BetaTesterMaxPlayers => (int)this["BetaTesterMaxPlayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewGroupsPageEnabled => (bool)this["NewGroupsPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Building,Military,Roleplaying,Fan")]
	public string SuggestedGroupCategories => (string)this["SuggestedGroupCategories"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesSortPopularByDeviceEnabled => (bool)this["GamesSortPopularByDeviceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesSortPopularByDeviceEnabledForSoothsayers => (bool)this["GamesSortPopularByDeviceEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishSolidModelsEnabled => (bool)this["PublishSolidModelsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewPlacePageThumbnailSizeRolloutPercentage => (int)this["NewPlacePageThumbnailSizeRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesSortTopEarningByDeviceEnabled => (bool)this["GamesSortTopEarningByDeviceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GamesSortTopEarningByDeviceEnabledForSoothsayers => (bool)this["GamesSortTopEarningByDeviceEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool D1RetentionSortEnabled => (bool)this["D1RetentionSortEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int MaxPlayersPerPlace => (int)this["MaxPlayersPerPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MinPlayersPerPlace => (int)this["MinPlayersPerPlace"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForceUserAdInPlacePageForFirefox => (bool)this["ForceUserAdInPlacePageForFirefox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForceUserAdInProfilePageForFirefox => (bool)this["ForceUserAdInProfilePageForFirefox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.GamesPage.TopEarningByDevice")]
	public string GamesSortTopEarningByDeviceABTestName => (string)this["GamesSortTopEarningByDeviceABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("GC_")]
	public string GameCenterUsernamePrefix => (string)this["GameCenterUsernamePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("GP_")]
	public string GooglePlayUsernamePrefix => (string)this["GooglePlayUsernamePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("325")]
	public int AdminImageAssetReviewGridSizePixels => (int)this["AdminImageAssetReviewGridSizePixels"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DontUseCacheOnlyForChatOnlinePresenceRolloutPercentage => (int)this["DontUseCacheOnlyForChatOnlinePresenceRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeprecateAddParentEmailAsmx => (bool)this["DeprecateAddParentEmailAsmx"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WomTrafficAlwaysFloodedEnabled => (bool)this["WomTrafficAlwaysFloodedEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeveloperRevenueStatsEnabled => (bool)this["DeveloperRevenueStatsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:59:01")]
	public TimeSpan DeveloperRevenueStatsCacheExpirationTimeSpan => (TimeSpan)this["DeveloperRevenueStatsCacheExpirationTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MobileAppSecureSignupEndpointDisabled => (bool)this["MobileAppSecureSignupEndpointDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public int PageStyleNotificationsOverflowMessageLength => (int)this["PageStyleNotificationsOverflowMessageLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableDeviceConfigurationForUniverses => (bool)this["EnableDeviceConfigurationForUniverses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AsyncAnalyticsStudioAccountCode => (string)this["AsyncAnalyticsStudioAccountCode"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserBlockingChatEnabled => (bool)this["UserBlockingChatEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserBlockingMessageEnabled => (bool)this["UserBlockingMessageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserBlockingFriendEnabled => (bool)this["UserBlockingFriendEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ApplyOpenGraphMetaTags => (bool)this["ApplyOpenGraphMetaTags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VotingEnabled => (bool)this["VotingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchOnGamesPageEnabled => (bool)this["GameSearchOnGamesPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RefreshAdsInGamesPageEnabled => (bool)this["RefreshAdsInGamesPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeveloperRevenueCsvEnabled => (bool)this["DeveloperRevenueCsvEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MessagePageAngularEnabled => (bool)this["MessagePageAngularEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdBasedAssetGrantingPrerollEnabled => (bool)this["AdBasedAssetGrantingPrerollEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetAliasesEnabled => (bool)this["AssetAliasesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForceLowValueUserHomeForSoothsayers => (bool)this["ForceLowValueUserHomeForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForceLowValueUserHomeForMarketing => (bool)this["ForceLowValueUserHomeForMarketing"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioAssetCreationEnabled => (bool)this["StudioAssetCreationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForceUpgradeOldIOSAppUsers => (bool)this["ForceUpgradeOldIOSAppUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://itunes.apple.com/us/app/roblox-mobile/id431946152?mt=8")]
	public string RobloxIOSAppITunesUrl => (string)this["RobloxIOSAppITunesUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CookieConstraint_RedirectDomain => (string)this["CookieConstraint_RedirectDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioAssetCreationEnabled1 => (bool)this["StudioAssetCreationEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PassUniverseIdThroughLuaScripts => (bool)this["PassUniverseIdThroughLuaScripts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool FooterGenreLinksEnabled => (bool)this["FooterGenreLinksEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AdsInGameSearchResultsEnabled => (bool)this["AdsInGameSearchResultsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool HideSideBarAdsInGamesPage => (bool)this["HideSideBarAdsInGamesPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameTile2xFeaturedInGameSearchRolloutPercentage => (int)this["GameTile2xFeaturedInGameSearchRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameTile2xFeaturedInGameSearchForGuests => (bool)this["GameTile2xFeaturedInGameSearchForGuests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameTile2xFeaturedInGameSearchForSoothSayers => (bool)this["GameTile2xFeaturedInGameSearchForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("RBXViralAcquisition")]
	public string ViralAcquisitionCookieName => (string)this["ViralAcquisitionCookieName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("rbxp")]
	public string ViralPromoterQueryStringParameter => (string)this["ViralPromoterQueryStringParameter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFacebookPushUserGamePlayEnabled => (bool)this["IsFacebookPushUserGamePlayEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsFacebookShareAvatarEnabled => (bool)this["IsFacebookShareAvatarEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupBasedAdTargetingEnabled => (bool)this["GroupBasedAdTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PlaceBasedAdTargetingEnabled => (bool)this["PlaceBasedAdTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GenderBasedAdTargetingEnabled => (bool)this["GenderBasedAdTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PersistentLowValueUserBasedAdTargetingEnabled => (bool)this["PersistentLowValueUserBasedAdTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int MaxFriendsCount => (int)this["MaxFriendsCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGigyaShareBarEnabled => (bool)this["IsGigyaShareBarEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGigyaShareBarEnabledForHybrid => (bool)this["IsGigyaShareBarEnabledForHybrid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public int NumberOfRecommendedGames => (int)this["NumberOfRecommendedGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int CommentsPageSize => (int)this["CommentsPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int PlaceGameInstancesPageSize => (int)this["PlaceGameInstancesPageSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("15")]
	public int SlowGameFpsThreshold => (int)this["SlowGameFpsThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DefaultToolboxAssetIds => (string)this["DefaultToolboxAssetIds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LinkifyEnabled => (bool)this["LinkifyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("(https?\\:\\/\\/)?(?:www\\.)?([a-z0-9\\-]{2,}\\.)*((m|de|www|web|api|blog|wiki|help|corp|polls|bloxcon|developer)\\.roblox\\.com|robloxlabs\\.com)((\\/[A-Za-z0-9-+&@#\\/%?=~_|!:,.;]*)|(\\b|\\s))")]
	public string LinkifyRegex => (string)this["LinkifyRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("gm")]
	public string LinkifyRegexFlags => (string)this["LinkifyRegexFlags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowCreditForRenewingPurchases => (bool)this["AllowCreditForRenewingPurchases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DefaultToolboxAssetIds1 => (string)this["DefaultToolboxAssetIds1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DefaultToolboxAssetIds2 => (string)this["DefaultToolboxAssetIds2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayOrganicAcquisitionStatsToPublic => (bool)this["DisplayOrganicAcquisitionStatsToPublic"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string TakeoverEnabledPlaceIdsCSV => (string)this["TakeoverEnabledPlaceIdsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TakeoverEnabledForAllGamesDetailsPages => (bool)this["TakeoverEnabledForAllGamesDetailsPages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageEnabled => (bool)this["GameDetailPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableNewToolboxSearch => (bool)this["EnableNewToolboxSearch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReskinFooterEnabled => (bool)this["ReskinFooterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CatalogPage970BannerAdEnabled => (bool)this["CatalogPage970BannerAdEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ItemPage970BannerAdEnabled => (bool)this["ItemPage970BannerAdEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrivateServersEnabledForSoothSayers => (bool)this["PrivateServersEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PrivateServersHelpLink => (string)this["PrivateServersHelpLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RobloxTopIOSAppShowBCGamesSort => (bool)this["RobloxTopIOSAppShowBCGamesSort"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AdBasedDefaultUrlReferrer => (string)this["AdBasedDefaultUrlReferrer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("23:59:59")]
	public TimeSpan OrganicAcquisitionCounterExpiration => (TimeSpan)this["OrganicAcquisitionCounterExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchAppFromAndroidBrowserEnabled => (bool)this["LaunchAppFromAndroidBrowserEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRunningGamesForMobileGameSearch => (bool)this["UseRunningGamesForMobileGameSearch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PromoCodeRedemptionEnabled => (bool)this["PromoCodeRedemptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SignOnApiPath => (string)this["SignOnApiPath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseSignOnApiRollout => (bool)this["UseSignOnApiRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RequestTwoStepCodeUnauthenticatedPath => (string)this["RequestTwoStepCodeUnauthenticatedPath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VerifyTwoStepCodeUnauthenticatedPath => (string)this["VerifyTwoStepCodeUnauthenticatedPath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RequestTwoStepCodePath => (string)this["RequestTwoStepCodePath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VerifyTwoStepCodePath => (string)this["VerifyTwoStepCodePath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int MessagesPageMinimumAdRefreshIntervalInMilliseconds => (int)this["MessagesPageMinimumAdRefreshIntervalInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSwfPreloaderEnabled => (bool)this["IsSwfPreloaderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoginFormPostDisabled => (bool)this["IsLoginFormPostDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileAccountLogOnPostDisabled => (bool)this["IsMobileAccountLogOnPostDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameDetailPageRolloutPercentage => (int)this["GameDetailPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageEnabledForBetaTesters => (bool)this["GameDetailPageEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageEnabledForSoothSayers => (bool)this["GameDetailPageEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OldGameDetailPageBottomTabsEnabledForSoothSayers => (bool)this["OldGameDetailPageBottomTabsEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDeveloperConsoleWarningEnabled => (bool)this["IsDeveloperConsoleWarningEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OnlySetPlaceIdInEditScriptIfCanPublish => (bool)this["OnlySetPlaceIdInEditScriptIfCanPublish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLogLandingSignupExceptionEnabled => (bool)this["IsLogLandingSignupExceptionEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioSplashScreenEnabled => (bool)this["StudioSplashScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ProtocolNameForClient => (string)this["ProtocolNameForClient"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ProtocolNameForStudio => (string)this["ProtocolNameForStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOggUploadEnabled => (bool)this["IsOggUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HideInventoryForRobloxUser => (bool)this["HideInventoryForRobloxUser"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool HotfixEnabledForiOS185 => (bool)this["HotfixEnabledForiOS185"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserPageBanOriginPrefix => (string)this["UserPageBanOriginPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewPluginEventsEnabled => (bool)this["NewPluginEventsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageEnabledForGuests => (bool)this["GameDetailPageEnabledForGuests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowAllUsersToUploadLuaAssets => (bool)this["AllowAllUsersToUploadLuaAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("www.youtube.com,youtube.com,m.youtube.com")]
	public string AllowedYoutubeProfileUrlDomainsCsv => (string)this["AllowedYoutubeProfileUrlDomainsCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RecurringPrivateServersEnabled => (bool)this["RecurringPrivateServersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RecurringPrivateServersEnabledForSoothsayers => (bool)this["RecurringPrivateServersEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowPaymentsOnMyTransactionsEnabled => (bool)this["ShowPaymentsOnMyTransactionsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LandingSignupLogoutUserEnabled => (bool)this["LandingSignupLogoutUserEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxEventStreamJavaScriptEnabled => (bool)this["IsRobloxEventStreamJavaScriptEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RobloxEventStreamPixelUrl => (string)this["RobloxEventStreamPixelUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLaunchAttemptLoggingEnabled => (bool)this["IsGameLaunchAttemptLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox")]
	public string EventLogSource1 => (string)this["EventLogSource1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageHideRunningGamesLoadMore => (bool)this["GameDetailPageHideRunningGamesLoadMore"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaymentReskinPageEnabledForSoothSayers => (bool)this["PaymentReskinPageEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int GameGearViewModelMaxRowsThreshold => (int)this["GameGearViewModelMaxRowsThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreGameDetailPageRequestsRoutedThroughGameDetailReferral => (bool)this["AreGameDetailPageRequestsRoutedThroughGameDetailReferral"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EventStreamLoggingForPluginEnabled => (bool)this["EventStreamLoggingForPluginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EventStreamLoggingForProtocolEnabled => (bool)this["EventStreamLoggingForProtocolEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("75")]
	public int GamesLandingPageNumberOfGames => (int)this["GamesLandingPageNumberOfGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.LandingPage.LandingPages")]
	public string LandingPageAbTestName => (string)this["LandingPageAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MatchmakeWithFriends => (bool)this["MatchmakeWithFriends"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public int NumberOfDataPointsForPromotionAndDeveloperStatsGraphs => (int)this["NumberOfDataPointsForPromotionAndDeveloperStatsGraphs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageEnabledForPhones => (bool)this["GameDetailPageEnabledForPhones"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailPageEnableIOSExpireHeader => (bool)this["GameDetailPageEnableIOSExpireHeader"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:30")]
	public TimeSpan CharacterThumbnailInvalidationInterval => (TimeSpan)this["CharacterThumbnailInvalidationInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int CharacterThumbnailInvalidationLimit => (int)this["CharacterThumbnailInvalidationLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameIconEnabled => (bool)this["IsGameIconEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=Gallery_(Tutorial)")]
	public string GameIconWikiUrl => (string)this["GameIconWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("04/14/2015 16:47:00")]
	public DateTime GamesSearchReskinReleaseDate => (DateTime)this["GamesSearchReskinReleaseDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ValidateMobilePurchaseAlwaysReturnOK => (bool)this["ValidateMobilePurchaseAlwaysReturnOK"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCreatingShirtAndPantsEnabledForNBCInGroup => (bool)this["IsCreatingShirtAndPantsEnabledForNBCInGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HideBuildButton => (bool)this["HideBuildButton"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPageLoadEventStreamingEnabled => (bool)this["IsPageLoadEventStreamingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsServerSideThumbnailLookupInCatalogEnabled => (bool)this["IsServerSideThumbnailLookupInCatalogEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaximumNumberOfItemsPerInventoryPage => (int)this["MaximumNumberOfItemsPerInventoryPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaximumNumberOfItemRecommendationsPerPage => (int)this["MaximumNumberOfItemRecommendationsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldCatchFriendRequestPlatformExceptions => (bool)this["ShouldCatchFriendRequestPlatformExceptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsImageMagickResizeEnabled => (bool)this["IsImageMagickResizeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChatEndpoint => (string)this["ChatEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HomeSeeAllButtonEnabledForPhones => (bool)this["HomeSeeAllButtonEnabledForPhones"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int MaximumNumberOfExtraCatalogSearchRequest => (int)this["MaximumNumberOfExtraCatalogSearchRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.GameDetailsPage.SignupWall")]
	public string GameDetailsPageSignupWallAbTestName => (string)this["GameDetailsPageSignupWallAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double CedexisCdnTestRatio => (double)this["CedexisCdnTestRatio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableSignUpFormTracking => (bool)this["EnableSignUpFormTracking"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.GameDetailsPage.SignupWall")]
	public string GameDetailsPageSignupWallAbTestName1 => (string)this["GameDetailsPageSignupWallAbTestName1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseGigyaForFacebookAuthentication => (bool)this["UseGigyaForFacebookAuthentication"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ProfileReskinPageEnabledForTest => (bool)this["ProfileReskinPageEnabledForTest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForumSyncCookieUsesDomainPath => (bool)this["ForumSyncCookieUsesDomainPath"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CookieUpgraderEnabled => (bool)this["CookieUpgraderEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SaveFiltersBetweenSearchesInCatalogEnabled => (bool)this["SaveFiltersBetweenSearchesInCatalogEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGamesPageInteractionEventEnabled => (bool)this["IsGamesPageInteractionEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameSearchEventEnabled => (bool)this["IsGameSearchEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserAuthenticatedEventEnabled => (bool)this["IsUserAuthenticatedEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameDetailsInteractionEventEnabled => (bool)this["IsGameDetailsInteractionEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("NewUsers.LandingPage.LandingPagesV2")]
	public string LandingV2AbTestName => (string)this["LandingV2AbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ProtocolUrlIncludesLaunchTime => (bool)this["ProtocolUrlIncludesLaunchTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LanguageCookieSetsDomain => (bool)this["LanguageCookieSetsDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSortsProviderTakesDeviceTypeEnabled => (bool)this["GameSortsProviderTakesDeviceTypeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoginFormValidationEventEnabled => (bool)this["IsLoginFormValidationEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShowDevExForBelow13Users => (bool)this["ShowDevExForBelow13Users"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("26")]
	public int PhoneGamesBatchSize => (int)this["PhoneGamesBatchSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AllUsers.RobuxPage")]
	public string RobuxPageABTestName => (string)this["RobuxPageABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameLaunchAdRefresherEnabled => (bool)this["GameLaunchAdRefresherEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDeveloperStatsByDeviceTypeEnabled => (bool)this["IsDeveloperStatsByDeviceTypeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLiveDeveloperStatsEnabled => (bool)this["IsLiveDeveloperStatsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewThumbnailTypeForHomePageRolloutPercentage => (int)this["NewThumbnailTypeForHomePageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int FinalizePayPalPaymentLeaseDurationInMilliseconds => (int)this["FinalizePayPalPaymentLeaseDurationInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LuaWebServiceEnabled => (bool)this["LuaWebServiceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobuxPageClickEventEnabled => (bool)this["IsRobuxPageClickEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowGroupToolbox => (bool)this["ShowGroupToolbox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FriendsReskinPageRolloutPercentage => (int)this["FriendsReskinPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FriendsReskinPageEnabledForBetaTesters => (bool)this["FriendsReskinPageEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FriendsReskinPageEnabledForSoothSayers => (bool)this["FriendsReskinPageEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowConsoleDeviceTypeOnConfigurePlacePage => (bool)this["ShowConsoleDeviceTypeOnConfigurePlacePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableFriendActivityOnHomePage => (bool)this["EnableFriendActivityOnHomePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AlwaysSetUserIdOnVisit => (bool)this["AlwaysSetUserIdOnVisit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOrganicAcquisitionDurableCounterWriteEnabled => (bool)this["IsOrganicAcquisitionDurableCounterWriteEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DetectIsProtocolInstalledOnEdge => (bool)this["DetectIsProtocolInstalledOnEdge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RemoveSixMonthAndLifetimeBCEnabled => (bool)this["RemoveSixMonthAndLifetimeBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int NumberOfMembersForPartyChrome => (int)this["NumberOfMembersForPartyChrome"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PartyV2Enabled => (bool)this["PartyV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:40")]
	public TimeSpan DefaultPartyExpiration => (TimeSpan)this["DefaultPartyExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDeveloperStatsRevenuePerVisitEnabled => (bool)this["IsDeveloperStatsRevenuePerVisitEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CheckIfHashIsModeratedInAssetHandler => (bool)this["CheckIfHashIsModeratedInAssetHandler"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Computer,Tablet,Phone")]
	public string DeveloperStatsEnabledDeviceTypesCSV => (string)this["DeveloperStatsEnabledDeviceTypesCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ForcePlaceAssetRequestsToHaveAssetTypeHeader => (bool)this["ForcePlaceAssetRequestsToHaveAssetTypeHeader"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreUserProfileShowcasesEnabled => (bool)this["AreUserProfileShowcasesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CheckAssetTypeInAssetHandler => (bool)this["CheckAssetTypeInAssetHandler"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationsEndpoint => (string)this["NotificationsEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserNotificationsEnabled => (bool)this["UserNotificationsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseMobileOnlyItemOverlay => (bool)this["UseMobileOnlyItemOverlay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SubdomainFarmRedirectModuleEnabled => (bool)this["SubdomainFarmRedirectModuleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool JavascriptEndpointsEnabled => (bool)this["JavascriptEndpointsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int ChatMessageReportPagesize => (int)this["ChatMessageReportPagesize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdateCreateBadgesEnabled => (bool)this["UpdateCreateBadgesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReuploadBadgeImageEnabled => (bool)this["ReuploadBadgeImageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowConsoleDeviceTypeOnConfigurePlacePageForSoothsayers => (bool)this["ShowConsoleDeviceTypeOnConfigurePlacePageForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseBadgeAwardProcessor => (bool)this["UseBadgeAwardProcessor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int FriendshipBadgeLevel1AwardThreshold => (int)this["FriendshipBadgeLevel1AwardThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int VisitsBadgeLevel1AwardThresholdHomestead => (int)this["VisitsBadgeLevel1AwardThresholdHomestead"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int VisitsBadgeLevel2AwardBricksmith => (int)this["VisitsBadgeLevel2AwardBricksmith"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReuploadGamePassImageEnabled => (bool)this["ReuploadGamePassImageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpdateCreateGamePassesEnabled => (bool)this["UpdateCreateGamePassesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSuperChargeEnabledForCreditAndPayPal => (bool)this["IsSuperChargeEnabledForCreditAndPayPal"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double LogPrivateModuleRequiresPercentage => (double)this["LogPrivateModuleRequiresPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MaxRetryForGettingUnscrubedUserAd => (int)this["MaxRetryForGettingUnscrubedUserAd"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PreventUnauthorizedAnimationDownloads => (bool)this["PreventUnauthorizedAnimationDownloads"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreUserProfileShowcasesEnabled1 => (bool)this["AreUserProfileShowcasesEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreNativeAdsEnabledForEveryone => (bool)this["AreNativeAdsEnabledForEveryone"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RemoveSixMonthsAndLifetimeBcFromRixtyEnabled => (bool)this["RemoveSixMonthsAndLifetimeBcFromRixtyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CakeTrackingPixelURL => (string)this["CakeTrackingPixelURL"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpsellBCEnabled => (bool)this["IsUpsellBCEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChildDirectedTreatmentEnabledForGuest => (bool)this["IsChildDirectedTreatmentEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialNetworkJsHiddenForUnder13 => (bool)this["IsSocialNetworkJsHiddenForUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGigyaJsHiddenForGuests => (bool)this["IsGigyaJsHiddenForGuests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double PercentChanceServeUserAdToGuest => (double)this["PercentChanceServeUserAdToGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double PercentChanceServeUserAdToUnder13User => (double)this["PercentChanceServeUserAdToUnder13User"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SpecificAdSlotsEnabledForUserUnder13 => (bool)this["SpecificAdSlotsEnabledForUserUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Under13AdSlot160x600 => (string)this["Under13AdSlot160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Under13AdSlot728x90 => (string)this["Under13AdSlot728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Under13AdSlot300x250 => (string)this["Under13AdSlot300x250"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SpecificAdSlotsEnabledForGuest => (bool)this["SpecificAdSlotsEnabledForGuest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GuestAdSlot160x600 => (string)this["GuestAdSlot160x600"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GuestAdSlot728x90 => (string)this["GuestAdSlot728x90"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GuestAdSlot300x250 => (string)this["GuestAdSlot300x250"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowGuestJoinOnConsole => (bool)this["AllowGuestJoinOnConsole"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ChatShadowDataTestRolloutPercentage => (int)this["ChatShadowDataTestRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ChatShadowDataEnabledForSoothSayers => (bool)this["ChatShadowDataEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTopRatedSortByDeviceEnabled => (bool)this["IsTopRatedSortByDeviceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTopRatedSortByDeviceEnabledForSoothsayers => (bool)this["IsTopRatedSortByDeviceEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsTrustEImageEnabled => (bool)this["IsTrustEImageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaymentFlowFormEventsEnabled => (bool)this["PaymentFlowFormEventsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CheckUtf8FileContentForUploadEnabled => (bool)this["CheckUtf8FileContentForUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCakePixelEmbeddedOnPaymentSuccessPages => (bool)this["IsCakePixelEmbeddedOnPaymentSuccessPages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PortraitModeEnabled => (bool)this["PortraitModeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int NativeAdsPositionMedian => (int)this["NativeAdsPositionMedian"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int NativeAdsPositionVariance => (int)this["NativeAdsPositionVariance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCdnForSponsoredPageStaticContentEnabled => (bool)this["UseCdnForSponsoredPageStaticContentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SecureClientInstallHost => (string)this["SecureClientInstallHost"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TakeoverByAssetsEnabled => (bool)this["TakeoverByAssetsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsYouTubeVideoHiddenForGuests => (bool)this["IsYouTubeVideoHiddenForGuests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsYouTubeVideoHiddenForUnder13Users => (bool)this["IsYouTubeVideoHiddenForUnder13Users"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVideoThumbnailUploadDisabledForUnder13Users => (bool)this["IsVideoThumbnailUploadDisabledForUnder13Users"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("//img.youtube.com/vi/{0}/hqdefault.jpg")]
	public string YouTubeVideoThumbnailImageUrlTemplate => (string)this["YouTubeVideoThumbnailImageUrlTemplate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("//www.youtube.com/watch?v={0}")]
	public string YouTubeVideoUrlTemplate => (string)this["YouTubeVideoUrlTemplate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TakeoverByAssetsRoadblockEnabled => (bool)this["TakeoverByAssetsRoadblockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HideCorpSiteFooterLinksUnder13 => (bool)this["HideCorpSiteFooterLinksUnder13"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAnalyticsMeasurementAshxDisabled => (bool)this["IsAnalyticsMeasurementAshxDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("21600000")]
	public int MaxConnectionTimeForNotifications => (int)this["MaxConnectionTimeForNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://devforum.roblox.com/c/announcements")]
	public string DevForumAnnouncementsUrl => (string)this["DevForumAnnouncementsUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int UserPresenceMultigetLimit => (int)this["UserPresenceMultigetLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int AvatarHeadshotsMultigetLimit => (int)this["AvatarHeadshotsMultigetLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SettingsReskinPageRolloutPercentage => (int)this["SettingsReskinPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SettingsReskinPageEnabledForBetaTesters => (bool)this["SettingsReskinPageEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SettingsReskinPageEnabledForSoothSayers => (bool)this["SettingsReskinPageEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double PercentChanceRecordPageLoadPerformance => (double)this["PercentChanceRecordPageLoadPerformance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSuperSafeModeEnabledForPrivacySettings => (bool)this["IsSuperSafeModeEnabledForPrivacySettings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserNotificationsAsyncAbortEnabled => (bool)this["UserNotificationsAsyncAbortEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int IntervalOfChangeTitleForPartyChrome => (int)this["IntervalOfChangeTitleForPartyChrome"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableGameAnimationsTabForStudio => (bool)this["EnableGameAnimationsTabForStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ValidateEmailOnPurchase => (bool)this["ValidateEmailOnPurchase"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int IntervalOfChangeTitleForPartyChrome1 => (int)this["IntervalOfChangeTitleForPartyChrome1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MinimumNumberOfGamesForPersonalizedByLikedToAppear => (int)this["MinimumNumberOfGamesForPersonalizedByLikedToAppear"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AddCrossDomainOptionsToAllXhrRequests => (bool)this["AddCrossDomainOptionsToAllXhrRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool InstallLogAshxIsEnabled => (bool)this["InstallLogAshxIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EventStreamStudioPixelUrl => (string)this["EventStreamStudioPixelUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NumberOfAdSlotsInDirectAdsScanPage => (int)this["NumberOfAdSlotsInDirectAdsScanPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDirectAdsScanEnabled => (bool)this["IsDirectAdsScanEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GlobalRefreshAdsEnabled => (bool)this["GlobalRefreshAdsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GlobalRefreshAdRateInMilliseconds => (int)this["GlobalRefreshAdRateInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AjaxCatalogPageEnabled => (bool)this["AjaxCatalogPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlaceCreatePrivateServersOnByDefault => (bool)this["IsPlaceCreatePrivateServersOnByDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool PartyChromeOnDesktopEnabled => (bool)this["PartyChromeOnDesktopEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CloudEditStudioForBetaEnabled => (bool)this["CloudEditStudioForBetaEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TakeoverGamesDetailPagesByAssetIdEnabled => (bool)this["TakeoverGamesDetailPagesByAssetIdEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DefaultLandingPageView => (string)this["DefaultLandingPageView"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IframeAdInForumEnabled => (bool)this["IframeAdInForumEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GrantTicketsOnPlaceVisitEnabled => (bool)this["GrantTicketsOnPlaceVisitEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool HidePrivacyOnEmailVerificationEnabled => (bool)this["HidePrivacyOnEmailVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("never")]
	public string GigyaBypassCookiePolicy => (string)this["GigyaBypassCookiePolicy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GigyaBypassCookiePolicyConfigEnabled => (bool)this["GigyaBypassCookiePolicyConfigEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Powering Imagination<span> &#8482 </span>")]
	public string SloganRawHtml => (string)this["SloganRawHtml"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserInteractionsEventEnabled => (bool)this["IsUserInteractionsEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPageHeartbeatEventEnabled => (bool)this["IsPageHeartbeatEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2,10,30,90")]
	public string PageHeartbeatEventTimesInSeconds => (string)this["PageHeartbeatEventTimesInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTeeShirtAssetTypeInCatalogFeaturedSubcategoryEnabled => (bool)this["IsTeeShirtAssetTypeInCatalogFeaturedSubcategoryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ComScoreTrackingPixelEnabled => (bool)this["ComScoreTrackingPixelEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CleanPartyFromConversationEnabled => (bool)this["CleanPartyFromConversationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCDNForWindowsClientInstaller => (bool)this["UseCDNForWindowsClientInstaller"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCDNForStudioInstaller => (bool)this["UseCDNForStudioInstaller"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCDNForMacInstaller => (bool)this["UseCDNForMacInstaller"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StaticFarmRequestRestrictionModuleEnabled => (bool)this["StaticFarmRequestRestrictionModuleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DiscourceAvatarForceUpdateEnabled => (bool)this["DiscourceAvatarForceUpdateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsSignupOrLoginPartialUsedOnRollerCoasterLandingPages => (string)this["IsSignupOrLoginPartialUsedOnRollerCoasterLandingPages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AlwaysAllowInsertingModels => (bool)this["AlwaysAllowInsertingModels"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShouldUpgradeCorruptedEventTrackerV2Cookie => (bool)this["ShouldUpgradeCorruptedEventTrackerV2Cookie"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFacebookEnabledOnModalSignupOrLogin => (bool)this["IsFacebookEnabledOnModalSignupOrLogin"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DFPVariableATargetingEnabled => (bool)this["DFPVariableATargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DFPVariableAgeTargetingEnabled => (bool)this["DFPVariableAgeTargetingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayAdsOverHttps => (bool)this["DisplayAdsOverHttps"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MoveBootstrapCssToBaseBundleEnabled1 => (bool)this["MoveBootstrapCssToBaseBundleEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4093")]
	public int CookieSizeEventThreshold => (int)this["CookieSizeEventThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AudioUploadForGroupsEnabled => (bool)this["AudioUploadForGroupsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool VideoUploadForGroupsEnabled => (bool)this["VideoUploadForGroupsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FoldPaymentListInTransactionListEnabled => (bool)this["FoldPaymentListInTransactionListEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsContentGroupsEnabled => (bool)this["GoogleAnalyticsContentGroupsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double PingdomRumTrackingPercentChance => (double)this["PingdomRumTrackingPercentChance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PingdomRumAccountId => (string)this["PingdomRumAccountId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DetectFirstTimeVisitorOnBeginRequest => (bool)this["DetectFirstTimeVisitorOnBeginRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GoogleAnalyticsFirstTimeVisitorVariableEnabled => (bool)this["GoogleAnalyticsFirstTimeVisitorVariableEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EventStreamDiagnosticPixelUrl => (string)this["EventStreamDiagnosticPixelUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ROBLOX is powered by a growing community of over 300,000 creators who produce an infinite variety of highly immersive experiences. These experiences range from 3D multiplayer games and competitions, to interactive adventures where friends can take on new personas imagining what it would be like to be a dinosaur, a miner in a quarry or an astronaut on a space exploration.")]
	public string MetaDataLandingPageDescription => (string)this["MetaDataLandingPageDescription"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://images.rbxcdn.com/42268b6264d89827401ef912f174f288.jpg")]
	public string MetaDataLandingPageImages => (string)this["MetaDataLandingPageImages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ServiceWorkerEnabledForRegularUsers => (bool)this["ServiceWorkerEnabledForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ServiceWorkerEnabledForSoothsayers => (bool)this["ServiceWorkerEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ServiceWorkerRolloutPercentage => (int)this["ServiceWorkerRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BrowserTrackerTestAbTestName => (string)this["BrowserTrackerTestAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserTestAbTestName => (string)this["UserTestAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CheckCloudEditInLuaHandlerCanAccessEdit => (bool)this["CheckCloudEditInLuaHandlerCanAccessEdit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PlaceLauncherValidateXsrfEnabled => (bool)this["PlaceLauncherValidateXsrfEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AddXFrameOptionsHeaderToWebpageResponses => (bool)this["AddXFrameOptionsHeaderToWebpageResponses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int ImageRetryMaxTimes => (int)this["ImageRetryMaxTimes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1500")]
	public int ImageRetryTimer => (int)this["ImageRetryTimer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisableBrowserTrackerCreationFromPlaceLauncher => (bool)this["DisableBrowserTrackerCreationFromPlaceLauncher"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PushNotificationsEnabledForUnknownSubdomains => (bool)this["PushNotificationsEnabledForUnknownSubdomains"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PushNotificationsEnabledForWebSubdomain => (bool)this["PushNotificationsEnabledForWebSubdomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("49")]
	public int PushNotificationsMinimumRequiredChromeVersion => (int)this["PushNotificationsMinimumRequiredChromeVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("49")]
	public int ServiceWorkersMinimumRequiredChromeVersion => (int)this["ServiceWorkersMinimumRequiredChromeVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDeveloperRevenueAggregationChartingEnabled => (bool)this["IsDeveloperRevenueAggregationChartingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumSlicesOfPieForDeveloperRevenueAggregation => (int)this["MaximumSlicesOfPieForDeveloperRevenueAggregation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BlockSearchIndexingMetaTagsEnabled => (bool)this["BlockSearchIndexingMetaTagsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PlaceCreatorCrossPlatformPlaceAccessEnabled => (bool)this["PlaceCreatorCrossPlatformPlaceAccessEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60000")]
	public int PartyChromeDisplayTimeStampInterval => (int)this["PartyChromeDisplayTimeStampInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsLoginAwardVisible => (bool)this["IsLoginAwardVisible"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/catalog/browse.aspx?Subcategory=3&CurrencyType=4&pxMin=1&pxMax=10&SortType=0&SortAggregation=3&SortCurrency=1&LegendExpanded=true&Category=3")]
	public string CatalogLinkOnHomeFeed => (string)this["CatalogLinkOnHomeFeed"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreTicketsHiddenOnDeveloperStats => (bool)this["AreTicketsHiddenOnDeveloperStats"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal SendCookieSizeToEventStreamPercentage => (decimal)this["SendCookieSizeToEventStreamPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public decimal SendCookieSizeToPerfmonPercentage => (decimal)this["SendCookieSizeToPerfmonPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MoveCloudEditChecksToViewModel => (bool)this["MoveCloudEditChecksToViewModel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string NotificationsSiteEndpoint => (string)this["NotificationsSiteEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisableFavoritesSectionOnProfilePage => (bool)this["DisableFavoritesSectionOnProfilePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CheckMatchmakingContextBeforeShowingJoinOnProfileEnabled => (bool)this["CheckMatchmakingContextBeforeShowingJoinOnProfileEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushPromptOnFriendRequestSentEnabledForSoothsayers => (bool)this["IsPushPromptOnFriendRequestSentEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public int PushPromptOnFriendRequestSentRolloutPercentage => (int)this["PushPromptOnFriendRequestSentRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1024")]
	public int PublishedUserImageMaxEdgeSize => (int)this["PublishedUserImageMaxEdgeSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreMeshPartsEnabledForEveryone => (bool)this["AreMeshPartsEnabledForEveryone"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ServiceWorkerEnabledForBetaTesters => (bool)this["ServiceWorkerEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPushPromptOnFriendRequestSentEnabledForBetaTesters => (bool)this["IsPushPromptOnFriendRequestSentEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SortByPriceInRobuxEnabled => (bool)this["SortByPriceInRobuxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool JoinAshxUsesSharedJsonGenerator => (bool)this["JoinAshxUsesSharedJsonGenerator"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CloudTestEnabled => (bool)this["CloudTestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RenderCedexisTagFor13PlusOnlyEnabled => (bool)this["RenderCedexisTagFor13PlusOnlyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7")]
	public int NumberOfGamesFor126By126GameIcons => (int)this["NumberOfGamesFor126By126GameIcons"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OptimizedCatalogESQueriesEnabled => (bool)this["OptimizedCatalogESQueriesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:00")]
	public TimeSpan GameCardSaleCountDurableCounterCacheDuration => (TimeSpan)this["GameCardSaleCountDurableCounterCacheDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsResponsiveErrorPageEnabled => (bool)this["IsResponsiveErrorPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowConsoleDeviceTypeOnConfigurePlacePageForBetaTesters => (bool)this["ShowConsoleDeviceTypeOnConfigurePlacePageForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ConsoleContentAgreementEnabled => (bool)this["ConsoleContentAgreementEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SkipGearCheckWhenPlaceForbidsGear => (bool)this["SkipGearCheckWhenPlaceForbidsGear"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan ProfileMostVisitedPlaceCacheExpiration => (TimeSpan)this["ProfileMostVisitedPlaceCacheExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BootstrapperFileNamesFromClientSettingsEnabled => (bool)this["BootstrapperFileNamesFromClientSettingsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerifyTemporaryStoreCSSHash => (bool)this["VerifyTemporaryStoreCSSHash"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("MobileAppRobuxPage")]
	public string MobileAppRobuxPageAbTestName => (string)this["MobileAppRobuxPageAbTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSponsoredPageDevicesSelectorEnabled => (bool)this["IsSponsoredPageDevicesSelectorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int LowPriceItemSaleWarningPercentage => (int)this["LowPriceItemSaleWarningPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SkipIisCustomErrorsForNonExceptionsInAssetHandler => (bool)this["SkipIisCustomErrorsForNonExceptionsInAssetHandler"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerifyTemporaryStoreCSSHash1 => (bool)this["VerifyTemporaryStoreCSSHash1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ImageEndpointsUseSensableErrorCodeEnabled => (bool)this["ImageEndpointsUseSensableErrorCodeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MetaRefreshOnRobloxsProfileEnabled => (bool)this["MetaRefreshOnRobloxsProfileEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewIframeLoginEnabled => (bool)this["NewIframeLoginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int NotificationStreamBannerDismissTimeSpan => (int)this["NotificationStreamBannerDismissTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UpgradeIOSVersionForChatScreenEnabled => (bool)this["UpgradeIOSVersionForChatScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogErrorsOnAutoSaveAshxAccess => (bool)this["LogErrorsOnAutoSaveAshxAccess"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("9")]
	public int MinimumIOSVersionForChat => (int)this["MinimumIOSVersionForChat"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203313310-Trading-System")]
	public string TradeHelpUrl => (string)this["TradeHelpUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKidSafeEnabled => (bool)this["IsKidSafeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MessagePageReskinEnabledPercentage => (int)this["MessagePageReskinEnabledPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MessagePageReskinEnabledForSoothSayers => (bool)this["MessagePageReskinEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RealTimeNotificationDebuggingUserWhitelist => (string)this["RealTimeNotificationDebuggingUserWhitelist"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKidSafeFooterEnabled => (bool)this["IsKidSafeFooterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectHttpPostsToHttps => (bool)this["RedirectHttpPostsToHttps"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool RedirectPostsToCorrectSubdomain => (bool)this["RedirectPostsToCorrectSubdomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("((wiki|[^.]help|corp|polls|bloxcon|developer|devforum)\\.roblox\\.com|robloxlabs\\.com)")]
	public string LinkifyAsHttpRegex => (string)this["LinkifyAsHttpRegex"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VantivCreditCardTokenPaymentProviderEnabledForSoothsayers => (bool)this["VantivCreditCardTokenPaymentProviderEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VantivCreditCardTokenPaymentProviderEnabledForBetaTesters => (bool)this["VantivCreditCardTokenPaymentProviderEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int VantivCreditCardTokenPaymentProviderRolloutPercentage => (int)this["VantivCreditCardTokenPaymentProviderRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivEprotectClientJavascriptSource => (string)this["VantivEprotectClientJavascriptSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivEprotectId => (string)this["VantivEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivEprotectIframeCssFilename => (string)this["VantivEprotectIframeCssFilename"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("15000")]
	public int VantivEprotectTimeoutInMilliseconds => (int)this["VantivEprotectTimeoutInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool RedirectVantivCheckoutEnabled => (bool)this["RedirectVantivCheckoutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisableCrossDomainReqsForIE9AndLower => (bool)this["DisableCrossDomainReqsForIE9AndLower"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFirefoxCapableServiceWorkerEnabled => (bool)this["IsFirefoxCapableServiceWorkerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool LogAssetFetchValidationFailuresEnabled => (bool)this["LogAssetFetchValidationFailuresEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogAssetFetchGameServerValidatorWarningMessages => (bool)this["LogAssetFetchGameServerValidatorWarningMessages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRealTimeNotificationSequenceTrackingEnabled => (bool)this["IsRealTimeNotificationSequenceTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectToPasswordResetEnabled => (bool)this["RedirectToPasswordResetEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedirectAppsToNativePasswordResetConfirmation => (bool)this["RedirectAppsToNativePasswordResetConfirmation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("350")]
	public int MaximumEnteredEmailLength => (int)this["MaximumEnteredEmailLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=Commissions")]
	public string CommissionsWikiUrl => (string)this["CommissionsWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=Game_pass")]
	public string GamePassWikiUrl => (string)this["GamePassWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=Badge")]
	public string BadgeWikiUrl => (string)this["BadgeWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=Advertising")]
	public string AdvertisingWikiUrl => (string)this["AdvertisingWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=How_to_Make_Shirts_and_Pants")]
	public string CreateShirtsAndPantsWikiUrl => (string)this["CreateShirtsAndPantsWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=How_to_upload_a_Decal")]
	public string CreateDecalWikiUrl => (string)this["CreateDecalWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=How_to_upload_a_badge")]
	public string CreateBadgeWikiUrl => (string)this["CreateBadgeWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=How_to_upload_a_game_pass")]
	public string CreateGamePassWikiUrl => (string)this["CreateGamePassWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://wiki.roblox.com/index.php?title=How_to_Make_a_T-Shirt")]
	public string CreateTShirtWikiUrl => (string)this["CreateTShirtWikiUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GroupCreateReskinEnabledPercentage => (int)this["GroupCreateReskinEnabledPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupCreateReskinEnabledForSoothSayers => (bool)this["GroupCreateReskinEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsMailingListSignupCheckboxVisible => (bool)this["IsMailingListSignupCheckboxVisible"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Right_160x600")]
	public string O13MessageRightSkyscraperAdSlot => (string)this["O13MessageRightSkyscraperAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Top_728x90")]
	public string O13MessageLeaderboardAdSlot => (string)this["O13MessageLeaderboardAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Top_728x90")]
	public string O13MessageBannerAdSlot => (string)this["O13MessageBannerAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_160X600")]
	public string U13MessageRightSkyscraperAdSlot => (string)this["U13MessageRightSkyscraperAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_728x90")]
	public string U13MessageLeaderboardAdSlot => (string)this["U13MessageLeaderboardAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_728x90")]
	public string U13MessageBannerAdSlot => (string)this["U13MessageBannerAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int FriendsListOutputCacheDurationInSeconds => (int)this["FriendsListOutputCacheDurationInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SecurityTabEnabledOnSettingPageForAllUsers => (bool)this["SecurityTabEnabledOnSettingPageForAllUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SecurityTabEnabledOnSettingPageForSoothSayers => (bool)this["SecurityTabEnabledOnSettingPageForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ApiProxySettingsDomain => (string)this["ApiProxySettingsDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Top_728x90")]
	public string O13NewMessageLeaderboardAdSlot => (string)this["O13NewMessageLeaderboardAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_728x90")]
	public string U13NewMessageLeaderboardAdSlot => (string)this["U13NewMessageLeaderboardAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Right_160x600")]
	public string O13NewMessageRightSkyscraperAdSlot => (string)this["O13NewMessageRightSkyscraperAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_160X600")]
	public string U13NewMessageRightSkyscraperAdSlot => (string)this["U13NewMessageRightSkyscraperAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AreTieredAudioBucketsEnabled => (bool)this["AreTieredAudioBucketsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShortSoundEffectAudioUploadEnabled => (bool)this["ShortSoundEffectAudioUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LongSoundEffectAudioUploadEnabled => (bool)this["LongSoundEffectAudioUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MusicAudioUploadEnabled => (bool)this["MusicAudioUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LongMusicAudioUploadEnabled => (bool)this["LongMusicAudioUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int ShortSoundEffectAudioMaxLengthInSeconds => (int)this["ShortSoundEffectAudioMaxLengthInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int LongSoundEffectAudioMaxLengthInSeconds => (int)this["LongSoundEffectAudioMaxLengthInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("120")]
	public int MusicAudioMaxLengthInSeconds => (int)this["MusicAudioMaxLengthInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("360")]
	public int LongMusicAudioMaxLengthInSeconds => (int)this["LongMusicAudioMaxLengthInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("768")]
	public int ShortSoundEffectAudioMaxSizeInKb => (int)this["ShortSoundEffectAudioMaxSizeInKb"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1792")]
	public int LongSoundEffectAudioMaxSizeInKb => (int)this["LongSoundEffectAudioMaxSizeInKb"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8192")]
	public int MusicAudioMaxSizeInKb => (int)this["MusicAudioMaxSizeInKb"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10240")]
	public int LongMusicAudioMaxSizeInKb => (int)this["LongMusicAudioMaxSizeInKb"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int IframeLoadingTimeOutInMSForVantiv => (int)this["IframeLoadingTimeOutInMSForVantiv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IframeLoadingForVantivEnabled => (bool)this["IframeLoadingForVantivEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseAssetTypeIdForTradeFilter => (bool)this["UseAssetTypeIdForTradeFilter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTwoStepVerificationV2Enabled => (bool)this["IsTwoStepVerificationV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDesktopPushNonContextualPromptEnabledForRegularUsers => (bool)this["IsDesktopPushNonContextualPromptEnabledForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("14.00:00:00")]
	public TimeSpan DesktopPushNonContextualPromptMinAccountAge => (TimeSpan)this["DesktopPushNonContextualPromptMinAccountAge"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDesktopPushNonContextualPromptEnabledForSoothsayers => (bool)this["IsDesktopPushNonContextualPromptEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LazyLoadIframesEnabled => (bool)this["LazyLoadIframesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RixtyReskinPageEnabledForSoothsayer => (bool)this["RixtyReskinPageEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RixtyReskinPageEnabledForBetaTester => (bool)this["RixtyReskinPageEnabledForBetaTester"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RixtyReskinPageEnabledRolloutPercentage => (int)this["RixtyReskinPageEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogGzipExceptionsForAudioCatalogEnabled => (bool)this["LogGzipExceptionsForAudioCatalogEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogApplicationExceptionsForAudioCatalogEnabled => (bool)this["LogApplicationExceptionsForAudioCatalogEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowAudioInTheToolboxEnabled => (bool)this["ShowAudioInTheToolboxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00000000-0000-0000-0000-000000000000")]
	public Guid ToolboxSearchAlgorithmApiKey => (Guid)this["ToolboxSearchAlgorithmApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommunitySiftRandomizerEnabled => (bool)this["CommunitySiftRandomizerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeprecatedBrowserDialogEnabled => (bool)this["DeprecatedBrowserDialogEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableMobilePushBridgeOnIOS => (bool)this["EnableMobilePushBridgeOnIOS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableMobilePushBridgeOnIOSForSoothsayers => (bool)this["EnableMobilePushBridgeOnIOSForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableMobilePushBridgeOnAndroid => (bool)this["EnableMobilePushBridgeOnAndroid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableMobilePushBridgeOnAndroidForSoothsayers => (bool)this["EnableMobilePushBridgeOnAndroidForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.google.com/chrome/browser/desktop/index.html")]
	public string ChromeUpdateUrl => (string)this["ChromeUpdateUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogAudioUploadFailures => (bool)this["LogAudioUploadFailures"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string StudioToolboxSearchAlgorithmName1 => (string)this["StudioToolboxSearchAlgorithmName1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RealTimeNotificationsInAndroidEnabled => (bool)this["RealTimeNotificationsInAndroidEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogInvalidUserAgentsWhenValidatingMACAddresses => (bool)this["LogInvalidUserAgentsWhenValidatingMACAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EmbeddedUploadEnabled => (bool)this["EmbeddedUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int GamesPageInfiniteScrollAdRefreshRateMilliSeconds => (int)this["GamesPageInfiniteScrollAdRefreshRateMilliSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableRedirectionIfDomainNotInAllowedDomainsList => (bool)this["EnableRedirectionIfDomainNotInAllowedDomainsList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool OffSiteInterstitialsEnabled => (bool)this["OffSiteInterstitialsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string EnablingPingingGameDatacenters => (string)this["EnablingPingingGameDatacenters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string EnablePlaceDeveloperStats => (string)this["EnablePlaceDeveloperStats"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string ShowGamesTabOnIDEWelcomePage => (string)this["ShowGamesTabOnIDEWelcomePage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string RemoveBuildNewDropdownEnabled => (string)this["RemoveBuildNewDropdownEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string CatalogESClusterMigrationPercentage => (string)this["CatalogESClusterMigrationPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string AreSocialNetworkHandlesEnabled => (string)this["AreSocialNetworkHandlesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishMeshPartsEnabled => (bool)this["IsPublishMeshPartsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishUserImagesEnabled => (bool)this["IsPublishUserImagesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPublishUserImagesEnabledForSoothSayers => (bool)this["IsPublishUserImagesEnabledForSoothSayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int HttpRetryBackOffBaseTimeout => (int)this["HttpRetryBackOffBaseTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int HttpRetryBackOffMaxTimeout => (int)this["HttpRetryBackOffMaxTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan PushNotificationsReregistrationInterval => (TimeSpan)this["PushNotificationsReregistrationInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PushPromptIntervalsTimespanCSV => (string)this["PushPromptIntervalsTimespanCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WriteCrashDataToElasticsearch => (bool)this["WriteCrashDataToElasticsearch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool WriteCrashDataToSimpleDB => (bool)this["WriteCrashDataToSimpleDB"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReadCrashDataFromElasticsearch => (bool)this["ReadCrashDataFromElasticsearch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ReadCrashDataFromSimpleDB => (bool)this["ReadCrashDataFromSimpleDB"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayerSearchReskinPageEnabledForSoothsayers => (bool)this["IsPlayerSearchReskinPageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayerSearchReskinPageEnabledForBetaTesters => (bool)this["IsPlayerSearchReskinPageEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PlayerSearchReskinPageRolloutPercentage => (int)this["PlayerSearchReskinPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRefactoredRealTimeClientEnabled => (bool)this["IsRefactoredRealTimeClientEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRefactoredRealTimeClientEnabledForSoothsayers => (bool)this["IsRefactoredRealTimeClientEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsForumCaptchaEnabled => (bool)this["IsForumCaptchaEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int ForumCaptchaMinUserAgeInDays => (int)this["ForumCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAmazonShopLinkEnabled => (bool)this["IsAmazonShopLinkEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayabilityCheckByModeratedAndUnplayableEnabled => (bool)this["IsPlayabilityCheckByModeratedAndUnplayableEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayabilityCheckByCrashingRateEnabled => (bool)this["IsPlayabilityCheckByCrashingRateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("330")]
	public int ToolboxSearchAlgorithmObjectsLimitPerRequest => (int)this["ToolboxSearchAlgorithmObjectsLimitPerRequest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("513138389dfd773df77f5e2d58cc6a86")]
	public string ThreeDeeThumbnailHashesToInvalidateClientsideCsv => (string)this["ThreeDeeThumbnailHashesToInvalidateClientsideCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ThreeDeeThumbnailHashInvalidationVersion => (int)this["ThreeDeeThumbnailHashInvalidationVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChatInitialConversationEnabled => (bool)this["IsChatInitialConversationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan GameLaunchHashExpiration => (TimeSpan)this["GameLaunchHashExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int GameLaunchHashLength => (int)this["GameLaunchHashLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFriendshipRealTimeUpdateEnabled => (bool)this["IsFriendshipRealTimeUpdateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int CatalogDefaultResultsPerPage => (int)this["CatalogDefaultResultsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DontCloseCloudEditServersOnGameCloseEnabled => (bool)this["DontCloseCloudEditServersOnGameCloseEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CountryCodesForCostOptimizedMatchmaking => (string)this["CountryCodesForCostOptimizedMatchmaking"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.05")]
	public decimal WebAvatarScaleHeightIncrement => (decimal)this["WebAvatarScaleHeightIncrement"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.05")]
	public decimal WebAvatarScaleWidthIncrement => (decimal)this["WebAvatarScaleWidthIncrement"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileCatalogReskinEnabledForBetaTesters => (bool)this["IsMobileCatalogReskinEnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsPlaceCreationFromWebsiteEnabled => (bool)this["IsPlaceCreationFromWebsiteEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BestLogoEnabledForSoothsayer => (bool)this["BestLogoEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BestLogoEnabledForAll => (bool)this["BestLogoEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNavigationHeaderCountDisabled => (bool)this["IsNavigationHeaderCountDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCompanionAdRenderedByGoogleTag => (bool)this["IsCompanionAdRenderedByGoogleTag"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int PlayerSearchMaxResultRows => (int)this["PlayerSearchMaxResultRows"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	public int MinIOSVersionForSteamEmbeddedPageFixedViewport => (int)this["MinIOSVersionForSteamEmbeddedPageFixedViewport"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedeemToyPageEnabled => (bool)this["IsRedeemToyPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedeemToyPageEnabledForSoothsayers => (bool)this["IsRedeemToyPageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://roblox.jazwares.com/")]
	public string RedeemToyRedirectUrl => (string)this["RedeemToyRedirectUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public int RedeemToyCodeLength => (int)this["RedeemToyCodeLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendPeopleSearchEventEnabled => (bool)this["SendPeopleSearchEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendGroupSearchEventEnabled => (bool)this["SendGroupSearchEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendCatalogAndLibrarySearchEventEnabled => (bool)this["SendCatalogAndLibrarySearchEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Salt: An essential website ingredient")]
	public string ExclusiveStartPagingSalt => (string)this["ExclusiveStartPagingSalt"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsExclusiveStartBasedInventoryPageEnabled => (bool)this["IsExclusiveStartBasedInventoryPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsYouTubeVideoHiddenForAll => (bool)this["IsYouTubeVideoHiddenForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CompletelyHideAllYoutubeVideos => (bool)this["CompletelyHideAllYoutubeVideos"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("www.roblox.com,web.roblox.com")]
	public string CatalogItemForwardToDomainsWhitelistCSV => (string)this["CatalogItemForwardToDomainsWhitelistCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2.270.0.0")]
	public string MinimumIOSAppVersionToLaunchInAppAvatarEditorOnItemPage => (string)this["MinimumIOSAppVersionToLaunchInAppAvatarEditorOnItemPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchInAppAvatarEditorOnItemPageEnabledForIOS => (bool)this["LaunchInAppAvatarEditorOnItemPageEnabledForIOS"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2.270.0.0")]
	public string MinimumAndroidAppVersionToLaunchInAppAvatarEditorOnItemPage => (string)this["MinimumAndroidAppVersionToLaunchInAppAvatarEditorOnItemPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchInAppAvatarEditorOnItemPageEnabledForAndroid => (bool)this["LaunchInAppAvatarEditorOnItemPageEnabledForAndroid"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3000")]
	public int SignalRDisconnectionResponseInMilliseconds => (int)this["SignalRDisconnectionResponseInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsWebChatInAppEnabled => (bool)this["IsWebChatInAppEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StudioToolboxSearchModelsWilsonScoreSortingEnabled => (bool)this["StudioToolboxSearchModelsWilsonScoreSortingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoadingUserDataFromClientSideForAllEnabled => (bool)this["IsLoadingUserDataFromClientSideForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoadingUserDataFromClientSideForSoothsayerEnabled => (bool)this["IsLoadingUserDataFromClientSideForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double RealTimeClientEventSamplingPercentage => (double)this["RealTimeClientEventSamplingPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NewUnder13AdUnitsEnabled => (bool)this["NewUnder13AdUnitsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameDetailsPage970BannerAdEnabled => (bool)this["GameDetailsPage970BannerAdEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int HttpRetryBackOffMaxTimes => (int)this["HttpRetryBackOffMaxTimes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewExponentialBackOffForImageRetryEnabled => (bool)this["IsNewExponentialBackOffForImageRetryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPayPalExpressLoggingEnabled => (bool)this["IsPayPalExpressLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AuthenticationApiSiteEndpoint => (string)this["AuthenticationApiSiteEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("15")]
	public int MobileCatalogDefaultResultsPerPage => (int)this["MobileCatalogDefaultResultsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPhoneAppSiteWideBannerDisabled => (bool)this["IsPhoneAppSiteWideBannerDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayPriceFiltersInMobileCatalogReskinEnabled => (bool)this["DisplayPriceFiltersInMobileCatalogReskinEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ApplyMobileCatalogSortingToMobileReskinEnabled => (bool)this["ApplyMobileCatalogSortingToMobileReskinEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRealTimeClientDisconnectOnSlowConnectionDisabled => (bool)this["IsRealTimeClientDisconnectOnSlowConnectionDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string JobLinkAtFooter => (string)this["JobLinkAtFooter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	public byte DeveloperExchangeTermsVersion => (byte)this["DeveloperExchangeTermsVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRollerCoasterTextChangeAbTestEnabled => (bool)this["IsRollerCoasterTextChangeAbTestEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("com.roblox.client")]
	public string AndroidPackageName => (string)this["AndroidPackageName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int PlayerSearchKeywordMinLength => (int)this["PlayerSearchKeywordMinLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("You can only submit 12 auto generated thumbnails to moderation every 24 hours. ")]
	public string DefaultCameraGeneratedThumbnailFloodcheckMessage => (string)this["DefaultCameraGeneratedThumbnailFloodcheckMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsTradeWindowUsingInventoryHandlerEnabled => (bool)this["IsTradeWindowUsingInventoryHandlerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDisconnectXboxEnabled => (bool)this["IsDisconnectXboxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int TermsOfServiceVersion => (int)this["TermsOfServiceVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int PrivacyPolicyVersion => (int)this["PrivacyPolicyVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CatalogReskinSoothsayerVariant => (int)this["CatalogReskinSoothsayerVariant"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://blog.roblox.com/?feed=rss")]
	public string RobloxBlogFeedUrl => (string)this["RobloxBlogFeedUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RollercoasterDelayImageSourceEnabled => (bool)this["RollercoasterDelayImageSourceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LoadGptAdsAfterPageLoadEnabled => (bool)this["LoadGptAdsAfterPageLoadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoadRollercoasterImagesOnScrollEnabled => (bool)this["IsLoadRollercoasterImagesOnScrollEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsLeaderboardViewJSEnabled => (bool)this["IsLeaderboardViewJSEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameDetailsShareBarForAndroidEnabled => (bool)this["IsGameDetailsShareBarForAndroidEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("You can only submit 12 auto generated icons to moderation every 24 hours. ")]
	public string DefaultCameraGeneratedIconFloodcheckMessage => (string)this["DefaultCameraGeneratedIconFloodcheckMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRedeemToyModalEnabled => (bool)this["IsRedeemToyModalEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsKidSafeImageEnabled => (bool)this["IsKidSafeImageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAppChatPrivacySettingEnabled => (bool)this["IsAppChatPrivacySettingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameChatPrivacySettingEnabled => (bool)this["IsGameChatPrivacySettingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChatRespectPrivacySettingEnabled => (bool)this["IsChatRespectPrivacySettingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAgeBracketInNavigationEnabled => (bool)this["IsAgeBracketInNavigationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("AlgoName")]
	public string GameSearchAlgorithmName => (string)this["GameSearchAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ThumbnailPerformanceGALoggingPercentage => (int)this["ThumbnailPerformanceGALoggingPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDefaultCameraGeneratedModelOnPublishEnabled => (bool)this["IsDefaultCameraGeneratedModelOnPublishEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBlockAllModelNonMediaItemsEnabled => (bool)this["IsBlockAllModelNonMediaItemsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int DeveloperExchangeHelpPageVersion => (int)this["DeveloperExchangeHelpPageVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsInAppChatSettingForForumChannelsEnabled => (bool)this["IsInAppChatSettingForForumChannelsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialShareForU13Enabled => (bool)this["IsSocialShareForU13Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PreventMeshesBeingUploadedAsLua => (bool)this["PreventMeshesBeingUploadedAsLua"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAbuseReportReskinForSoothsayerEnabled => (bool)this["IsAbuseReportReskinForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAbuseReportReskinForBetaTesterEnabled => (bool)this["IsAbuseReportReskinForBetaTesterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AbuseReportReskinRolloutPercentage => (int)this["AbuseReportReskinRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsChatEmbeddedDebugInDesktopEnabled => (bool)this["IsChatEmbeddedDebugInDesktopEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_728x90")]
	public string U13CatalogLeaderboardAdSlot => (string)this["U13CatalogLeaderboardAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Catalog_Top_728x90")]
	public string O13CatalogLeaderboardAdSlot => (string)this["O13CatalogLeaderboardAdSlot"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGamesPageRefactorEnabled => (bool)this["IsGamesPageRefactorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGamesPageRefactorEnabledForSoothsayer => (bool)this["IsGamesPageRefactorEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAngularUpgradedForSoothsayerEnabled => (bool)this["IsAngularUpgradedForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAngularUpgradedForAllEnabled => (bool)this["IsAngularUpgradedForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string AngularUpgradedOnPageCSV => (string)this["AngularUpgradedOnPageCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseMacStudioDmg => (bool)this["UseMacStudioDmg"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/sections/200866010-Roblox-Rules-and-Guidelines")]
	public string CommunityRulesUrl => (string)this["CommunityRulesUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LaunchInAppAvatarEditorOnItemPageTabletMinimumAndroidAppVersion => (string)this["LaunchInAppAvatarEditorOnItemPageTabletMinimumAndroidAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchInAppAvatarEditorOnItemPageEnabledForAndroidTablet => (bool)this["LaunchInAppAvatarEditorOnItemPageEnabledForAndroidTablet"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string LaunchInAppAvatarEditorOnItemPageTabletMinimumIOSAppVersion => (string)this["LaunchInAppAvatarEditorOnItemPageTabletMinimumIOSAppVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LaunchInAppAvatarEditorOnItemPageEnabledForIOSTablet => (bool)this["LaunchInAppAvatarEditorOnItemPageEnabledForIOSTablet"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTermsPopupEverywhereEnabled => (bool)this["IsTermsPopupEverywhereEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MaximumNumberOfExtraCatalogReskinSearchRequests => (int)this["MaximumNumberOfExtraCatalogReskinSearchRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountSettingsContactSettingsV2Enabled => (bool)this["IsAccountSettingsContactSettingsV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountSettingsAccountRestrictionsV2Enabled => (bool)this["IsAccountSettingsAccountRestrictionsV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileSplashPageEnabledForSoothsayers => (bool)this["IsMobileSplashPageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMobileSplashPageEnabledForAll => (bool)this["IsMobileSplashPageEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://itunes.apple.com/us/app/roblox-mobile/id431946152")]
	public string ItunesAppStoreLink => (string)this["ItunesAppStoreLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://play.google.com/store/apps/details?id=com.roblox.client&hl=en")]
	public string GooglePlayStoreLink => (string)this["GooglePlayStoreLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long MobileBumperDismissTimeMs => (long)this["MobileBumperDismissTimeMs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogSearchLegacyEmptyListAttemptCounterEnabled => (bool)this["IsCatalogSearchLegacyEmptyListAttemptCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogAlternateSearchAttemptCounterEnabled => (bool)this["IsCatalogAlternateSearchAttemptCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAlternateCatalogSearchForReskinEnabled => (bool)this["IsAlternateCatalogSearchForReskinEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogSearchMostFavoritedAttemptCounterEnabled => (bool)this["IsCatalogSearchMostFavoritedAttemptCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountSettingsSocialNetworksV2Enabled => (bool)this["IsAccountSettingsSocialNetworksV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountSettingsSocialNetworksV2EnabledForSoothsayers => (bool)this["IsAccountSettingsSocialNetworksV2EnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogV1ItemsEndpointCounterEnabled => (bool)this["IsCatalogV1ItemsEndpointCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogV2ItemsEndpointCounterEnabled => (bool)this["IsCatalogV2ItemsEndpointCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogV1HtmlEndpointCounterEnabled => (bool)this["IsCatalogV1HtmlEndpointCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Disabled")]
	public string AbuseReportAppMinAndroidBuildVersion => (string)this["AbuseReportAppMinAndroidBuildVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Disabled")]
	public string AbuseReportAppMinIosBuildVersion => (string)this["AbuseReportAppMinIosBuildVersion"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStudioFacebookLoginEnabled => (bool)this["IsStudioFacebookLoginEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203313100-How-Do-I-Change-My-Password")]
	public string StudioFacebookLoginLearnMoreLink => (string)this["StudioFacebookLoginLearnMoreLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialShareForIosEnabled => (bool)this["IsSocialShareForIosEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOldRatesWarningForCashOutEnabled => (bool)this["IsOldRatesWarningForCashOutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public int NumberOfCatalogItemsToDisplayOnSplash => (int)this["NumberOfCatalogItemsToDisplayOnSplash"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotificationStreamOnUWPForSoothsayerEnabled => (bool)this["IsNotificationStreamOnUWPForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsNotificationStreamOnUWPRolloutPercentage => (int)this["IsNotificationStreamOnUWPRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserMetaTagEnabled => (bool)this["IsUserMetaTagEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int RobuxPageOnUWPEnabledRolloutPercentage => (int)this["RobuxPageOnUWPEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobuxPageOnUWPEnabledForRegularUsers => (bool)this["IsRobuxPageOnUWPEnabledForRegularUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTls12Enabled => (bool)this["IsTls12Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:02")]
	public TimeSpan ExperimentalGameSortServiceTimeout => (TimeSpan)this["ExperimentalGameSortServiceTimeout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UseExperimentalGameSortCache => (bool)this["UseExperimentalGameSortCache"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox.Game.Search")]
	public string ExperimentalGameSortCachePrefix => (string)this["ExperimentalGameSortCachePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("algorithmgamesearch")]
	public string ExperimentalGameSortServiceName => (string)this["ExperimentalGameSortServiceName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("512")]
	public int AbuseReportCommentMaxLength => (int)this["AbuseReportCommentMaxLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsXboxPlatformExclusiveRecommendationFilterEnabled => (bool)this["IsXboxPlatformExclusiveRecommendationFilterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowPlayGameInRobloxStudio => (bool)this["AllowPlayGameInRobloxStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("default")]
	public string StudioToolboxSearchDefaultAlgorithmName => (string)this["StudioToolboxSearchDefaultAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5000")]
	public int TypingInChatFromSenderThrottleMs => (int)this["TypingInChatFromSenderThrottleMs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8000")]
	public int TypingInChatForReceiverExpirationMs => (int)this["TypingInChatForReceiverExpirationMs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsNotificationStreamInDesktopEnabled => (bool)this["IsNotificationStreamInDesktopEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsNotificationStreamInAppEnabled => (bool)this["IsNotificationStreamInAppEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivEprotectIframeNewPaymentCssFilename => (string)this["VantivEprotectIframeNewPaymentCssFilename"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerticalTabsForSettingsEnabledForSoothsayers => (bool)this["VerticalTabsForSettingsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VerticalTabsForSettingsEnabledForAll => (bool)this["VerticalTabsForSettingsEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAgeDataForDevStatsEnabled => (bool)this["IsAgeDataForDevStatsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MinimumPlaceVisitsRequiredToShowDeveloperAgeData => (int)this["MinimumPlaceVisitsRequiredToShowDeveloperAgeData"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAgeDataForDevStatsEnabledForSoothsayers => (bool)this["IsAgeDataForDevStatsEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHasBadgeIncorrectUsageTrackingEnabled => (bool)this["IsHasBadgeIncorrectUsageTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchWilsonScoreSortingEnabled => (bool)this["GameSearchWilsonScoreSortingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("default")]
	public string GameSearchDefaultAlgorithmName => (string)this["GameSearchDefaultAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxCrossPlayUserNameEnabled => (bool)this["XboxCrossPlayUserNameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCuratedSortsAbTestEnrollmentInGamesPageEnabled => (bool)this["IsCuratedSortsAbTestEnrollmentInGamesPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PresenceServiceInWebPageRolloutPercentage => (int)this["PresenceServiceInWebPageRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPresenceServiceInWebPageForSoothsayerEnabled => (bool)this["IsPresenceServiceInWebPageForSoothsayerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDevelopFutureChangesMessageEnabled => (bool)this["IsDevelopFutureChangesMessageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox is making important to changes to game discoverability. Please <a href=\"http://devforum.roblox.com/t/the-future-of-filtering-enabled/35747/28\" target=\"_blank\">click here</a> for more information")]
	public string DevelopFutureChangesMessage => (string)this["DevelopFutureChangesMessage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUiBootstrapModalV2Enabled => (bool)this["IsUiBootstrapModalV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUiBootstrapModalV2EnabledForSoothsayers => (bool)this["IsUiBootstrapModalV2EnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCaptchaFirstMessageEnabledForAll => (bool)this["IsCaptchaFirstMessageEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCaptchaFirstMessageEnabledForSoothsayers => (bool)this["IsCaptchaFirstMessageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int MessageCaptchaMinUserAgeInDays => (int)this["MessageCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.05")]
	public decimal WebAvatarScaleHeadIncrement => (decimal)this["WebAvatarScaleHeadIncrement"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ListenToRecentAvatarItemChanges => (bool)this["ListenToRecentAvatarItemChanges"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVIPServerReskinEnabledForSoothsayer => (bool)this["IsVIPServerReskinEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVIPServerReskinEnabledForBetaTester => (bool)this["IsVIPServerReskinEnabledForBetaTester"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int VIPServerReskinRolloutPercentage => (int)this["VIPServerReskinRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountSettingsPhoneNumberForSoothsayersEnabled => (bool)this["IsAccountSettingsPhoneNumberForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte MinAgeToNotSeeOnlySecureGamesOnGamesPage => (byte)this["MinAgeToNotSeeOnlySecureGamesOnGamesPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVoteEventEnabled => (bool)this["IsVoteEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVoteEventForPlaceEnabled => (bool)this["IsVoteEventForPlaceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ChatAppSiteVersionForSoothsayer => (int)this["ChatAppSiteVersionForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccountSettingsPhoneNumberRolloutPercentage => (int)this["AccountSettingsPhoneNumberRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFortyNineCentsRobuxEnabled => (bool)this["IsFortyNineCentsRobuxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsModeratedMeshRenderingDisabled => (bool)this["IsModeratedMeshRenderingDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/catalog")]
	public string CatalogLinkOnHomeFeedForPhone => (string)this["CatalogLinkOnHomeFeedForPhone"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AllowCreatorsToAccessInReviewAssets => (bool)this["AllowCreatorsToAccessInReviewAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoginPageEventsEnabled => (bool)this["IsLoginPageEventsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ChatAppSiteVersionForAll => (int)this["ChatAppSiteVersionForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AvatarEditorShowDefaultClothingMessageOnPageLoad => (bool)this["AvatarEditorShowDefaultClothingMessageOnPageLoad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebsiteAwsBucketAccessKey => (string)this["WebsiteAwsBucketAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebsiteAwsBucketSecretAccessKey => (string)this["WebsiteAwsBucketSecretAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public byte RedeemGiftCardCodeLength => (byte)this["RedeemGiftCardCodeLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public byte RedeemGameCardCodeLength => (byte)this["RedeemGameCardCodeLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageU13SeeSecureOnlyABTestName => (string)this["GamesPageU13SeeSecureOnlyABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GamesPageGuestSeeSecureOnlyABTestName => (string)this["GamesPageGuestSeeSecureOnlyABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DoGuestsSeeOnlySecureGamesOnGamesPage => (bool)this["DoGuestsSeeOnlySecureGamesOnGamesPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8qcYC-zwCvI")]
	public string RedeemToysHowToVideoYouTubeId => (string)this["RedeemToysHowToVideoYouTubeId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialNetworkControllerMetricsEnabled => (bool)this["IsSocialNetworkControllerMetricsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int FriendCaptchaMinUserAgeInDays => (int)this["FriendCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public int FollowCaptchaMinUserAgeInDays => (int)this["FollowCaptchaMinUserAgeInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1428257")]
	public int EndorsedSetId => (int)this["EndorsedSetId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSeeOnlySecureGamesOnGamesPageForSoothSayersEnabled => (bool)this["IsSeeOnlySecureGamesOnGamesPageForSoothSayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AvatarEditorShowAppUpsellOnMobile => (bool)this["AvatarEditorShowAppUpsellOnMobile"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsForgotCredentialsWithEmailAndPhoneForSoothsayersEnabled => (bool)this["IsForgotCredentialsWithEmailAndPhoneForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsForgotCredentialsWithEmailAndPhoneForAllEnabled => (bool)this["IsForgotCredentialsWithEmailAndPhoneForAllEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameSearchSecureGamesABTestName => (string)this["GameSearchSecureGamesABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GameSearchSecureGamesGuestABTestName => (string)this["GameSearchSecureGamesGuestABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte MinAgeToSeeExperimentalGamesInGamesSearch => (byte)this["MinAgeToSeeExperimentalGamesInGamesSearch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ExperimentalGamesInfoLink => (string)this["ExperimentalGamesInfoLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DevelopSplashScreenV2EnabledForSoothsayers => (bool)this["DevelopSplashScreenV2EnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DevelopSplashScreenV2EnabledForBetaTesters => (bool)this["DevelopSplashScreenV2EnabledForBetaTesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DevelopSplashScreenV2RolloutPercentage => (int)this["DevelopSplashScreenV2RolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DevelopSplashScreenV2ABTestName => (string)this["DevelopSplashScreenV2ABTestName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CookieLawNoticeCountries => (string)this["CookieLawNoticeCountries"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCookieLawNoticeEnabled => (bool)this["IsCookieLawNoticeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20000")]
	public int CookieLawNoticeTimeoutInMilliseconds => (int)this["CookieLawNoticeTimeoutInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ArePhoneNumberEphemeralCountersEnabled => (bool)this["ArePhoneNumberEphemeralCountersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSignUpPageBirthdayToTopEnabled => (bool)this["IsSignUpPageBirthdayToTopEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsHasGamePassIncorrectUsageTrackingEnabled => (bool)this["IsHasGamePassIncorrectUsageTrackingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountCountryLocalizationEnabledForSoothsayers => (bool)this["IsAccountCountryLocalizationEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountCountryLocalizationEnabledForAll => (bool)this["IsAccountCountryLocalizationEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public int RedeemGameCardLength => (int)this["RedeemGameCardLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMvcBadgePageEnabled => (bool)this["IsMvcBadgePageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://blog.roblox.com")]
	public string BlogLink => (string)this["BlogLink"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string WebsiteDmpBucketAwsAccessKeySecretKeyCsv => (string)this["WebsiteDmpBucketAwsAccessKeySecretKeyCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayFriendsDescriptionInGameInstances => (bool)this["DisplayFriendsDescriptionInGameInstances"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DisplayJoinedServersInGameInstances => (bool)this["DisplayJoinedServersInGameInstances"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAlternativeMauCounterEnabled => (bool)this["IsAlternativeMauCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGroupCanAddGroupPlacesRoleSetEnabled => (bool)this["IsGroupCanAddGroupPlacesRoleSetEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public string IsGroupClothingOnDevelopPageEnabled => (string)this["IsGroupClothingOnDevelopPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool XboxCrossPlayPartyFollowMatchmaking => (bool)this["XboxCrossPlayPartyFollowMatchmaking"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInDesktopForSoothsayers => (bool)this["IsShareGameToChatEnabledInDesktopForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInDesktopForBetatesters => (bool)this["IsShareGameToChatEnabledInDesktopForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ShareGameToChatEnabledInDesktopRolloutPercentage => (int)this["ShareGameToChatEnabledInDesktopRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInIosTabletForSoothsayers => (bool)this["IsShareGameToChatEnabledInIosTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInIosTabletForBetatesters => (bool)this["IsShareGameToChatEnabledInIosTabletForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ShareGameToChatEnabledInIosTabletRolloutPercentage => (int)this["ShareGameToChatEnabledInIosTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInIosPhoneForSoothsayers => (bool)this["IsShareGameToChatEnabledInIosPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInIosPhoneForBetatesters => (bool)this["IsShareGameToChatEnabledInIosPhoneForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ShareGameToChatEnabledInIosPhoneRolloutPercentage => (int)this["ShareGameToChatEnabledInIosPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInAndroidTabletForSoothsayers => (bool)this["IsShareGameToChatEnabledInAndroidTabletForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInAndroidTabletForBetatesters => (bool)this["IsShareGameToChatEnabledInAndroidTabletForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ShareGameToChatEnabledInAndroidTabletRolloutPercentage => (int)this["ShareGameToChatEnabledInAndroidTabletRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInAndroidPhoneForSoothsayers => (bool)this["IsShareGameToChatEnabledInAndroidPhoneForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatEnabledInAndroidPhoneForBetatesters => (bool)this["IsShareGameToChatEnabledInAndroidPhoneForBetatesters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ShareGameToChatEnabledInAndroidPhoneRolloutPercentage => (int)this["ShareGameToChatEnabledInAndroidPhoneRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsShareGameToChatCheckLoggingEnabled => (bool)this["IsShareGameToChatCheckLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsRequestUserPartyGameExceptionLoggingEnabled => (bool)this["IsRequestUserPartyGameExceptionLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLoggingEnabledForItemPurchase => (bool)this["IsLoggingEnabledForItemPurchase"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountSettingsPhoneNumberForBetaTestersEnabled => (bool)this["IsAccountSettingsPhoneNumberForBetaTestersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SupportExtraFieldsInMySettingsJson => (bool)this["SupportExtraFieldsInMySettingsJson"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxDisplayedAccountsPerEmail => (int)this["MaxDisplayedAccountsPerEmail"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string RedirectToZendeskEnabled1 => (string)this["RedirectToZendeskEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public string GrantTicketsOnPlaceVisitEnabled1 => (string)this["GrantTicketsOnPlaceVisitEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public string GrantTicketsOnPlaceVisitEnabled11 => (string)this["GrantTicketsOnPlaceVisitEnabled11"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Top_728x90")]
	public string O13NewMessageLeaderboardAdSlot1 => (string)this["O13NewMessageLeaderboardAdSlot1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_728x90")]
	public string U13NewMessageLeaderboardAdSlot1 => (string)this["U13NewMessageLeaderboardAdSlot1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_Default_Right_160x600")]
	public string O13NewMessageRightSkyscraperAdSlot1 => (string)this["O13NewMessageRightSkyscraperAdSlot1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox_U13_Direct_160X600")]
	public string U13NewMessageRightSkyscraperAdSlot1 => (string)this["U13NewMessageRightSkyscraperAdSlot1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public string FriendsListOutputCacheDurationInSeconds1 => (string)this["FriendsListOutputCacheDurationInSeconds1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string SecurityTabEnabledOnSettingPageForAllUsers1 => (string)this["SecurityTabEnabledOnSettingPageForAllUsers1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string SecurityTabEnabledOnSettingPageForSoothSayers1 => (string)this["SecurityTabEnabledOnSettingPageForSoothSayers1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ApiProxySettingsDomain1 => (string)this["ApiProxySettingsDomain1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public string IsPlaceCreationFromWebsiteEnabled1 => (string)this["IsPlaceCreationFromWebsiteEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsGameChatPrivacySettingEnabled1 => (string)this["IsGameChatPrivacySettingEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string ChatAppSiteVersionForSoothsayer1 => (string)this["ChatAppSiteVersionForSoothsayer1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsSocialNetworkControllerMetricsEnabled1 => (string)this["IsSocialNetworkControllerMetricsEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("365")]
	public string FriendCaptchaMinUserAgeInDays1 => (string)this["FriendCaptchaMinUserAgeInDays1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public string IsNotificationStreamInDesktopEnabled1 => (string)this["IsNotificationStreamInDesktopEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public string IsNotificationStreamInAppEnabled1 => (string)this["IsNotificationStreamInAppEnabled1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsVIPServerReskinEnabledForSoothsayer1 => (string)this["IsVIPServerReskinEnabledForSoothsayer1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsVIPServerReskinEnabledForBetaTester1 => (string)this["IsVIPServerReskinEnabledForBetaTester1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string VIPServerReskinRolloutPercentage1 => (string)this["VIPServerReskinRolloutPercentage1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string MinimumThreadPoolThreadCount => (string)this["MinimumThreadPoolThreadCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsStudioStartGameV2JavaScriptCallEnabled => (bool)this["IsStudioStartGameV2JavaScriptCallEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsStudioStartGameV1JavaScriptCallEnabled => (bool)this["IsStudioStartGameV1JavaScriptCallEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("png,jpg,jpeg,tga,bmp")]
	public string ImageFileTypes => (string)this["ImageFileTypes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int ItemDescriptionMaxCharacterCount => (int)this["ItemDescriptionMaxCharacterCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsConfigurePlaceEventStreamLoggingEnabled => (bool)this["IsConfigurePlaceEventStreamLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewCapturePersonalInfoScreenEnabled => (bool)this["IsNewCapturePersonalInfoScreenEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBadgeAbuseReportAsPlatformBadgeEnabled => (bool)this["IsBadgeAbuseReportAsPlatformBadgeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivEUREprotectId => (string)this["VantivEUREprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGamePromotionChannelsEnabled => (bool)this["IsGamePromotionChannelsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGroupPromotionChannelsEnabled => (bool)this["IsGroupPromotionChannelsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivCADEprotectId => (string)this["VantivCADEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivAUDEprotectId => (string)this["VantivAUDEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivCLPEprotectId => (string)this["VantivCLPEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivNZDEprotectId => (string)this["VantivNZDEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivGBPEprotectId => (string)this["VantivGBPEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivHKDEprotectId => (string)this["VantivHKDEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivCOPEprotectId => (string)this["VantivCOPEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivMXNEprotectId => (string)this["VantivMXNEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string VantivTWDEprotectId => (string)this["VantivTWDEprotectId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("70")]
	public int SocialLinkTitleMaxCharacterCount => (int)this["SocialLinkTitleMaxCharacterCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int NumberOfEditableSocialLinks => (int)this["NumberOfEditableSocialLinks"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsGameUpdateNotificationsUIBetaOnlyEnabled => (bool)this["IsGameUpdateNotificationsUIBetaOnlyEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameUpdateNotificationsUIEnabled => (bool)this["IsGameUpdateNotificationsUIEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsExtraMessageSendEndpointEnabled => (bool)this["IsExtraMessageSendEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLocalizedCountryNameEnabled => (bool)this["IsLocalizedCountryNameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GameUpdateNotificationUserRolloutPercentage => (int)this["GameUpdateNotificationUserRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThumbnailUploadMetricsTrackerEnabled => (bool)this["IsThumbnailUploadMetricsTrackerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsThumbnailsApiAvailableToNotificationStream => (bool)this["IsThumbnailsApiAvailableToNotificationStream"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRemoveThumbnailImageCostEnabled => (bool)this["IsRemoveThumbnailImageCostEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTwoStepVerificationUsingAuthenticationApiEnabled => (bool)this["IsTwoStepVerificationUsingAuthenticationApiEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNavigationAbbreviationV2Enabled => (bool)this["IsNavigationAbbreviationV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUpdatingRootPlaceNameWhenUniverseNameChangesEnabled => (bool)this["IsUpdatingRootPlaceNameWhenUniverseNameChangesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsRequestValidationForUnsafeInputEnabled => (bool)this["IsRequestValidationForUnsafeInputEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameUpdateAbuseReportEnabled => (bool)this["IsGameUpdateAbuseReportEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CatalogSaleBundlesCSV => (string)this["CatalogSaleBundlesCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserFloodedOverrideEnabled => (bool)this["IsUserFloodedOverrideEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDelayedReleaseRedirectCounterEnabled => (bool)this["IsDelayedReleaseRedirectCounterEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PromoCodeLinkInToysRedeemPageEnabledForAll => (bool)this["PromoCodeLinkInToysRedeemPageEnabledForAll"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PromoCodeLinkInToysRedeemPageEnabledForSoothsayers => (bool)this["PromoCodeLinkInToysRedeemPageEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsToolboxFreePluginsEndpointEnabled => (bool)this["IsToolboxFreePluginsEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsToolboxMyPluginsEndpointEnabled => (bool)this["IsToolboxMyPluginsEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsToolboxEndorsedPluginsEndpointEnabled => (bool)this["IsToolboxEndorsedPluginsEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ThompsonSamplingStudioToolboxEnabled => (bool)this["ThompsonSamplingStudioToolboxEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int WilsonScoreQueryCount => (int)this["WilsonScoreQueryCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int DefaultQueryCount => (int)this["DefaultQueryCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.robloxdev.com/")]
	public string StudioDocsPageUrl => (string)this["StudioDocsPageUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRemoveLegacyAssetsFromAssetControllerEnabled => (bool)this["IsRemoveLegacyAssetsFromAssetControllerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCloudSavedGamesEnabled => (bool)this["IsCloudSavedGamesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("mixed")]
	public string StudioToolboxSearchMixedAlgorithmName => (string)this["StudioToolboxSearchMixedAlgorithmName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int ToolboxSearchThompsonSamplingQueryPercentage => (int)this["ToolboxSearchThompsonSamplingQueryPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSocialLinksConfigurationViaWebAppEnabled => (bool)this["IsSocialLinksConfigurationViaWebAppEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCookieLawNoticeV2Enabled => (bool)this["IsCookieLawNoticeV2Enabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsToolboxMyModelsExcludePackagesEnabled => (bool)this["IsToolboxMyModelsExcludePackagesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Presence_PresenceUser,Presence_PresenceUsers,Friends_FriendsList,NativeAds_Serve,UserAds_ShowUserAd,Games_GameDetailReferral,Game_ReportEvent")]
	public string ControllerActionPairsExcludedForRegisteringPresenceCsv => (string)this["ControllerActionPairsExcludedForRegisteringPresenceCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAuthenticationApiLogoutEnabled => (bool)this["IsAuthenticationApiLogoutEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserSoothsayerAndOverrideFloodcheckerEnabled => (bool)this["IsUserSoothsayerAndOverrideFloodcheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsOwnedNotForSaleAssetsHiddenOnLibraryEndpointEnabled => (bool)this["IsOwnedNotForSaleAssetsHiddenOnLibraryEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNotForSaleAssetHidingOnLibraryEndpointEnabled => (bool)this["IsNotForSaleAssetHidingOnLibraryEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan GameDetailPageIOSExpireHeaderTime => (TimeSpan)this["GameDetailPageIOSExpireHeaderTime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCatalogCacheForInternalErrorsEnabled => (bool)this["IsCatalogCacheForInternalErrorsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendCatalogSortEventEnabled => (bool)this["SendCatalogSortEventEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsBCSigningBonusEnabled => (bool)this["IsBCSigningBonusEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGameLogoutRestrictedToStudio => (bool)this["IsGameLogoutRestrictedToStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseAvatarWebAppV2 => (bool)this["UseAvatarWebAppV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRobloxPremiumEnabled => (bool)this["IsRobloxPremiumEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2000")]
	public string UserNotificationsTestIntervalInMilliseconds => (string)this["UserNotificationsTestIntervalInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsRealTimeClientStateTrackingEnabledInIOSWebviews => (string)this["IsRealTimeClientStateTrackingEnabledInIOSWebviews"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsRealTimeClientStateTrackingEnabledInAndroidWebviews => (string)this["IsRealTimeClientStateTrackingEnabledInAndroidWebviews"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsRealTimeClientStateTrackingEnabledInNonAppWebviews => (string)this["IsRealTimeClientStateTrackingEnabledInNonAppWebviews"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAngularJsBundleEnabled => (bool)this["IsAngularJsBundleEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PublishServiceDecalsRolloutPercentage => (int)this["PublishServiceDecalsRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNumberOfPlaceVisitsUsingGetPublicPlacesEnabled => (bool)this["IsNumberOfPlaceVisitsUsingGetPublicPlacesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsCopyingAllowedOnlyForVerifiedCreatorEnabledRolloutPercentage => (int)this["IsCopyingAllowedOnlyForVerifiedCreatorEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUniverseCountReadingFromUniverseFactoryEnabled => (bool)this["IsUniverseCountReadingFromUniverseFactoryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCookieBannerWebAppEnabled => (bool)this["IsCookieBannerWebAppEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PublishServiceEndpoint => (string)this["PublishServiceEndpoint"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int IsPluginCopyingAllowedOnlyForVerifiedCreatorEnabledRolloutPercentage => (int)this["IsPluginCopyingAllowedOnlyForVerifiedCreatorEnabledRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsToolboxWhitelistedPluginsEndpointEnabled => (bool)this["IsToolboxWhitelistedPluginsEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1234")]
	public int PromMetricsPort => (int)this["PromMetricsPort"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InventoryWebAppForSoothsayersEnabled => (bool)this["InventoryWebAppForSoothsayersEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int InventoryWebAppRolloutPercentage => (int)this["InventoryWebAppRolloutPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32768")]
	public int PromLowerPortRange => (int)this["PromLowerPortRange"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32780")]
	public int PromHigherPortRange => (int)this["PromHigherPortRange"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsToolboxGroupPluginsEndpointEnabled => (bool)this["IsToolboxGroupPluginsEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PublishServiceDebugClient => (bool)this["PublishServiceDebugClient"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string LocalStorageOptimizationEnabledForNotifications => (string)this["LocalStorageOptimizationEnabledForNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string IsRealTimeHybridSourceOnAndroidEnabledRollout => (string)this["IsRealTimeHybridSourceOnAndroidEnabledRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsRealTimeHybridSourceOnAndroidEnabledForSoothsayers => (string)this["IsRealTimeHybridSourceOnAndroidEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public string IsRealTimeHybridSourceOnIOSEnabledRollout => (string)this["IsRealTimeHybridSourceOnIOSEnabledRollout"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string IsRealTimeHybridSourceOnIOSEnabledForSoothsayers => (string)this["IsRealTimeHybridSourceOnIOSEnabledForSoothsayers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsDevelopApiToolboxEndpointEnabled => (bool)this["IsDevelopApiToolboxEndpointEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsCounterRegistryUserSearcherCtorEnabled => (bool)this["IsCounterRegistryUserSearcherCtorEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CounterRegistryUserSearcherCtorPercent => (int)this["CounterRegistryUserSearcherCtorPercent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsGetPluginsVersionIdEnabled => (bool)this["IsGetPluginsVersionIdEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://apis.simulpong.com/universal-app-compliance-service/")]
	public string ComplianceServerUrl => (string)this["ComplianceServerUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("test-is-china")]
	public string UserSearchPolicyList => (string)this["UserSearchPolicyList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2,3")]
	public string JvExternalIdentityValues => (string)this["JvExternalIdentityValues"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsExternalIdentityFilteringEnabled => (bool)this["IsExternalIdentityFilteringEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPremiumIconToTheLeft => (bool)this["IsPremiumIconToTheLeft"];

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
