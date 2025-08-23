using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Configuration;
using Roblox.Marketing;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication;
using Roblox.Web.Devices;

namespace Roblox.Web.Code.Util;

/// <inheritdoc cref="T:Roblox.Web.Code.Util.IPermissionVerifier" />
public class PermissionVerifier : IPermissionVerifier
{
	private static readonly ConcurrentDictionary<string, ISet<long>> _UserIdWhitelistCache = new ConcurrentDictionary<string, ISet<long>>();

	private readonly IWebAuthenticator _WebAuthenticator;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private string UserAgent => HttpContext.Current.Request.UserAgent;

	public bool IsWin10App => _ClientDeviceIdentifier.IsRobloxWindowsApp(UserAgent);

	public bool IsApp => _ClientDeviceIdentifier.IsRobloxApp(UserAgent);

	public bool IsStudioBrowsing => Browser.IsRobloxStudio(HttpContext.Current);

	public bool IsGameClientBrowsing => _ClientDeviceIdentifier.IsRobloxClient(UserAgent);

	public bool IsIEAndTouchInWin()
	{
		if (_ClientDeviceIdentifier.GetDeviceType(UserAgent) == DeviceType.Tablet)
		{
			return Browser.IsIE11(HttpContext.Current);
		}
		return false;
	}

	public PermissionVerifier(WebAuthenticator webAuthenticator, IClientDeviceIdentifier clientDeviceIdentifier)
	{
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentNullException("webAuthenticator");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
	}

	public bool IsFeaturedEnabledOnSettings(bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false)
	{
		if (turnOnForAllSetting)
		{
			return true;
		}
		IUser authenticatedUser = _WebAuthenticator.GetAuthenticatedUser();
		bool result = authenticatedUser != null && ((soothsayerSetting && authenticatedUser.IsSoothSayer()) || (betaTesterSetting && authenticatedUser.IsBetaTester()) || rolloutPercentageSetting > authenticatedUser.Id % 100);
		if (authenticatedUser == null && isGuestAllowed)
		{
			return rolloutPercentageSetting == 100;
		}
		return result;
	}

	public bool IsFeaturedEnabledOnUserIds(IUser user, string userIdWhitelist)
	{
		if (user != null && !string.IsNullOrEmpty(userIdWhitelist))
		{
			return _UserIdWhitelistCache.GetOrAdd(userIdWhitelist, (string setting) => MultiValueSettingParser.TryParseCommaDelimitedListString(setting, long.Parse)).Contains(user.Id);
		}
		return false;
	}

	public bool IsFeatureEnabledByBrowserTrackerId(int rolloutPercentageSetting, string browserTrackerIdList = null, bool turnOnForAllSetting = false)
	{
		if (turnOnForAllSetting || rolloutPercentageSetting >= 100)
		{
			return true;
		}
		long? browserTrackerId = MarketingHelper.GetBrowserTrackerID(HttpContext.Current);
		if (IsBrowserTrackerIdInList(browserTrackerId, browserTrackerIdList))
		{
			return true;
		}
		return rolloutPercentageSetting > browserTrackerId % 100;
	}

	public bool IsFeatureEnabledByAppType(AppType appType, bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false)
	{
		bool result = IsFeaturedEnabledOnSettings(isGuestAllowed, soothsayerSetting, betaTesterSetting, rolloutPercentageSetting, turnOnForAllSetting);
		switch (appType)
		{
		case AppType.iOS:
			result = result && _ClientDeviceIdentifier.IsRobloxIOSApp(UserAgent);
			break;
		case AppType.Android:
			result = result && _ClientDeviceIdentifier.IsRobloxAndroidApp(UserAgent);
			break;
		case AppType.Win10:
			result = result && _ClientDeviceIdentifier.IsRobloxWindowsApp(UserAgent);
			break;
		case AppType.All:
			result = result && (_ClientDeviceIdentifier.IsRobloxIOSApp(UserAgent) || _ClientDeviceIdentifier.IsRobloxAndroidApp(UserAgent) || _ClientDeviceIdentifier.IsRobloxWindowsApp(UserAgent));
			break;
		}
		return result;
	}

	public bool IsFeatureEnabledByDeviceType(DeviceType deviceType, bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false)
	{
		bool result = IsFeaturedEnabledOnSettings(isGuestAllowed, soothsayerSetting, betaTesterSetting, rolloutPercentageSetting, turnOnForAllSetting);
		switch (deviceType)
		{
		case DeviceType.Computer:
			result = result && _ClientDeviceIdentifier.GetDeviceType(UserAgent) == DeviceType.Computer;
			break;
		case DeviceType.Tablet:
			result = result && _ClientDeviceIdentifier.GetDeviceType(UserAgent) == DeviceType.Tablet;
			break;
		case DeviceType.Phone:
			result = result && _ClientDeviceIdentifier.GetDeviceType(UserAgent) == DeviceType.Phone;
			break;
		}
		return result;
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.Util.IPermissionVerifier.IsFeatureEnabledOnPageNames(System.String,System.String,System.Boolean,System.Boolean,System.String)" />
	public bool IsFeatureEnabledOnPageNames(string pageNameFromModel, string pagesEnabledForAll, bool soothsayerSetting = false, bool enabledForAllSetting = false, string pagesEnabledForSoothsayers = "")
	{
		if (enabledForAllSetting)
		{
			return true;
		}
		if (((ICollection<string>)pagesEnabledForAll.Split(',').ToList()).Contains(pageNameFromModel))
		{
			return true;
		}
		IUser authenticatedUser = _WebAuthenticator.GetAuthenticatedUser();
		if (authenticatedUser != null && authenticatedUser.IsSoothSayer())
		{
			if (soothsayerSetting)
			{
				return true;
			}
			if (((ICollection<string>)pagesEnabledForSoothsayers.Split(',').ToList()).Contains(pageNameFromModel) && authenticatedUser.IsSoothSayer())
			{
				return true;
			}
		}
		return false;
	}

	public bool IsFeatureEnabledByAppVersion(string minimumEnabledVersion)
	{
		if (string.IsNullOrEmpty(minimumEnabledVersion))
		{
			return false;
		}
		Version appVersion = new Version(minimumEnabledVersion);
		return _ClientDeviceIdentifier.IsRobloxAppVersionAtLeast(appVersion, UserAgent);
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.Util.IPermissionVerifier.GetVersionNumberBySettings(System.Guid,System.Guid)" />
	public Guid GetVersionNumberBySettings(Guid versionNumberForSoothsayer, Guid versionNumberForAll)
	{
		IUser authenticatedUser = _WebAuthenticator.GetAuthenticatedUser();
		if (authenticatedUser != null && authenticatedUser.IsSoothSayer())
		{
			return versionNumberForSoothsayer;
		}
		return versionNumberForAll;
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.Util.IPermissionVerifier.GetVersionNumberBySettings(System.String,System.Guid,System.Guid)" />
	public Guid GetVersionNumberBySettings(string browserTrackerIdList, Guid versionNumberForBrowserTrackerIdList, Guid versionNumberForAll)
	{
		long? browserTrackerId = MarketingHelper.GetBrowserTrackerID(HttpContext.Current);
		if (IsBrowserTrackerIdInList(browserTrackerId, browserTrackerIdList))
		{
			return versionNumberForBrowserTrackerIdList;
		}
		return versionNumberForAll;
	}

	private bool IsBrowserTrackerIdInList(long? browserTrackerId, string browserTrackerIdList)
	{
		if (!browserTrackerId.HasValue || string.IsNullOrWhiteSpace(browserTrackerIdList))
		{
			return false;
		}
		return browserTrackerIdList.Split(',').Any((string bt) => bt == browserTrackerId.ToString());
	}

	public bool IsFeatureEnabledOnSettingsAndClb(bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, bool keepOffForClbUserSetting = true, int rolloutPercentageSetting = 0, bool turnOnForAllExceptClbSetting = false)
	{
		IUser authenticatedUser = _WebAuthenticator.GetAuthenticatedUser();
		if (turnOnForAllExceptClbSetting && (authenticatedUser == null || !authenticatedUser.IsChinaLicenseUser()))
		{
			return true;
		}
		if (keepOffForClbUserSetting && authenticatedUser != null && authenticatedUser.IsChinaLicenseUser())
		{
			return false;
		}
		bool result = authenticatedUser != null && ((soothsayerSetting && authenticatedUser.IsSoothSayer()) || (betaTesterSetting && authenticatedUser.IsBetaTester()) || rolloutPercentageSetting > authenticatedUser.Id % 100);
		if (authenticatedUser == null && isGuestAllowed)
		{
			return rolloutPercentageSetting == 100;
		}
		return result;
	}
}
