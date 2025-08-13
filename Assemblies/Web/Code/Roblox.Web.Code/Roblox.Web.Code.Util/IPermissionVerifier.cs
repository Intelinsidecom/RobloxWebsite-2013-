using System;
using Roblox.Platform.Devices;

namespace Roblox.Web.Code.Util;

/// <summary>
/// Utility class for checking if a user is authorized to access a feature.
/// Has methods for doing the checks based on appType, appVersion, deviceType, rollout percentage, or page name.
/// </summary>
public interface IPermissionVerifier
{
	bool IsWin10App { get; }

	bool IsStudioBrowsing { get; }

	bool IsGameClientBrowsing { get; }

	bool IsFeaturedEnabledOnSettings(bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false);

	bool IsFeatureEnabledOnSettingsAndClb(bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, bool keepOffForClbUserSetting = true, int rolloutPercentageSetting = 0, bool turnOnForAllExceptClbSetting = false);

	/// <summary>
	/// Determines if a feature is enabled based on the current BrowserTrackerId
	/// </summary>
	/// <param name="rolloutPercentageSetting">Setting for rollout percentage of feature</param>
	/// <param name="browserTrackerIdList">List of comma separated browserTrackerIds for which the feature is enabled</param>
	/// <param name="turnOnForAllSetting">Setting to control if feature is on for all</param>
	/// <returns>bool</returns>
	bool IsFeatureEnabledByBrowserTrackerId(int rolloutPercentageSetting, string browserTrackerIdList = null, bool turnOnForAllSetting = false);

	bool IsFeatureEnabledByAppType(AppType appType, bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false);

	bool IsFeatureEnabledByDeviceType(DeviceType deviceType, bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false);

	/// <summary>
	/// Get settings for a feature rollout per page basis - supports global soothsayer and all users overrides
	/// </summary>
	/// <param name="pageNameFromModel">Page name as defined in PageNameProvider</param>
	/// <param name="pagesEnabledForAll">List of comma separated pages enabled for soothsayers</param>
	/// <param name="soothsayerSetting">Enable all pages for soothsayers</param>
	/// <param name="enabledForAllSetting">Enable all pages for all users</param>
	/// <param name="pagesEnabledForSoothsayers">List of comma separated pages enabled for soothsayers</param>
	/// <returns>bool</returns>
	bool IsFeatureEnabledOnPageNames(string pageNameFromModel, string pagesEnabledForAll, bool soothsayerSetting = false, bool enabledForAllSetting = false, string pagesEnabledForSoothsayers = "");

	bool IsFeatureEnabledByAppVersion(string minimumEnabledVersion);

	/// <summary>
	/// Get version number by checking soothsayer accounts
	/// </summary>
	/// <param name="versionNumberForSoothsayer">Guid representing version for soothsayers</param>
	/// <param name="versionNumberForAll">Guid representing version for everyone else</param>
	Guid GetVersionNumberBySettings(Guid versionNumberForSoothsayer, Guid versionNumberForAll);

	/// <summary>
	/// Get version number by checking browser tracker ID
	/// </summary>
	/// <param name="browserTrackerIdList">List of comma separated browser tracker IDs that will get specific version</param>
	/// <param name="versionNumberForBrowserTrackerIdList">Guid representing version for browser tracker IDs in the browserTrackerIdList provided</param>
	/// <param name="versionNumberForAll">Guid representing version for everyone else</param>
	Guid GetVersionNumberBySettings(string browserTrackerIdList, Guid versionNumberForBrowserTrackerIdList, Guid versionNumberForAll);
}
