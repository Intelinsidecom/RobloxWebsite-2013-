using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Settings : ApplicationSettingsBase, IServerClassLibrarySettings
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50000000")]
	public int MaxFileSize => (int)this["MaxFileSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int UserGroupJoinLimit => (int)this["UserGroupJoinLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int CostToCreateGroupInRobux => (int)this["CostToCreateGroupInRobux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int BCUserGroupJoinLimit => (int)this["BCUserGroupJoinLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool FacebookEnabled => (bool)this["FacebookEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool BCOnlyGroupBuilding => (bool)this["BCOnlyGroupBuilding"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupBuildingEnabled => (bool)this["GroupBuildingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int BCReferralRewardinRobux => (int)this["BCReferralRewardinRobux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BuildToolAssetList => (string)this["BuildToolAssetList"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string BuildingWithFriendsStartingEnvironmentAssetIDs => (string)this["BuildingWithFriendsStartingEnvironmentAssetIDs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int TBCUserGroupJoinLimit => (int)this["TBCUserGroupJoinLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public float TBCtoBCDurationConversionFactor => (float)this["TBCtoBCDurationConversionFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool BCReferralRewardsEnabled => (bool)this["BCReferralRewardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool FriendReferralRewardsEnabled => (bool)this["FriendReferralRewardsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int PercentEmailRequired => (int)this["PercentEmailRequired"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yay")]
	public string BCReferralRewardDescription => (string)this["BCReferralRewardDescription"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumNumberOfGroupRoleSets => (int)this["MaximumNumberOfGroupRoleSets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int CostToCreateRoleSetInRobux => (int)this["CostToCreateRoleSetInRobux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool BuildInstanceInfoOnGroupPage => (bool)this["BuildInstanceInfoOnGroupPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int OBCUserGroupJoinLimit => (int)this["OBCUserGroupJoinLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.5")]
	public float OBCtoTBCDurationConversionFactor => (float)this["OBCtoTBCDurationConversionFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public float OBCtoBCDurationConversionFactor => (float)this["OBCtoBCDurationConversionFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int UploadedPlaceParsingFrequency => (int)this["UploadedPlaceParsingFrequency"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ScriptAuthorsAreTentative => (bool)this["ScriptAuthorsAreTentative"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsBubbleChatEnabled => (bool)this["IsBubbleChatEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaximumNumberOfItemsPerAssetSet => (int)this["MaximumNumberOfItemsPerAssetSet"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumNumberOfAssetSetsPerOwner => (int)this["MaximumNumberOfAssetSetsPerOwner"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ParseScriptsFromReportedPlacesOn => (bool)this["ParseScriptsFromReportedPlacesOn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.1")]
	public float ROBLOXP2PAutoOfferThreshold => (float)this["ROBLOXP2PAutoOfferThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GameGenresListEnabled => (bool)this["GameGenresListEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public double ExpirationWindowInDays => (double)this["ExpirationWindowInDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("15")]
	public int CommentPostingIntervalInSeconds => (int)this["CommentPostingIntervalInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GameGenreSEOenabled => (bool)this["GameGenreSEOenabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RobloxSets => (string)this["RobloxSets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameGenreSEOIconPathEditingEnabled => (bool)this["GameGenreSEOIconPathEditingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CommentPostingFloodCheckingOn => (bool)this["CommentPostingFloodCheckingOn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public long MyModelsSetDefaultImageAssetID => (long)this["MyModelsSetDefaultImageAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public long MyDecalsSetDefaultImageAssetID => (long)this["MyDecalsSetDefaultImageAssetID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SetsEnabled => (bool)this["SetsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public float MinAssetHashSafetyRatingToDisplay => (float)this["MinAssetHashSafetyRatingToDisplay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	public float AssetHashSafetyDefaultRating => (float)this["AssetHashSafetyDefaultRating"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("864000000000")]
	public long AssetHashSafetyRatingRecalculationIntervalInTicks => (long)this["AssetHashSafetyRatingRecalculationIntervalInTicks"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int MaximumNumberOfAssetSetSubscriptions => (int)this["MaximumNumberOfAssetSetSubscriptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool InteractionTrackingIsEnabled => (bool)this["InteractionTrackingIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CommentsPostingEnabled => (bool)this["CommentsPostingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int CommentsResultsPerPage => (int)this["CommentsResultsPerPage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/content")]
	public string TemporaryStoreDirectory => (string)this["TemporaryStoreDirectory"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100000")]
	public int AssetOwnershipCountThreshold => (int)this["AssetOwnershipCountThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseUnreadMessagesCounter => (bool)this["UseUnreadMessagesCounter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double UnreadMessagesCounterVerificationPercentage => (double)this["UnreadMessagesCounterVerificationPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public string SignScriptsOnFetch => (string)this["SignScriptsOnFetch"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public double CommentsCounterVerificationPercentage => (double)this["CommentsCounterVerificationPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseCommentsCounter => (bool)this["UseCommentsCounter"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("76D50904-6780-4c8b-8986-1A7EE0B1716D")]
	public string CLSID32Bit => (string)this["CLSID32Bit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public byte DefaultFollowPrivacySetting => (byte)this["DefaultFollowPrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AsyncGoogleOn => (bool)this["AsyncGoogleOn"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool GlobalCommentaryIsEnabled => (bool)this["GlobalCommentaryIsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("25")]
	public int LoginFloodCheckLimitPerHour => (int)this["LoginFloodCheckLimitPerHour"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BCOnlyPlacesEnabled => (bool)this["BCOnlyPlacesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowAllAdsWithGAM => (bool)this["ShowAllAdsWithGAM"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public float RobuxStipendBonusMaxMultiplier => (float)this["RobuxStipendBonusMaxMultiplier"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("760")]
	public int RobuxStipendBonusMaxDays => (int)this["RobuxStipendBonusMaxDays"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool BCExpireNagScreenOff => (bool)this["BCExpireNagScreenOff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FacebookLikeOff => (bool)this["FacebookLikeOff"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("190191627665278")]
	public string FacebookNewApplicationID => (string)this["FacebookNewApplicationID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("a8ca3b387edee0d6e995241fe8323de1")]
	public string FacebookNewApplicationSeceret => (string)this["FacebookNewApplicationSeceret"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("e58f2110adf82c2c00e6ae41c665510c")]
	public string FacebookNewAPIKey => (string)this["FacebookNewAPIKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AlliesEnemiesEnabled => (bool)this["AlliesEnemiesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int BoyGuestCharacterID => (int)this["BoyGuestCharacterID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int GirlGuestCharacterID => (int)this["GirlGuestCharacterID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int DefaultGuestCharacterID => (int)this["DefaultGuestCharacterID"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsTestingSite => (bool)this["IsTestingSite"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AttachChildAccountFloodCheckLimitPerDay => (int)this["AttachChildAccountFloodCheckLimitPerDay"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int AttachChildAccountFloodCheckTimeLimit => (int)this["AttachChildAccountFloodCheckTimeLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GiftCardEmailDeliveryEnabled => (bool)this["GiftCardEmailDeliveryEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public int NewsletterUnsubscribeFloodCheckLimit => (int)this["NewsletterUnsubscribeFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("12")]
	public int NewsletterUnsubscribeFloodCheckExpiryHours => (int)this["NewsletterUnsubscribeFloodCheckExpiryHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("JGKNtP69jU5LO25x92hWI!nRzQl")]
	public string UnsubscribeNewsletterKey => (string)this["UnsubscribeNewsletterKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string JavaScriptS3Bucket => (string)this["JavaScriptS3Bucket"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CssS3Bucket => (string)this["CssS3Bucket"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ImagesS3Bucket => (string)this["ImagesS3Bucket"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAkamaiEnabledForStatic => (bool)this["IsAkamaiEnabledForStatic"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int AccountCreationFloodCheckTimeLimitInHours => (int)this["AccountCreationFloodCheckTimeLimitInHours"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public int AccountCreationFloodCheckLimit => (int)this["AccountCreationFloodCheckLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string JavaScriptGZipS3Bucket => (string)this["JavaScriptGZipS3Bucket"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CssGZipS3Bucket => (string)this["CssGZipS3Bucket"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public DateTime RobuxStipendBonusTerminationDate => (DateTime)this["RobuxStipendBonusTerminationDate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.1")]
	public float AssetSaleCommissionRate => (float)this["AssetSaleCommissionRate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBadges => (string)this["RobloxBadges"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPremiumFeaturesTest => (string)this["RobloxPremiumFeaturesTest"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string AccountManagementConnectionStringForTesting => (string)this["AccountManagementConnectionStringForTesting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxSearchLog => (string)this["RobloxSearchLog"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableItemHolds => (bool)this["EnableItemHolds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string HoldEnabledAssetTypes => (string)this["HoldEnabledAssetTypes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30000")]
	public double MinHoldPrice => (double)this["MinHoldPrice"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AffiliateSalesEnabled => (bool)this["AffiliateSalesEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:05:00")]
	public TimeSpan PresenceCacheDuration => (TimeSpan)this["PresenceCacheDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int FloodcheckPerHourUserAssetScrubLimit => (int)this["FloodcheckPerHourUserAssetScrubLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RegisterVisitorAbsence => (bool)this["RegisterVisitorAbsence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public long SolrMarketingBoostScaleUpFactor => (long)this["SolrMarketingBoostScaleUpFactor"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SolrMarketingBoostDefaultScale => (int)this["SolrMarketingBoostDefaultScale"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:00")]
	public TimeSpan SolrMarketingBoostDefaultTimeSpan => (TimeSpan)this["SolrMarketingBoostDefaultTimeSpan"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SolrMarketingBoostMinimumScale => (int)this["SolrMarketingBoostMinimumScale"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SolrMarketingBoostMaximumScale => (int)this["SolrMarketingBoostMaximumScale"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SendLimitedEditionLowestPriceToSolr => (bool)this["SendLimitedEditionLowestPriceToSolr"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LazyUpdateForUserItemsMinPriceEnabled => (bool)this["LazyUpdateForUserItemsMinPriceEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public byte ExpiredBCActiveSlots => (byte)this["ExpiredBCActiveSlots"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ExpiredBCActiveSlotsEnabled => (bool)this["ExpiredBCActiveSlotsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GameSearchAndBanEnabled => (bool)this["GameSearchAndBanEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	public byte DefaultUnder13MessagePrivacySetting => (byte)this["DefaultUnder13MessagePrivacySetting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.9")]
	public float AssetSaleCommissionRateNonBC => (float)this["AssetSaleCommissionRateNonBC"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AudioAssetUploadEnabled => (bool)this["AudioAssetUploadEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string IOSCatalogItemsCSV => (string)this["IOSCatalogItemsCSV"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UnreadMessagesCounterAutoSyncThreshold => (int)this["UnreadMessagesCounterAutoSyncThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetEndorsementsEnabled => (bool)this["AssetEndorsementsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool NotifyEndorsedAssetCreators => (bool)this["NotifyEndorsedAssetCreators"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int EndorsementRewardInRobux => (int)this["EndorsementRewardInRobux"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsUserEntityDebugInfoLoggingEnabled => (bool)this["IsUserEntityDebugInfoLoggingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FileManagerPublisherAwsAccessKeyAndAwsSecretAccessKey => (string)this["FileManagerPublisherAwsAccessKeyAndAwsSecretAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FileManagerAmazonSqsUrl => (string)this["FileManagerAmazonSqsUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ReadWriteIpAddressOnlyAsStringPercentage => (int)this["ReadWriteIpAddressOnlyAsStringPercentage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30000")]
	public int AccountAddOnActivationLeaseDurationInMilliseconds => (int)this["AccountAddOnActivationLeaseDurationInMilliseconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserAssetShimClientApiKey => (string)this["UserAssetShimClientApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseSparsePairTestForGroupRoleSetsEnabled => (bool)this["UseSparsePairTestForGroupRoleSetsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RenewalCalculationStartDateEqualOrLargerThanCurrentTimeEnabled => (bool)this["RenewalCalculationStartDateEqualOrLargerThanCurrentTimeEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RemoteCacheForAccountLookupByNameEnabled => (bool)this["RemoteCacheForAccountLookupByNameEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool RemoteCacheForUserByAccountIdLookupEnabled => (bool)this["RemoteCacheForUserByAccountIdLookupEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string StaticFilesAwsBucketAccessKey => (string)this["StaticFilesAwsBucketAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string StaticFilesAwsBucketSecretAccessKey => (string)this["StaticFilesAwsBucketSecretAccessKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Roblox")]
	public string LogSource => (string)this["LogSource"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Information")]
	public string LogLevel => (string)this["LogLevel"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetOptionRemoteCached => (bool)this["IsAssetOptionRemoteCached"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsIncreasedActiveUniverseLimitEnabled => (bool)this["IsIncreasedActiveUniverseLimitEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int MaxActiveUniversesCount => (int)this["MaxActiveUniversesCount"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GroupWallPostCountCacheEnabled => (bool)this["GroupWallPostCountCacheEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("2000")]
	public int GroupWallPostCountCacheThreshold => (int)this["GroupWallPostCountCacheThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan GroupWallPostCountCacheExpiration => (TimeSpan)this["GroupWallPostCountCacheExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GroupsClientApiKey => (string)this["GroupsClientApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountAddonSmartMultigetEnabled => (bool)this["IsAccountAddonSmartMultigetEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("01:00:00")]
	public TimeSpan AccountAddOnCacheExpiration => (TimeSpan)this["AccountAddOnCacheExpiration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("200")]
	public int AccountAddOnMaxCacheSize => (int)this["AccountAddOnMaxCacheSize"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAccountAddonsByAccountIDRemoteCacheEnabled => (bool)this["IsAccountAddonsByAccountIDRemoteCacheEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AccountPasswordHashesV2ReadingEnabled => (bool)this["AccountPasswordHashesV2ReadingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsAssetReleaseDateCheckingEnabled => (bool)this["IsAssetReleaseDateCheckingEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AssetHashSetApprovalOnlyIfDifferentEnabled => (bool)this["AssetHashSetApprovalOnlyIfDifferentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("/content")]
	public string TemporaryStoreDirectoryOnChi1 => (string)this["TemporaryStoreDirectoryOnChi1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ReadFromTemporaryStoreDirectoryOnChi1 => (bool)this["ReadFromTemporaryStoreDirectoryOnChi1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WriteToTemporaryStoreDirectoryOnChi1 => (bool)this["WriteToTemporaryStoreDirectoryOnChi1"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool StopWritingToTemporaryStoreDirectoryOnPrime => (bool)this["StopWritingToTemporaryStoreDirectoryOnPrime"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:30")]
	public TimeSpan PurchaseGamePassLeasedLockDuration => (TimeSpan)this["PurchaseGamePassLeasedLockDuration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPurchaseGamePassLeasedLockEnabled => (bool)this["IsPurchaseGamePassLeasedLockEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:01:00")]
	public TimeSpan AccountRoleSetSummariesRefreshAheadInterval => (TimeSpan)this["AccountRoleSetSummariesRefreshAheadInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsEmailVerificationUsingASTEnabled => (bool)this["IsEmailVerificationUsingASTEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsFallbackToOldEmailVerificationEnabled => (bool)this["IsFallbackToOldEmailVerificationEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool CondenseFileLocationSaveEnabled => (bool)this["CondenseFileLocationSaveEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool IsBCOnlyRequirementEnabled => (bool)this["IsBCOnlyRequirementEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ExecuteTempStoreDeletionRequestsOnTimer => (bool)this["ExecuteTempStoreDeletionRequestsOnTimer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLookupbyAssetArchivedEnabled => (bool)this["IsLookupbyAssetArchivedEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool SkipRoleSetUpdateIfNoRoleSetUpdated => (bool)this["SkipRoleSetUpdateIfNoRoleSetUpdated"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsPremiumFeatureApplicationIntentEnabled => (bool)this["IsPremiumFeatureApplicationIntentEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("30")]
	public int AccountAddOnCommandTimeoutInSeconds => (int)this["AccountAddOnCommandTimeoutInSeconds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableRemoteCacheForIPAddress => (bool)this["EnableRemoteCacheForIPAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool EnableReadFromRemoteCacheForIPAddress => (bool)this["EnableReadFromRemoteCacheForIPAddress"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsMultiGetGroupRoleSetsEnabled => (bool)this["IsMultiGetGroupRoleSetsEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool LogAccountRoleSetInfoWhenNoChangeDetected => (bool)this["LogAccountRoleSetInfoWhenNoChangeDetected"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.7")]
	public float NewUgcMarketplaceFeeRate => (float)this["NewUgcMarketplaceFeeRate"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsNewUgcMarketplaceFeeRateEnabled => (bool)this["IsNewUgcMarketplaceFeeRateEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AddTempFileLocationIfS3UploadFails => (bool)this["AddTempFileLocationIfS3UploadFails"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AddTempFileLocationIfS3VerificationFails => (bool)this["AddTempFileLocationIfS3VerificationFails"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AttemptToFixNoneFileLocations => (bool)this["AttemptToFixNoneFileLocations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RolesClientMasterApiKey => (string)this["RolesClientMasterApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:00:05")]
	public TimeSpan LoadAccountRoleSetsRefreshInterval => (TimeSpan)this["LoadAccountRoleSetsRefreshInterval"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int MaxActiveUniversesCountForGroups => (int)this["MaxActiveUniversesCountForGroups"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PasswordsClientMasterApiKey => (string)this["PasswordsClientMasterApiKey"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AccountPasswordHashesV2ReadingEnabledFlagV2 => (bool)this["AccountPasswordHashesV2ReadingEnabledFlagV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public int BCUserGroupCreateLimit => (int)this["BCUserGroupCreateLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int OBCUserGroupCreateLimit => (int)this["OBCUserGroupCreateLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int TBCUserGroupCreateLimit => (int)this["TBCUserGroupCreateLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int UserGroupCreateLimit => (int)this["UserGroupCreateLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int PremiumUserGroupJoinLimit => (int)this["PremiumUserGroupJoinLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int PremiumUserGroupCreateLimit => (int)this["PremiumUserGroupCreateLimit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TrackUserReadsRequestsPerSecond => (bool)this["TrackUserReadsRequestsPerSecond"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00:30:00")]
	public TimeSpan TempFileLocationAgeThreshold => (TimeSpan)this["TempFileLocationAgeThreshold"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TempFileLocationFixEnabled => (bool)this["TempFileLocationFixEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccountReadByNameViaUsersServiceEnabledPermyriad => (int)this["AccountReadByNameViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccountReadByIdViaUsersServiceEnabledPermyriad => (int)this["AccountReadByIdViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int AccountReadByMultiGetViaUsersServiceEnabledPermyriad => (int)this["AccountReadByMultiGetViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserReadByIdViaUsersServiceEnabledPermyriad => (int)this["UserReadByIdViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserReadByMultiGetViaUsersServiceEnabledPermyriad => (int)this["UserReadByMultiGetViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserReadByNameViaUsersServiceEnabledPermyriad => (int)this["UserReadByNameViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int UserReadByAccountIdViaUsersServiceEnabledPermyriad => (int)this["UserReadByAccountIdViaUsersServiceEnabledPermyriad"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool GetUserByGroupAgentIdReturnsNullEnabled => (bool)this["GetUserByGroupAgentIdReturnsNullEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("64")]
	public int DatabaseMaxUsernameLength => (int)this["DatabaseMaxUsernameLength"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UserGetAccountCacheEnabled => (bool)this["UserGetAccountCacheEnabled"];

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
