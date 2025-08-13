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
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAds => (string)((SettingsBase)this)["RobloxAds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAggregation => (string)((SettingsBase)this)["RobloxAggregation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetCounters => (string)((SettingsBase)this)["RobloxAssetCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetCreations => (string)((SettingsBase)this)["RobloxAssetCreations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetHashes => (string)((SettingsBase)this)["RobloxAssetHashes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetMedia => (string)((SettingsBase)this)["RobloxAssetMedia"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssets => (string)((SettingsBase)this)["RobloxAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetSales => (string)((SettingsBase)this)["RobloxAssetSales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetSecurity => (string)((SettingsBase)this)["RobloxAssetSecurity"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetSets => (string)((SettingsBase)this)["RobloxAssetSets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetStatistics => (string)((SettingsBase)this)["RobloxAssetStatistics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetStatisticsAggregation => (string)((SettingsBase)this)["RobloxAssetStatisticsAggregation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAvatars => (string)((SettingsBase)this)["RobloxAvatars"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxBilling => (string)((SettingsBase)this)["RobloxBilling"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxChat => (string)((SettingsBase)this)["RobloxChat"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxClientSettings => (string)((SettingsBase)this)["RobloxClientSettings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxContent => (string)((SettingsBase)this)["RobloxContent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxContentRatings => (string)((SettingsBase)this)["RobloxContentRatings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxContests => (string)((SettingsBase)this)["RobloxContests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxCurrency => (string)((SettingsBase)this)["RobloxCurrency"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxDemographics => (string)((SettingsBase)this)["RobloxDemographics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxDeployments => (string)((SettingsBase)this)["RobloxDeployments"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxDeveloperProducts => (string)((SettingsBase)this)["RobloxDeveloperProducts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxDistribution => (string)((SettingsBase)this)["RobloxDistribution"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxEconomy => (string)((SettingsBase)this)["RobloxEconomy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxEphemeralCounters => (string)((SettingsBase)this)["RobloxEphemeralCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFeeds => (string)((SettingsBase)this)["RobloxFeeds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFiles => (string)((SettingsBase)this)["RobloxFiles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGameCounters => (string)((SettingsBase)this)["RobloxGameCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGamePasses => (string)((SettingsBase)this)["RobloxGamePasses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGamePersistence => (string)((SettingsBase)this)["RobloxGamePersistence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGames => (string)((SettingsBase)this)["RobloxGames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGameService => (string)((SettingsBase)this)["RobloxGameService"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGamesRecentlyVisited => (string)((SettingsBase)this)["RobloxGamesRecentlyVisited"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGroups => (string)((SettingsBase)this)["RobloxGroups"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxInfrastructure => (string)((SettingsBase)this)["RobloxInfrastructure"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxInfrastructureAudit => (string)((SettingsBase)this)["RobloxInfrastructureAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxInteractionCounters => (string)((SettingsBase)this)["RobloxInteractionCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxLatencyMeasurements => (string)((SettingsBase)this)["RobloxLatencyMeasurements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMaintenance => (string)((SettingsBase)this)["RobloxMaintenance"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMarketing => (string)((SettingsBase)this)["RobloxMarketing"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMetrics => (string)((SettingsBase)this)["RobloxMetrics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMetricsClient => (string)((SettingsBase)this)["RobloxMetricsClient"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMetricsSandbox => (string)((SettingsBase)this)["RobloxMetricsSandbox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxModeration => (string)((SettingsBase)this)["RobloxModeration"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxModerationNew => (string)((SettingsBase)this)["RobloxModerationNew"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxObservation => (string)((SettingsBase)this)["RobloxObservation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPermissions => (string)((SettingsBase)this)["RobloxPermissions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPoints => (string)((SettingsBase)this)["RobloxPoints"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPremiumFeatures => (string)((SettingsBase)this)["RobloxPremiumFeatures"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPresence => (string)((SettingsBase)this)["RobloxPresence"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxReporting => (string)((SettingsBase)this)["RobloxReporting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxSegmentation => (string)((SettingsBase)this)["RobloxSegmentation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxServices => (string)((SettingsBase)this)["RobloxServices"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxShops => (string)((SettingsBase)this)["RobloxShops"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxStatistics => (string)((SettingsBase)this)["RobloxStatistics"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxStudio => (string)((SettingsBase)this)["RobloxStudio"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxThumbnails => (string)((SettingsBase)this)["RobloxThumbnails"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTimeSeries => (string)((SettingsBase)this)["RobloxTimeSeries"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTrades => (string)((SettingsBase)this)["RobloxTrades"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTransactionHistory => (string)((SettingsBase)this)["RobloxTransactionHistory"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUniverses => (string)((SettingsBase)this)["RobloxUniverses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserAssetEscrows => (string)((SettingsBase)this)["RobloxUserAssetEscrows"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserAssets => (string)((SettingsBase)this)["RobloxUserAssets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserCounters => (string)((SettingsBase)this)["RobloxUserCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUsers => (string)((SettingsBase)this)["RobloxUsers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserSettings => (string)((SettingsBase)this)["RobloxUserSettings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxVersions => (string)((SettingsBase)this)["RobloxVersions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxVoting => (string)((SettingsBase)this)["RobloxVoting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxVotingCounters => (string)((SettingsBase)this)["RobloxVotingCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string Roblox => (string)((SettingsBase)this)["Roblox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAuthentication => (string)((SettingsBase)this)["RobloxAuthentication"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxSystemEvents => (string)((SettingsBase)this)["RobloxSystemEvents"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAbTesting => (string)((SettingsBase)this)["RobloxAbTesting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxXbox => (string)((SettingsBase)this)["RobloxXbox"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetNamespaces => (string)((SettingsBase)this)["RobloxAssetNamespaces"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxShowcases => (string)((SettingsBase)this)["RobloxShowcases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxDeviceVoting => (string)((SettingsBase)this)["RobloxDeviceVoting"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxCurrencyBudgets => (string)((SettingsBase)this)["RobloxCurrencyBudgets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFilesV2 => (string)((SettingsBase)this)["RobloxFilesV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPushNotifications => (string)((SettingsBase)this)["RobloxPushNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxNotifications => (string)((SettingsBase)this)["RobloxNotifications"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGroupRoleSets => (string)((SettingsBase)this)["RobloxGroupRoleSets"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGroupPosts => (string)((SettingsBase)this)["RobloxGroupPosts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxIPAddresses => (string)((SettingsBase)this)["RobloxIPAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserPrivacy => (string)((SettingsBase)this)["RobloxUserPrivacy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxClickThroughAgreements => (string)((SettingsBase)this)["RobloxClickThroughAgreements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserStatuses => (string)((SettingsBase)this)["RobloxUserStatuses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxEmailAddresses => (string)((SettingsBase)this)["RobloxEmailAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserRetention => (string)((SettingsBase)this)["RobloxUserRetention"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFriendships => (string)((SettingsBase)this)["RobloxFriendships"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFollowings => (string)((SettingsBase)this)["RobloxFollowings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFriendRequests => (string)((SettingsBase)this)["RobloxFriendRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMacAddresses => (string)((SettingsBase)this)["RobloxMacAddresses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountSecurity => (string)((SettingsBase)this)["RobloxAccountSecurity"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxLocales => (string)((SettingsBase)this)["RobloxLocales"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxRoles => (string)((SettingsBase)this)["RobloxRoles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccounts => (string)((SettingsBase)this)["RobloxAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFileLocations => (string)((SettingsBase)this)["RobloxFileLocations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPlaceShowcases => (string)((SettingsBase)this)["RobloxPlaceShowcases"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGroupMembership => (string)((SettingsBase)this)["RobloxGroupMembership"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserAssetOptions => (string)((SettingsBase)this)["RobloxUserAssetOptions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserAssetExpirations => (string)((SettingsBase)this)["RobloxUserAssetExpirations"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGroupCounters => (string)((SettingsBase)this)["RobloxGroupCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxClans => (string)((SettingsBase)this)["RobloxClans"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUsersAudit => (string)((SettingsBase)this)["RobloxUsersAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountPhoneNumbersAudit => (string)((SettingsBase)this)["RobloxAccountPhoneNumbersAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTwoStepVerificationSettingsAudit => (string)((SettingsBase)this)["RobloxTwoStepVerificationSettingsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxCollectibles => (string)((SettingsBase)this)["RobloxCollectibles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGameAttributes => (string)((SettingsBase)this)["RobloxGameAttributes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxItemStatusesAudit => (string)((SettingsBase)this)["RobloxItemStatusesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountPinHashesAudit => (string)((SettingsBase)this)["RobloxAccountPinHashesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxBadgesV2 => (string)((SettingsBase)this)["RobloxBadgesV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGroupMembershipRequests => (string)((SettingsBase)this)["RobloxGroupMembershipRequests"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetsAudit => (string)((SettingsBase)this)["RobloxAssetsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxComments => (string)((SettingsBase)this)["RobloxComments"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserFeeds => (string)((SettingsBase)this)["RobloxUserFeeds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxBrowserTrackers => (string)((SettingsBase)this)["RobloxBrowserTrackers"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGameTemplates => (string)((SettingsBase)this)["RobloxGameTemplates"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMessages => (string)((SettingsBase)this)["RobloxMessages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxRobuxStipends => (string)((SettingsBase)this)["RobloxRobuxStipends"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountLocalization => (string)((SettingsBase)this)["RobloxAccountLocalization"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFavorites => (string)((SettingsBase)this)["RobloxFavorites"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPermissionLists => (string)((SettingsBase)this)["RobloxPermissionLists"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetVersions => (string)((SettingsBase)this)["RobloxAssetVersions"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxLocalization => (string)((SettingsBase)this)["RobloxLocalization"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFavoriteCounters => (string)((SettingsBase)this)["RobloxFavoriteCounters"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxDailyLogins => (string)((SettingsBase)this)["RobloxDailyLogins"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTranslation => (string)((SettingsBase)this)["RobloxTranslation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxBillingAuditLogs => (string)((SettingsBase)this)["RobloxBillingAuditLogs"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxBundles => (string)((SettingsBase)this)["RobloxBundles"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxEventsIngestValidation => (string)((SettingsBase)this)["RobloxEventsIngestValidation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxModerationReportsAudit => (string)((SettingsBase)this)["RobloxModerationReportsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxContacts => (string)((SettingsBase)this)["RobloxContacts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUserDataProtection => (string)((SettingsBase)this)["RobloxUserDataProtection"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountsAudit => (string)((SettingsBase)this)["RobloxAccountsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccoutrements => (string)((SettingsBase)this)["RobloxAccoutrements"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxPromotionChannels => (string)((SettingsBase)this)["RobloxPromotionChannels"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMachineLearningModels => (string)((SettingsBase)this)["RobloxMachineLearningModels"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountCountriesAudit => (string)((SettingsBase)this)["RobloxAccountCountriesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTranslationStorage => (string)((SettingsBase)this)["RobloxTranslationStorage"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetDetailsQuality => (string)((SettingsBase)this)["RobloxAssetDetailsQuality"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxInGameContentTables => (string)((SettingsBase)this)["RobloxInGameContentTables"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountLocalesAudit => (string)((SettingsBase)this)["RobloxAccountLocalesAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTeamOwnership => (string)((SettingsBase)this)["RobloxTeamOwnership"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFriendshipSources => (string)((SettingsBase)this)["RobloxFriendshipSources"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxLeasedLocks => (string)((SettingsBase)this)["RobloxLeasedLocks"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxModerationAutomationAudit => (string)((SettingsBase)this)["RobloxModerationAutomationAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAccountPasswordHashes => (string)((SettingsBase)this)["RobloxAccountPasswordHashes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxXboxLiveAccounts => (string)((SettingsBase)this)["RobloxXboxLiveAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxFacebookAccounts => (string)((SettingsBase)this)["RobloxFacebookAccounts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxStaticContent => (string)((SettingsBase)this)["RobloxStaticContent"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxBadges => (string)((SettingsBase)this)["RobloxBadges"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUsernames => (string)((SettingsBase)this)["RobloxUsernames"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxThemesV2 => (string)((SettingsBase)this)["RobloxThemesV2"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGameLocalization => (string)((SettingsBase)this)["RobloxGameLocalization"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxSurveyResponses => (string)((SettingsBase)this)["RobloxSurveyResponses"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxRatings => (string)((SettingsBase)this)["RobloxRatings"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxRatingsAudit => (string)((SettingsBase)this)["RobloxRatingsAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxSurveys => (string)((SettingsBase)this)["RobloxSurveys"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxMatchmaking => (string)((SettingsBase)this)["RobloxMatchmaking"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxIdentities => (string)((SettingsBase)this)["RobloxIdentities"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxChatParticipants => (string)((SettingsBase)this)["RobloxChatParticipants"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxModerationPolicy => (string)((SettingsBase)this)["RobloxModerationPolicy"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxRules => (string)((SettingsBase)this)["RobloxRules"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTranslationAudit => (string)((SettingsBase)this)["RobloxTranslationAudit"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxItemTags => (string)((SettingsBase)this)["RobloxItemTags"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxCurrencyRobuxHolds => (string)((SettingsBase)this)["RobloxCurrencyRobuxHolds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxCanonicalImages => (string)((SettingsBase)this)["RobloxCanonicalImages"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxTranslationAnalyticsReports => (string)((SettingsBase)this)["RobloxTranslationAnalyticsReports"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxGiftCards => (string)((SettingsBase)this)["RobloxGiftCards"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxUGCValidation => (string)((SettingsBase)this)["RobloxUGCValidation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAvatarEmotes => (string)((SettingsBase)this)["RobloxAvatarEmotes"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxItemManifolds => (string)((SettingsBase)this)["RobloxItemManifolds"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxAssetFormats => (string)((SettingsBase)this)["RobloxAssetFormats"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string RobloxEngagementPayouts => (string)((SettingsBase)this)["RobloxEngagementPayouts"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
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
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
