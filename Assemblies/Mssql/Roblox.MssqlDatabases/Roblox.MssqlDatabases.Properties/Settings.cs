using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.MssqlDatabases.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => ((ApplicationSettingsBase)this)[propName]);
		}
		set
		{
			((ApplicationSettingsBase)this)[propertyName] = value;
		}
	}

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAds => (string)((SettingsBase)this)["RobloxAds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAggregation => (string)((SettingsBase)this)["RobloxAggregation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetCounters => (string)((SettingsBase)this)["RobloxAssetCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetCreations => (string)((SettingsBase)this)["RobloxAssetCreations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetHashes => (string)((SettingsBase)this)["RobloxAssetHashes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetMedia => (string)((SettingsBase)this)["RobloxAssetMedia"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssets => (string)((SettingsBase)this)["RobloxAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetSales => (string)((SettingsBase)this)["RobloxAssetSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetSecurity => (string)((SettingsBase)this)["RobloxAssetSecurity"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetSets => (string)((SettingsBase)this)["RobloxAssetSets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetStatistics => (string)((SettingsBase)this)["RobloxAssetStatistics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetStatisticsAggregation => (string)((SettingsBase)this)["RobloxAssetStatisticsAggregation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAvatars => (string)((SettingsBase)this)["RobloxAvatars"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBilling => (string)((SettingsBase)this)["RobloxBilling"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxChat => (string)((SettingsBase)this)["RobloxChat"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxClientSettings => (string)((SettingsBase)this)["RobloxClientSettings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxContent => (string)((SettingsBase)this)["RobloxContent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxContentRatings => (string)((SettingsBase)this)["RobloxContentRatings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxContests => (string)((SettingsBase)this)["RobloxContests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxCurrency => (string)((SettingsBase)this)["RobloxCurrency"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxDemographics => (string)((SettingsBase)this)["RobloxDemographics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxDeployments => (string)((SettingsBase)this)["RobloxDeployments"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxDeveloperProducts => (string)((SettingsBase)this)["RobloxDeveloperProducts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxDistribution => (string)((SettingsBase)this)["RobloxDistribution"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxEconomy => (string)((SettingsBase)this)["RobloxEconomy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxEphemeralCounters => (string)((SettingsBase)this)["RobloxEphemeralCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFeeds => (string)((SettingsBase)this)["RobloxFeeds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFiles => (string)((SettingsBase)this)["RobloxFiles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGameCounters => (string)((SettingsBase)this)["RobloxGameCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGamePasses => (string)((SettingsBase)this)["RobloxGamePasses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGamePersistence => (string)((SettingsBase)this)["RobloxGamePersistence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGames => (string)((SettingsBase)this)["RobloxGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGameService => (string)((SettingsBase)this)["RobloxGameService"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGamesRecentlyVisited => (string)((SettingsBase)this)["RobloxGamesRecentlyVisited"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGroups => (string)((SettingsBase)this)["RobloxGroups"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxInfrastructure => (string)((SettingsBase)this)["RobloxInfrastructure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxInfrastructureAudit => (string)((SettingsBase)this)["RobloxInfrastructureAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxInteractionCounters => (string)((SettingsBase)this)["RobloxInteractionCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxLatencyMeasurements => (string)((SettingsBase)this)["RobloxLatencyMeasurements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMaintenance => (string)((SettingsBase)this)["RobloxMaintenance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMarketing => (string)((SettingsBase)this)["RobloxMarketing"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMetrics => (string)((SettingsBase)this)["RobloxMetrics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMetricsClient => (string)((SettingsBase)this)["RobloxMetricsClient"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMetricsSandbox => (string)((SettingsBase)this)["RobloxMetricsSandbox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxModeration => (string)((SettingsBase)this)["RobloxModeration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxModerationNew => (string)((SettingsBase)this)["RobloxModerationNew"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxObservation => (string)((SettingsBase)this)["RobloxObservation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPermissions => (string)((SettingsBase)this)["RobloxPermissions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPoints => (string)((SettingsBase)this)["RobloxPoints"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPremiumFeatures => (string)((SettingsBase)this)["RobloxPremiumFeatures"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPresence => (string)((SettingsBase)this)["RobloxPresence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxReporting => (string)((SettingsBase)this)["RobloxReporting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxSegmentation => (string)((SettingsBase)this)["RobloxSegmentation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxServices => (string)((SettingsBase)this)["RobloxServices"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxShops => (string)((SettingsBase)this)["RobloxShops"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxStatistics => (string)((SettingsBase)this)["RobloxStatistics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxStudio => (string)((SettingsBase)this)["RobloxStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxThumbnails => (string)((SettingsBase)this)["RobloxThumbnails"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTimeSeries => (string)((SettingsBase)this)["RobloxTimeSeries"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTrades => (string)((SettingsBase)this)["RobloxTrades"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTransactionHistory => (string)((SettingsBase)this)["RobloxTransactionHistory"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUniverses => (string)((SettingsBase)this)["RobloxUniverses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserAssetEscrows => (string)((SettingsBase)this)["RobloxUserAssetEscrows"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserAssets => (string)((SettingsBase)this)["RobloxUserAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserCounters => (string)((SettingsBase)this)["RobloxUserCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUsers => (string)((SettingsBase)this)["RobloxUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserSettings => (string)((SettingsBase)this)["RobloxUserSettings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxVersions => (string)((SettingsBase)this)["RobloxVersions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxVoting => (string)((SettingsBase)this)["RobloxVoting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxVotingCounters => (string)((SettingsBase)this)["RobloxVotingCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string Roblox => (string)((SettingsBase)this)["Roblox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAuthentication => (string)((SettingsBase)this)["RobloxAuthentication"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxSystemEvents => (string)((SettingsBase)this)["RobloxSystemEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAbTesting => (string)((SettingsBase)this)["RobloxAbTesting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxXbox => (string)((SettingsBase)this)["RobloxXbox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetNamespaces => (string)((SettingsBase)this)["RobloxAssetNamespaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxShowcases => (string)((SettingsBase)this)["RobloxShowcases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxDeviceVoting => (string)((SettingsBase)this)["RobloxDeviceVoting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxCurrencyBudgets => (string)((SettingsBase)this)["RobloxCurrencyBudgets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFilesV2 => (string)((SettingsBase)this)["RobloxFilesV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPushNotifications => (string)((SettingsBase)this)["RobloxPushNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxNotifications => (string)((SettingsBase)this)["RobloxNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGroupRoleSets => (string)((SettingsBase)this)["RobloxGroupRoleSets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGroupPosts => (string)((SettingsBase)this)["RobloxGroupPosts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxIPAddresses => (string)((SettingsBase)this)["RobloxIPAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserPrivacy => (string)((SettingsBase)this)["RobloxUserPrivacy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxClickThroughAgreements => (string)((SettingsBase)this)["RobloxClickThroughAgreements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserStatuses => (string)((SettingsBase)this)["RobloxUserStatuses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxEmailAddresses => (string)((SettingsBase)this)["RobloxEmailAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserRetention => (string)((SettingsBase)this)["RobloxUserRetention"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFriendships => (string)((SettingsBase)this)["RobloxFriendships"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFollowings => (string)((SettingsBase)this)["RobloxFollowings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFriendRequests => (string)((SettingsBase)this)["RobloxFriendRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMacAddresses => (string)((SettingsBase)this)["RobloxMacAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountSecurity => (string)((SettingsBase)this)["RobloxAccountSecurity"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxLocales => (string)((SettingsBase)this)["RobloxLocales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxRoles => (string)((SettingsBase)this)["RobloxRoles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccounts => (string)((SettingsBase)this)["RobloxAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFileLocations => (string)((SettingsBase)this)["RobloxFileLocations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPlaceShowcases => (string)((SettingsBase)this)["RobloxPlaceShowcases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGroupMembership => (string)((SettingsBase)this)["RobloxGroupMembership"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserAssetOptions => (string)((SettingsBase)this)["RobloxUserAssetOptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserAssetExpirations => (string)((SettingsBase)this)["RobloxUserAssetExpirations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGroupCounters => (string)((SettingsBase)this)["RobloxGroupCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxClans => (string)((SettingsBase)this)["RobloxClans"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUsersAudit => (string)((SettingsBase)this)["RobloxUsersAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountPhoneNumbersAudit => (string)((SettingsBase)this)["RobloxAccountPhoneNumbersAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTwoStepVerificationSettingsAudit => (string)((SettingsBase)this)["RobloxTwoStepVerificationSettingsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxCollectibles => (string)((SettingsBase)this)["RobloxCollectibles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGameAttributes => (string)((SettingsBase)this)["RobloxGameAttributes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxItemStatusesAudit => (string)((SettingsBase)this)["RobloxItemStatusesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountPinHashesAudit => (string)((SettingsBase)this)["RobloxAccountPinHashesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBadgesV2 => (string)((SettingsBase)this)["RobloxBadgesV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGroupMembershipRequests => (string)((SettingsBase)this)["RobloxGroupMembershipRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetsAudit => (string)((SettingsBase)this)["RobloxAssetsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxComments => (string)((SettingsBase)this)["RobloxComments"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserFeeds => (string)((SettingsBase)this)["RobloxUserFeeds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBrowserTrackers => (string)((SettingsBase)this)["RobloxBrowserTrackers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGameTemplates => (string)((SettingsBase)this)["RobloxGameTemplates"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMessages => (string)((SettingsBase)this)["RobloxMessages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxRobuxStipends => (string)((SettingsBase)this)["RobloxRobuxStipends"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountLocalization => (string)((SettingsBase)this)["RobloxAccountLocalization"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFavorites => (string)((SettingsBase)this)["RobloxFavorites"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPermissionLists => (string)((SettingsBase)this)["RobloxPermissionLists"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetVersions => (string)((SettingsBase)this)["RobloxAssetVersions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxLocalization => (string)((SettingsBase)this)["RobloxLocalization"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFavoriteCounters => (string)((SettingsBase)this)["RobloxFavoriteCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxDailyLogins => (string)((SettingsBase)this)["RobloxDailyLogins"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTranslation => (string)((SettingsBase)this)["RobloxTranslation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBillingAuditLogs => (string)((SettingsBase)this)["RobloxBillingAuditLogs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBundles => (string)((SettingsBase)this)["RobloxBundles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxEventsIngestValidation => (string)((SettingsBase)this)["RobloxEventsIngestValidation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxModerationReportsAudit => (string)((SettingsBase)this)["RobloxModerationReportsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxContacts => (string)((SettingsBase)this)["RobloxContacts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUserDataProtection => (string)((SettingsBase)this)["RobloxUserDataProtection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountsAudit => (string)((SettingsBase)this)["RobloxAccountsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccoutrements => (string)((SettingsBase)this)["RobloxAccoutrements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxPromotionChannels => (string)((SettingsBase)this)["RobloxPromotionChannels"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMachineLearningModels => (string)((SettingsBase)this)["RobloxMachineLearningModels"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountCountriesAudit => (string)((SettingsBase)this)["RobloxAccountCountriesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTranslationStorage => (string)((SettingsBase)this)["RobloxTranslationStorage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetDetailsQuality => (string)((SettingsBase)this)["RobloxAssetDetailsQuality"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxInGameContentTables => (string)((SettingsBase)this)["RobloxInGameContentTables"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountLocalesAudit => (string)((SettingsBase)this)["RobloxAccountLocalesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTeamOwnership => (string)((SettingsBase)this)["RobloxTeamOwnership"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFriendshipSources => (string)((SettingsBase)this)["RobloxFriendshipSources"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxLeasedLocks => (string)((SettingsBase)this)["RobloxLeasedLocks"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxModerationAutomationAudit => (string)((SettingsBase)this)["RobloxModerationAutomationAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAccountPasswordHashes => (string)((SettingsBase)this)["RobloxAccountPasswordHashes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxXboxLiveAccounts => (string)((SettingsBase)this)["RobloxXboxLiveAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxFacebookAccounts => (string)((SettingsBase)this)["RobloxFacebookAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxStaticContent => (string)((SettingsBase)this)["RobloxStaticContent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxBadges => (string)((SettingsBase)this)["RobloxBadges"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUsernames => (string)((SettingsBase)this)["RobloxUsernames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxThemesV2 => (string)((SettingsBase)this)["RobloxThemesV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGameLocalization => (string)((SettingsBase)this)["RobloxGameLocalization"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxSurveyResponses => (string)((SettingsBase)this)["RobloxSurveyResponses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxRatings => (string)((SettingsBase)this)["RobloxRatings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxRatingsAudit => (string)((SettingsBase)this)["RobloxRatingsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxSurveys => (string)((SettingsBase)this)["RobloxSurveys"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxMatchmaking => (string)((SettingsBase)this)["RobloxMatchmaking"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxIdentities => (string)((SettingsBase)this)["RobloxIdentities"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxChatParticipants => (string)((SettingsBase)this)["RobloxChatParticipants"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxModerationPolicy => (string)((SettingsBase)this)["RobloxModerationPolicy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxRules => (string)((SettingsBase)this)["RobloxRules"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTranslationAudit => (string)((SettingsBase)this)["RobloxTranslationAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxItemTags => (string)((SettingsBase)this)["RobloxItemTags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxCurrencyRobuxHolds => (string)((SettingsBase)this)["RobloxCurrencyRobuxHolds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxCanonicalImages => (string)((SettingsBase)this)["RobloxCanonicalImages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxTranslationAnalyticsReports => (string)((SettingsBase)this)["RobloxTranslationAnalyticsReports"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxGiftCards => (string)((SettingsBase)this)["RobloxGiftCards"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxUGCValidation => (string)((SettingsBase)this)["RobloxUGCValidation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAvatarEmotes => (string)((SettingsBase)this)["RobloxAvatarEmotes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxItemManifolds => (string)((SettingsBase)this)["RobloxItemManifolds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAssetFormats => (string)((SettingsBase)this)["RobloxAssetFormats"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxEngagementPayouts => (string)((SettingsBase)this)["RobloxEngagementPayouts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	public string RobloxAvatarPolicies => (string)((SettingsBase)this)["RobloxAvatarPolicies"];

	internal Settings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
