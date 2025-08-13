using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.FloodCheckers.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int AbuseReportSubmissionFloodCheckLimit => (int)this["AbuseReportSubmissionFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AbuseReportSubmissionFloodCheckTimeSpan => (TimeSpan)this["AbuseReportSubmissionFloodCheckTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccountCreationFloodCheckLimit => (int)this["AccountCreationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccountCreationFloodCheckTimeLimitInHours => (int)this["AccountCreationFloodCheckTimeLimitInHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LoginFloodCheckLimitPerHour => (int)this["LoginFloodCheckLimitPerHour"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ModifyEmailFloodCheckExpiryHours => (TimeSpan)this["ModifyEmailFloodCheckExpiryHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ModifyEmailFloodCheckLimit => (int)this["ModifyEmailFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ParentsVerifyInfoFloodCheckLimit => (int)this["ParentsVerifyInfoFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ParentsVerifyInfoFloodCheckTimeLimit => (int)this["ParentsVerifyInfoFloodCheckTimeLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ParentsAgeUpEmailFloodCheckLimit => (int)this["ParentsAgeUpEmailFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ParentsAgeUpEmailFloodCheckExpiry => (int)this["ParentsAgeUpEmailFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewsletterUnsubscribeFloodCheckExpiryHours => (int)this["NewsletterUnsubscribeFloodCheckExpiryHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int NewsletterUnsubscribeFloodCheckLimit => (int)this["NewsletterUnsubscribeFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GiftCardAccessFloodCheckLimit => (int)this["GiftCardAccessFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GiftCardAccessFloodCheckExpiryHours => (int)this["GiftCardAccessFloodCheckExpiryHours"];

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
	[DefaultSettingValue("3")]
	public int FriendRequestFloodCheckerLimit => (int)this["FriendRequestFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan FriendRequestFloodCheckerExpiry => (TimeSpan)this["FriendRequestFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int SendMessageFloodCheckerLimit => (int)this["SendMessageFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan SendMessageFloodCheckerExpiry => (TimeSpan)this["SendMessageFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PwdResetFloodCheckerLimit => (int)this["PwdResetFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan PwdResetFloodCheckerExpiry => (TimeSpan)this["PwdResetFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan LoginFloodCheckExpiry => (TimeSpan)this["LoginFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TradeSystemFloodCheckLimit => (int)this["TradeSystemFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan TradeSystemFloodCheckExpiry => (TimeSpan)this["TradeSystemFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AbuseReportAllegationFloodCheckLimit => (int)this["AbuseReportAllegationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AbuseReportAllegationFloodCheckTimeSpan => (TimeSpan)this["AbuseReportAllegationFloodCheckTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("6")]
	public int GroupWallPostFloodCheckLimit => (int)this["GroupWallPostFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan GroupWallPostFloodCheckExpiry => (TimeSpan)this["GroupWallPostFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int AppleAppStoreSandboxLimitPerHour => (int)this["AppleAppStoreSandboxLimitPerHour"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public int FloodCheckPerHourVideoRefund => (int)this["FloodCheckPerHourVideoRefund"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan KnockoutsFloodCheckerExpiry => (TimeSpan)this["KnockoutsFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public int KnockoutsFloodCheckerLimit => (int)this["KnockoutsFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan WipeoutsFloodCheckerExpiry => (TimeSpan)this["WipeoutsFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int WipeoutsFloodCheckerLimit => (int)this["WipeoutsFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int ImageUploadFloodCheckLimit => (int)this["ImageUploadFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan ImageUploadFloodCheckExpiry => (TimeSpan)this["ImageUploadFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int DeclinedCardByUserFloodCheckLimit => (int)this["DeclinedCardByUserFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan DeclinedCardByUserFloodCheckExpiry => (TimeSpan)this["DeclinedCardByUserFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int DeclinedCardByIPFloodCheckLimit => (int)this["DeclinedCardByIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan DeclinedCardByIPFloodCheckExpiry => (TimeSpan)this["DeclinedCardByIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ItemPurchaseLimit => (int)this["ItemPurchaseLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ItemPurchaseFloodCheckExpiry => (TimeSpan)this["ItemPurchaseFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ItemPurchaseFloodCheckEnabled => (bool)this["ItemPurchaseFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int VoteFloodCheckLimit => (int)this["VoteFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double VoteFloodCheckExpiry => (double)this["VoteFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UploadFileLimit => (int)this["UploadFileLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan UploadFileFloodCheckExpiry => (TimeSpan)this["UploadFileFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UploadFileFloodCheckEnabled => (bool)this["UploadFileFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FreeItemPurchaseLimit => (int)this["FreeItemPurchaseLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan FreeItemPurchaseFloodCheckExpiry => (TimeSpan)this["FreeItemPurchaseFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FreeItemPurchaseFloodCheckEnabled => (bool)this["FreeItemPurchaseFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int PurchaseAttemptByUserFloodCheckLimit => (int)this["PurchaseAttemptByUserFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan PurchaseAttemptByUserFloodCheckExpiry => (TimeSpan)this["PurchaseAttemptByUserFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int PurchaseAttemptByIPFloodCheckLimit => (int)this["PurchaseAttemptByIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan PurchaseAttemptByIPFloodCheckExpiry => (TimeSpan)this["PurchaseAttemptByIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public int SendMessageToUserFloodCheckLimit => (int)this["SendMessageToUserFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan SendMessageToUserFloodCheckExpiry => (TimeSpan)this["SendMessageToUserFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int ChangeProductPriceFloodCheckLimit => (int)this["ChangeProductPriceFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan ChangeProductPriceFloodCheckExpiry => (TimeSpan)this["ChangeProductPriceFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int VoteIPAndAssetIdFloodCheckLimit => (int)this["VoteIPAndAssetIdFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double VoteIPAndAssetIdFloodCheckExpiryInHours => (double)this["VoteIPAndAssetIdFloodCheckExpiryInHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("15")]
	public int DeveloperProductCreationFloodCheckLimit => (int)this["DeveloperProductCreationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan DeveloperProductCreationFloodCheckExpiry => (TimeSpan)this["DeveloperProductCreationFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ItemImpressionLimit => (int)this["ItemImpressionLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ItemImpressionFloodCheckExpiry => (TimeSpan)this["ItemImpressionFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ItemImpressionFloodCheckEnabled => (bool)this["ItemImpressionFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AdImpressionUserAndUniverseFloodCheckLimit => (int)this["AdImpressionUserAndUniverseFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AdImpressionFloodCheckExpiry => (TimeSpan)this["AdImpressionFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int AdImpressionUserFloodCheck => (int)this["AdImpressionUserFloodCheck"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MobileAppAccountCreationFloodCheckLimit => (int)this["MobileAppAccountCreationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MobileAppAccountCreationFloodCheckTimeLimitInHours => (int)this["MobileAppAccountCreationFloodCheckTimeLimitInHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int UserCommentPerAssetFloodCheckerLimit => (int)this["UserCommentPerAssetFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:15")]
	public TimeSpan UserCommentPerAssetFloodCheckerExpiry => (TimeSpan)this["UserCommentPerAssetFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UserCommentPerAssetFloodCheckerEnabled => (bool)this["UserCommentPerAssetFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int UserCommentFloodCheckerLimit => (int)this["UserCommentFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan UserCommentFloodCheckerExpiry => (TimeSpan)this["UserCommentFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UserCommentFloodCheckerEnabled => (bool)this["UserCommentFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("120")]
	public int GuestPlaceJoinRequestFloodCheckLimit => (int)this["GuestPlaceJoinRequestFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan GuestPlaceJoinRequestFloodCheckExpiry => (TimeSpan)this["GuestPlaceJoinRequestFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int TeleportPlaceJoinRequestFloodCheckLimit => (int)this["TeleportPlaceJoinRequestFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan TeleportPlaceJoinRequestFloodCheckExpiry => (TimeSpan)this["TeleportPlaceJoinRequestFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int BrowserTrackerCreationFloodCheckLimit => (int)this["BrowserTrackerCreationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan BrowserTrackerCreationFloodCheckExpiry => (TimeSpan)this["BrowserTrackerCreationFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int FailedCredentialsFloodCheckLimit => (int)this["FailedCredentialsFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan FailedCredentialsFloodCheckExpiry => (TimeSpan)this["FailedCredentialsFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int ShowPrerollFloodCheckLimit => (int)this["ShowPrerollFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan ShowPrerollFloodCheckExpiry => (TimeSpan)this["ShowPrerollFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int CatalogImpressionLimit => (int)this["CatalogImpressionLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan CatalogImpressionFloodCheckExpiry => (TimeSpan)this["CatalogImpressionFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CatalogImpressionFloodCheckEnabled => (bool)this["CatalogImpressionFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AbEnrollApiFloodCheckLimit => (int)this["AbEnrollApiFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan AbEnrollApiFloodCheckExpiry => (TimeSpan)this["AbEnrollApiFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int AbGetEnrollmentApiFloodCheckLimit => (int)this["AbGetEnrollmentApiFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan AbGetEnrollmentApiFloodCheckExpiry => (TimeSpan)this["AbGetEnrollmentApiFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LoginFloodCheckOnMultipleUsernames => (bool)this["LoginFloodCheckOnMultipleUsernames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int LegacyAssetUploadFloodCheckLimit => (int)this["LegacyAssetUploadFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan LegacyAssetUploadFloodCheckExipry => (TimeSpan)this["LegacyAssetUploadFloodCheckExipry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int XboxLiveAccountCreationLimit => (int)this["XboxLiveAccountCreationLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan XboxLiveAccountCreationExpiry => (TimeSpan)this["XboxLiveAccountCreationExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int PasswordResetUserIdFloodCheckerLimit => (int)this["PasswordResetUserIdFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan PasswordResetUserIdFloodCheckerExpiry => (TimeSpan)this["PasswordResetUserIdFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TradeCurrencySubmissionFloodCheckerLimit => (int)this["TradeCurrencySubmissionFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan TradeCurrencySubmissionFloodCheckerExpiry => (TimeSpan)this["TradeCurrencySubmissionFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int TradeCurrencyPageLoadFloodCheckerLimit => (int)this["TradeCurrencyPageLoadFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan TradeCurrencyPageLoadFloodCheckerExpiry => (TimeSpan)this["TradeCurrencyPageLoadFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TradeCurrencyFloodCheckerEnabled => (bool)this["TradeCurrencyFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int MobileDFPAdsFloodCheckLimit => (int)this["MobileDFPAdsFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan MobileDFPAdsFloodCheckExpiry => (TimeSpan)this["MobileDFPAdsFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("120")]
	public int RequestCommentsByUserFloodCheckLimit => (int)this["RequestCommentsByUserFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan RequestCommentsByUserFloodCheckExpiry => (TimeSpan)this["RequestCommentsByUserFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("300")]
	public int RequestCommentsByIpFloodCheckLimit => (int)this["RequestCommentsByIpFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan RequestCommentsByIpFloodCheckExpiry => (TimeSpan)this["RequestCommentsByIpFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetSaleCounterFloodCheckerEnabled => (bool)this["AssetSaleCounterFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AssetSaleCounterFloodCheckerExpiry => (TimeSpan)this["AssetSaleCounterFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int AssetSaleCounterFloodCheckerLimit => (int)this["AssetSaleCounterFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int AddCloudEditorFloodCheckerLimit => (int)this["AddCloudEditorFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("168.00:00:00")]
	public TimeSpan AddCloudEditorFloodCheckerExpiry => (TimeSpan)this["AddCloudEditorFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int ClientStatusSetFloodCheckerLimit => (int)this["ClientStatusSetFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan ClientStatusSetFloodCheckerExpiry => (TimeSpan)this["ClientStatusSetFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int DeviceHandleLoginFloodCheckerLimit => (int)this["DeviceHandleLoginFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandleLoginFloodCheckerExpiry => (TimeSpan)this["DeviceHandleLoginFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int DeviceHandleSuccessfulLoginFloodCheckerLimit => (int)this["DeviceHandleSuccessfulLoginFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandleSuccessfulLoginFloodCheckerExpiry => (TimeSpan)this["DeviceHandleSuccessfulLoginFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public int GeneratedThumbnailUploadFloodCheckLimit => (int)this["GeneratedThumbnailUploadFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan GeneratedThumbnailUploadFloodCheckExpiry => (TimeSpan)this["GeneratedThumbnailUploadFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ImageUploadAccountAgeOneYearExpiry => (TimeSpan)this["ImageUploadAccountAgeOneYearExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ImageUploadAccountAgeOneYearLimit => (int)this["ImageUploadAccountAgeOneYearLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ImageUploadAccountAgeTwoYearsExpiry => (TimeSpan)this["ImageUploadAccountAgeTwoYearsExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ImageUploadAccountAgeTwoYearsLimit => (int)this["ImageUploadAccountAgeTwoYearsLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ImageUploadFloodchecksByAccountAgeEnabled => (bool)this["ImageUploadFloodchecksByAccountAgeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GiftCardRedemptionFailureFloodCheckLimit => (int)this["GiftCardRedemptionFailureFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int GiftCardRedemptionSuccessFloodCheckLimit => (int)this["GiftCardRedemptionSuccessFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan GiftCardRedemptionFailureFloodCheckExpiry => (TimeSpan)this["GiftCardRedemptionFailureFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan GiftCardRedemptionSuccessFloodCheckExpiry => (TimeSpan)this["GiftCardRedemptionSuccessFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public int GeneratedIconUploadFloodCheckLimit => (int)this["GeneratedIconUploadFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.00:00:00")]
	public TimeSpan GeneratedIconUploadFloodCheckExpiry => (TimeSpan)this["GeneratedIconUploadFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AccountCreationLimitForSuspiciousIps => (int)this["AccountCreationLimitForSuspiciousIps"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AccountCreationExpiryForSuspiciousIps => (TimeSpan)this["AccountCreationExpiryForSuspiciousIps"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int CatalogQueryFloodCheckerLimit => (int)this["CatalogQueryFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan CatalogQueryFloodCheckerExpiry => (TimeSpan)this["CatalogQueryFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan SendMessageFloodCheckerExpiryByIp => (TimeSpan)this["SendMessageFloodCheckerExpiryByIp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int SendMessageFloodCheckerLimitByIp => (int)this["SendMessageFloodCheckerLimitByIp"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableCookieSizeEventFloodChecker => (bool)this["EnableCookieSizeEventFloodChecker"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool EnableCookieSizeSampleEventFloodChecker => (bool)this["EnableCookieSizeSampleEventFloodChecker"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int RixtyFailedFloodCheckLimit => (int)this["RixtyFailedFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan RixtyFailedFloodCheckExpiry => (TimeSpan)this["RixtyFailedFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsRixtyFloodCheckEnabled => (bool)this["IsRixtyFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int RedeemPromoCodeFloodCheckLimit => (int)this["RedeemPromoCodeFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan RedeemPromoCodeFloodCheckExpiry => (TimeSpan)this["RedeemPromoCodeFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RedeemPromoCodeFloodCheckEnabled => (bool)this["RedeemPromoCodeFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int PlayerQueryFloodCheckerLimit => (int)this["PlayerQueryFloodCheckerLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan PlayerQueryFloodCheckerExpiry => (TimeSpan)this["PlayerQueryFloodCheckerExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPlayerQueryFloodCheckerEnabled => (bool)this["IsPlayerQueryFloodCheckerEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int DeviceHandleUserActionFloodCheckLimit => (int)this["DeviceHandleUserActionFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandleUserActionFloodCheckExpiry => (TimeSpan)this["DeviceHandleUserActionFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleUserActionFloodCheckEnabled => (bool)this["DeviceHandleUserActionFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int UIPerformanceTrackingByIPFloodCheckLimit => (int)this["UIPerformanceTrackingByIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:00")]
	public TimeSpan UIPerformanceTrackingByIPFloodCheckExpiry => (TimeSpan)this["UIPerformanceTrackingByIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int DeviceHandleAddFriendFloodCheckLimit => (int)this["DeviceHandleAddFriendFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandleAddFriendFloodCheckExpiry => (TimeSpan)this["DeviceHandleAddFriendFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleAddFriendFloodCheckEnabled => (bool)this["DeviceHandleAddFriendFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int DeviceHandleSendMessageFloodCheckLimit => (int)this["DeviceHandleSendMessageFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandleSendMessageFloodCheckExpiry => (TimeSpan)this["DeviceHandleSendMessageFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleSendMessageFloodCheckEnabled => (bool)this["DeviceHandleSendMessageFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int DeviceHandlePostCommentFloodCheckLimit => (int)this["DeviceHandlePostCommentFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandlePostCommentFloodCheckExpiry => (TimeSpan)this["DeviceHandlePostCommentFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DeviceHandlePostCommentFloodCheckEnabled => (bool)this["DeviceHandlePostCommentFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int DeviceHandleGroupJoinFloodCheckLimit => (int)this["DeviceHandleGroupJoinFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan DeviceHandleGroupJoinFloodCheckExpiry => (TimeSpan)this["DeviceHandleGroupJoinFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleGroupJoinFloodCheckEnabled => (bool)this["DeviceHandleGroupJoinFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int DeviceHandleFollowFloodCheckLimit => (int)this["DeviceHandleFollowFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:00")]
	public TimeSpan DeviceHandleFollowFloodCheckExpiry => (TimeSpan)this["DeviceHandleFollowFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool DeviceHandleFollowFloodCheckEnabled => (bool)this["DeviceHandleFollowFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int UserPlaceJoinRequestFloodCheckLimit => (int)this["UserPlaceJoinRequestFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:10:00")]
	public TimeSpan UserPlaceJoinRequestFloodCheckExpiry => (TimeSpan)this["UserPlaceJoinRequestFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UserPlaceJoinRequestFloodCheckEnabled => (bool)this["UserPlaceJoinRequestFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int FreeThumbnailImageUploadFloodCheckLimit => (int)this["FreeThumbnailImageUploadFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan FreeThumbnailImageUploadFloodCheckExpiry => (TimeSpan)this["FreeThumbnailImageUploadFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int InCommFailedUserIdFloodCheckLimit => (int)this["InCommFailedUserIdFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan InCommFailedUserIdFloodCheckExpiry => (TimeSpan)this["InCommFailedUserIdFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommFailedUserIdFloodCheckEnabled => (bool)this["InCommFailedUserIdFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int InCommFailedIPFloodCheckLimit => (int)this["InCommFailedIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan InCommFailedIPFloodCheckExpiry => (TimeSpan)this["InCommFailedIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommFailedIPFloodCheckEnabled => (bool)this["InCommFailedIPFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int InCommFailedPartialIPFloodCheckLimit => (int)this["InCommFailedPartialIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan InCommFailedPartialIPFloodCheckExpiry => (TimeSpan)this["InCommFailedPartialIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommFailedPartialIPFloodCheckEnabled => (bool)this["InCommFailedPartialIPFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int InCommSamePinFloodCheckLimit => (int)this["InCommSamePinFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan InCommSamePinFloodCheckExpiry => (TimeSpan)this["InCommSamePinFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommSamePinFloodCheckEnabled => (bool)this["InCommSamePinFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int InCommCaptchaAttemptUserIdFloodCheckLimit => (int)this["InCommCaptchaAttemptUserIdFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan InCommCaptchaAttemptUserIdFloodCheckExpiry => (TimeSpan)this["InCommCaptchaAttemptUserIdFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommCaptchaAttemptUserIdFloodCheckEnabled => (bool)this["InCommCaptchaAttemptUserIdFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public int InCommCaptchaAttemptIPFloodCheckLimit => (int)this["InCommCaptchaAttemptIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan InCommCaptchaAttemptIPFloodCheckExpiry => (TimeSpan)this["InCommCaptchaAttemptIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InCommCaptchaAttemptIPFloodCheckEnabled => (bool)this["InCommCaptchaAttemptIPFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ItemValidatePurchaseLimit => (int)this["ItemValidatePurchaseLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan ItemValidatePurchaseFloodCheckExpiry => (TimeSpan)this["ItemValidatePurchaseFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ItemValidatePurchaseFloodCheckEnabled => (bool)this["ItemValidatePurchaseFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int FreeItemValidatePurchaseLimit => (int)this["FreeItemValidatePurchaseLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan FreeItemValidatePurchaseFloodCheckExpiry => (TimeSpan)this["FreeItemValidatePurchaseFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FreeItemValidatePurchaseFloodCheckEnabled => (bool)this["FreeItemValidatePurchaseFloodCheckEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000000")]
	public int VoteIPFloodCheckLimit => (int)this["VoteIPFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan VoteIPFloodCheckExpiry => (TimeSpan)this["VoteIPFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int VoteAssetIdAndValueFloodCheckLimit => (int)this["VoteAssetIdAndValueFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan VoteAssetIdAndValueFloodCheckExpiry => (TimeSpan)this["VoteAssetIdAndValueFloodCheckExpiry"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsVoteTargetIdAndValueFloodCheckEnabled => (bool)this["IsVoteTargetIdAndValueFloodCheckEnabled"];

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
