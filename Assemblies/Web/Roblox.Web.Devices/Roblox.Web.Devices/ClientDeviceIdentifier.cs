using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Roblox.Libraries.Cookies;
using Roblox.Platform.Devices;
using Roblox.Web.Cookies;
using Roblox.Web.Devices.Properties;
using Roblox.Web.Properties;

namespace Roblox.Web.Devices;

/// <summary>
/// Implementation of <see cref="T:Roblox.Web.Devices.IClientDeviceIdentifier" />.
/// </summary>
public class ClientDeviceIdentifier : IClientDeviceIdentifier
{
	private readonly Regex _RobloxAppRegex = new Regex("RobloxApp/(?<version>[\\d\\.]+)");

	private readonly Regex _AppVersionRegex = new Regex("ROBLOX (?<os>iOS|Android|Windows) App (?<version>\\d+\\.\\d+(\\.\\d+)?(\\.\\d+)?)", RegexOptions.Compiled);

	private readonly Regex _DeviceVersionRegex = new Regex("(?<device>ipad|ipod|iphone)(?<major>\\d+)(,(?<minor>\\d+))?", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private readonly Regex _iOSMajorVersionRegex = new Regex("(iPhone OS )(?<version>\\d+)?", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private readonly Regex _AndroidMajorVersionRegex = new Regex(" (?<version>([\\d|.]+))\\)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private readonly IDeviceFactory _DeviceFactory;

	private readonly IPlatformFactory _PlatformFactory;

	private readonly Roblox.Web.Devices.Properties.ISettings _Settings;

	private const string _RobloxWindowsUniversalAppIdentifier = "ROBLOX UWP";

	private const string _RobloxStudioForWindowsUserAgent = "RobloxStudio/WinInet";

	private const string _RobloxStudioForMacUserAgent = "RobloxStudio/Darwin";

	private string _AppDeviceIdentifier => AppDeviceIdentifierCookie?.AppDeviceIdentifier;

	protected virtual AppDeviceIdentifierCookie AppDeviceIdentifierCookie => RobloxCookieHelper.Get<AppDeviceIdentifierCookie>(AppDeviceIdentifierCookie.CookieIdentifier);

	protected virtual int AndroidDeviceMemoryThreshold => _Settings.AndroidDeviceMemoryThreshold;

	protected virtual double AndroidDeviceScreenPhysicalInchXThreshold => _Settings.AndroidDeviceScreenPhysicalInchXThreshold;

	protected virtual double AndroidDeviceScreenPhysicalInchYThreshold => _Settings.AndroidDeviceScreenPhysicalInchYThreshold;

	protected virtual int MinimumMajorIOSVersion => _Settings.MinimumMajorIOSVersion;

	protected virtual string PowershellUserAgentString => _Settings.PowershellUserAgentString;

	/// <summary>
	/// Instantiates a new <see cref="T:Roblox.Web.Devices.ClientDeviceIdentifier" />.
	/// </summary>
	/// <param name="deviceFactory">An <see cref="T:Roblox.Platform.Devices.IDeviceFactory" />.</param>
	/// <param name="platformFactory">An <see cref="T:Roblox.Platform.Devices.IPlatformFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="deviceFactory" />, <paramref name="platformFactory" /></exception>
	public ClientDeviceIdentifier(IDeviceFactory deviceFactory, IPlatformFactory platformFactory)
		: this(deviceFactory, platformFactory, Roblox.Web.Devices.Properties.Settings.Default)
	{
	}

	internal ClientDeviceIdentifier(IDeviceFactory deviceFactory, IPlatformFactory platformFactory, Roblox.Web.Devices.Properties.ISettings settings)
	{
		_DeviceFactory = deviceFactory ?? throw new ArgumentNullException("deviceFactory");
		_PlatformFactory = platformFactory ?? throw new ArgumentNullException("platformFactory");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.CreateAndSetAppIdentifier(System.Web.HttpContext)" />
	public string CreateAndSetAppIdentifier(HttpContext context)
	{
		if (IsRobloxWindowsApp(context.Request.UserAgent) && !context.Request.Cookies.AllKeys.Contains(Roblox.Web.Properties.Settings.Default.AppDeviceIdentifierCookie_Name))
		{
			AppDeviceIdentifierCookie orCreate = RobloxCookieHelper.GetOrCreate<AppDeviceIdentifierCookie>(AppDeviceIdentifierCookie.CookieIdentifier);
			orCreate.AppDeviceIdentifier = "ROBLOX UWP";
			orCreate.Save();
			return orCreate.AppDeviceIdentifier;
		}
		return null;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxPowershell(System.String)" />
	public bool IsRobloxPowershell(string userAgent)
	{
		return userAgent?.ToLower().Contains(PowershellUserAgentString) ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.UseAppBrowsingMode(System.String)" />
	public bool UseAppBrowsingMode(string userAgent)
	{
		if (!IsRobloxIOSApp(userAgent) && !IsRobloxAndroidApp(userAgent))
		{
			return IsRobloxWindowsApp(userAgent);
		}
		return true;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsGoogleStoreApp(System.String)" />
	public bool IsGoogleStoreApp(string userAgent)
	{
		return userAgent?.Contains("GooglePlayStore") ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsAmazonApp(System.String)" />
	public bool IsAmazonApp(string userAgent)
	{
		return userAgent?.Contains("AmazonAppStore") ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxApp(System.String)" />
	public bool IsRobloxApp(string userAgent)
	{
		if (_Settings.RobloxAppViaUserAgentDetectedAsRobloxAppEnabled && !string.IsNullOrWhiteSpace(userAgent) && _RobloxAppRegex.IsMatch(userAgent))
		{
			return true;
		}
		if (!IsRobloxIOSApp(userAgent) && !IsRobloxAndroidApp(userAgent))
		{
			return IsRobloxWindowsApp(userAgent);
		}
		return true;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxClient(System.String)" />
	public bool IsRobloxClient(string userAgent)
	{
		if (userAgent != null)
		{
			if (!userAgent.Contains("Roblox/WinInet") && !userAgent.Equals("Roblox/WinInet") && !userAgent.Equals("Roblox/Darwin") && !userAgent.Equals("Roblox/XboxOne") && !userAgent.Equals("Roblox/WinUWP"))
			{
				return userAgent.Equals("Roblox/Linux");
			}
			return true;
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxStudio(System.String)" />
	public bool IsRobloxStudio(string userAgent)
	{
		if (userAgent != null)
		{
			if (!userAgent.Equals("RobloxStudio/WinInet"))
			{
				return userAgent.Equals("RobloxStudio/Darwin");
			}
			return true;
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRoblox(System.String)" />
	public bool IsRoblox(string userAgent)
	{
		return userAgent?.ToLower().Contains("roblox") ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxIOSApp(System.String)" />
	public bool IsRobloxIOSApp(string userAgent)
	{
		if (userAgent != null)
		{
			if (!userAgent.Contains("ROBLOX iOS"))
			{
				return userAgent.Contains("ROBLOX Native iOS");
			}
			return true;
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxAndroidApp(System.String)" />
	public bool IsRobloxAndroidApp(string userAgent)
	{
		return userAgent?.Contains("ROBLOX Android") ?? false;
	}

	public bool IsRobloxAndroidAppOnChromebook(string userAgent)
	{
		return userAgent?.Contains("ChromeOS") ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxWindowsApp(System.String)" />
	public bool IsRobloxWindowsApp(string userAgent)
	{
		if (!IsUwpApplication())
		{
			if (userAgent != null)
			{
				if (!userAgent.Contains("ROBLOX Windows"))
				{
					if (userAgent.Contains("WebView"))
					{
						return userAgent.Contains("Edge");
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxXboxApp(System.String)" />
	public bool IsRobloxXboxApp(string userAgent)
	{
		return userAgent?.Contains("ROBLOX Xbox") ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsRobloxAppVersionAtLeast(System.Version,System.String)" />
	public bool IsRobloxAppVersionAtLeast(Version minVersion, string userAgent)
	{
		Version version = GetRobloxAppVersionNumber(userAgent);
		if (version != null)
		{
			return version >= minVersion;
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsMobile(System.String)" />
	public bool IsMobile(string userAgent)
	{
		DeviceType deviceType = GetDeviceType(userAgent);
		if (deviceType != DeviceType.Phone)
		{
			return deviceType == DeviceType.Tablet;
		}
		return true;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetRobloxAppVersionNumber(System.String)" />
	public Version GetRobloxAppVersionNumber(string userAgent)
	{
		if (string.IsNullOrEmpty(userAgent))
		{
			return null;
		}
		Match match = _AppVersionRegex.Match(userAgent);
		if (!match.Success)
		{
			return null;
		}
		return new Version(match.Groups["version"].Value);
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetRobloxAppVersion(System.String)" />
	public string GetRobloxAppVersion(string userAgent)
	{
		if (string.IsNullOrEmpty(userAgent))
		{
			throw new ArgumentException("Invalid userAgent");
		}
		Match match = _AppVersionRegex.Match(userAgent);
		if (!match.Success)
		{
			throw new ArgumentException("Invalid userAgent");
		}
		return string.Format("App{0}V{1}", match.Groups["os"].Value, match.Groups["version"].Value);
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetDeviceVersionFromRobloxIOSApp(System.String,Roblox.Platform.Devices.IOSDeviceType@,System.Version@)" />
	public void GetDeviceVersionFromRobloxIOSApp(string userAgent, out IOSDeviceType deviceType, out Version version)
	{
		deviceType = IOSDeviceType.Unknown;
		version = new Version(0, 0);
		if (!IsRobloxIOSApp(userAgent))
		{
			return;
		}
		Match match = _DeviceVersionRegex.Match(userAgent);
		if (match.Success)
		{
			switch (match.Groups["device"].Value.ToLower())
			{
			case "ipad":
				deviceType = IOSDeviceType.iPad;
				break;
			case "ipod":
				deviceType = IOSDeviceType.iPod;
				break;
			case "iphone":
				deviceType = IOSDeviceType.iPhone;
				break;
			default:
				deviceType = IOSDeviceType.Unknown;
				break;
			}
			int major = 0;
			int minor = 0;
			int.TryParse(match.Groups["major"].Value, out major);
			if (match.Groups["minor"].Success)
			{
				int.TryParse(match.Groups["minor"].Value, out minor);
			}
			version = new Version(major, minor);
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetMajorIOSVersion(System.String)" />
	public int GetMajorIOSVersion(string userAgent)
	{
		if (!string.IsNullOrEmpty(userAgent))
		{
			Match match = _iOSMajorVersionRegex.Match(userAgent);
			int version = 0;
			if (match.Success && int.TryParse(match.Groups["version"].Value, out version))
			{
				return version;
			}
		}
		return -1;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetMajorAndroidVersion(System.String)" />
	public int GetMajorAndroidVersion(string userAgent)
	{
		if (string.IsNullOrWhiteSpace(userAgent))
		{
			return -1;
		}
		Match match = _AndroidMajorVersionRegex.Match(userAgent);
		if (!match.Success)
		{
			return -1;
		}
		string version = match.Groups["version"].Value;
		if (string.IsNullOrWhiteSpace(version))
		{
			return -1;
		}
		if (int.TryParse(new string(version.TakeWhile(char.IsDigit).ToArray()), out var result))
		{
			return result;
		}
		return -1;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.IsIOSVersionSupported(System.String)" />
	public bool IsIOSVersionSupported(string userAgent)
	{
		return GetMajorIOSVersion(userAgent) >= MinimumMajorIOSVersion;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetFriendlyDeviceNameFromRobloxIOSApp(System.String)" />
	public string GetFriendlyDeviceNameFromRobloxIOSApp(string userAgent)
	{
		GetDeviceVersionFromRobloxIOSApp(userAgent, out var deviceType, out var version);
		return _DeviceFactory.GetFriendlyIOSDeviceName(deviceType, version);
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetDeviceType(System.String)" />
	public DeviceType GetDeviceType(string userAgent)
	{
		if (IsRobloxIOSApp(userAgent))
		{
			string deviceName = GetFriendlyDeviceNameFromRobloxIOSApp(userAgent);
			return _PlatformFactory.GetByValue(deviceName)?.DeviceType ?? DeviceType.Computer;
		}
		if (IsRobloxAndroidApp(userAgent))
		{
			return GetAndroidPlatformFromInAppUserAgent(userAgent)?.DeviceType ?? DeviceType.Computer;
		}
		return GetPlatformByUserAgent(userAgent)?.DeviceType ?? DeviceType.Computer;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetPlatformByUserAgent(System.String)" />
	public IPlatform GetPlatformByUserAgent(string userAgent)
	{
		IPlatform platform = null;
		if (IsRobloxIOSApp(userAgent))
		{
			string deviceName = GetFriendlyDeviceNameFromRobloxIOSApp(userAgent);
			platform = _PlatformFactory.GetByValue(deviceName);
		}
		else if (IsRobloxAndroidAppOnChromebook(userAgent))
		{
			platform = GetChromebookPlatformFromInAppUserAgent();
		}
		else if (IsRobloxAndroidApp(userAgent))
		{
			platform = GetAndroidPlatformFromInAppUserAgent(userAgent);
		}
		else if (IsRobloxWindowsApp(userAgent))
		{
			platform = GetWindowsPlatform();
		}
		else if (IsRobloxXboxApp(userAgent))
		{
			platform = _PlatformFactory.GetByType(PlatformType.XboxOne);
		}
		else if (IsRobloxStudio(userAgent))
		{
			platform = GetStudioPlatformFromUserAgent(userAgent);
		}
		if (string.IsNullOrEmpty(userAgent))
		{
			platform = _PlatformFactory.GetByType(PlatformType.Unknown);
		}
		else
		{
			string ua = userAgent.ToLower();
			if (platform == null || platform.PlatformType == PlatformType.Unknown)
			{
				if (ua.Contains("windows") || ua.Contains("wininet") || ua.Contains("winhttp"))
				{
					platform = ((ua.Contains("mobile") || ua.Contains("phone")) ? _PlatformFactory.GetByType(PlatformType.WindowsUnknownPhone) : ((!ua.Contains("touch")) ? _PlatformFactory.GetByType(PlatformType.PC) : _PlatformFactory.GetByType(PlatformType.WindowsUnknownTablet)));
				}
				if (ua.Contains("xbox"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.XboxOne);
				}
				if (ua.Contains("mac") || ua.Contains("darwin"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.Mac);
				}
				if (ua.Contains("ipad1"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPad1);
				}
				if (ua.Contains("ipad2"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPad2);
				}
				if (ua.Contains("ipad3"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPad3);
				}
				if (ua.Contains("iphone1"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPhone3G);
				}
				if (ua.Contains("iphone2"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPhone3GS);
				}
				if (ua.Contains("iphone3"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPhone4);
				}
				if (ua.Contains("iphone4"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPhone4S);
				}
				if (ua.Contains("iphone5"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPhone5);
				}
				if (ua.Contains("iphone6"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPhone6);
				}
				if (ua.Contains("ipod3"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPodTouch3G);
				}
				if (ua.Contains("ipod4"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPodTouch4G);
				}
				if (ua.Contains("ipod5"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iPodTouch5G);
				}
				if (ua.Contains("ipad"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iOSUnknownTablet);
				}
				else if (ua.Contains("ipod") || ua.Contains("iphone"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iOSUnknownPhone);
				}
				else if (ua.Contains("ios"))
				{
					platform = _PlatformFactory.GetByType(PlatformType.iOSUnknown);
				}
				if (ua.Contains("android"))
				{
					platform = GetAndroidPlatformFromInAppUserAgent(userAgent);
					if (platform.PlatformType == PlatformType.AndroidUnknown)
					{
						platform = ((!ua.Contains("mobile")) ? _PlatformFactory.GetByType(PlatformType.AndroidUnknownTablet) : _PlatformFactory.GetByType(PlatformType.AndroidUnknownPhone));
					}
				}
				if (platform == null)
				{
					platform = _PlatformFactory.GetByType(PlatformType.Unknown);
				}
			}
		}
		return platform;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetPlatformNameByPlatformType(Roblox.Platform.Devices.PlatformType)" />
	public string GetPlatformNameByPlatformType(PlatformType platformType)
	{
		return GetPlatformNameByPlatformType(platformType);
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.DetectOperatingSystemType(System.String)" />
	public OperatingSystemType DetectOperatingSystemType(string userAgent)
	{
		return GetPlatformByUserAgent(userAgent)?.OperatingSystemType ?? OperatingSystemType.Unknown;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetPlatformTypeIdByUserAgent(System.String)" />
	public byte GetPlatformTypeIdByUserAgent(string userAgent)
	{
		return GetPlatformByUserAgent(userAgent)?.PlatformTypeId ?? 0;
	}

	/// <inheritdoc cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetPlatformTypeByUserAgent(System.String)" />
	public PlatformType GetPlatformTypeByUserAgent(string userAgent)
	{
		return GetPlatformByUserAgent(userAgent)?.PlatformType ?? PlatformType.Unknown;
	}

	private IPlatform GetChromebookPlatformFromInAppUserAgent()
	{
		return _PlatformFactory.GetByType(PlatformType.Chromebook);
	}

	private IPlatform GetAndroidPlatformFromInAppUserAgent(string userAgent)
	{
		IPlatform platform = null;
		AndroidAppDeviceInfo deviceInfo = new AndroidAppDeviceInfo();
		if (deviceInfo.Populate(userAgent))
		{
			platform = ((!userAgent.Contains("Phone") && !userAgent.Contains("phone")) ? ((userAgent.Contains("Tablet") || userAgent.Contains("tablet")) ? ((deviceInfo.Memory > AndroidDeviceMemoryThreshold) ? _PlatformFactory.GetByType(PlatformType.AndroidHighEndTablet) : _PlatformFactory.GetByType(PlatformType.AndroidLowEndTablet)) : ((deviceInfo.Memory > AndroidDeviceMemoryThreshold && (deviceInfo.PhysicalInchX > AndroidDeviceScreenPhysicalInchXThreshold || deviceInfo.PhysicalInchY > AndroidDeviceScreenPhysicalInchYThreshold)) ? _PlatformFactory.GetByType(PlatformType.AndroidHighEndTablet) : ((deviceInfo.Memory > AndroidDeviceMemoryThreshold && deviceInfo.PhysicalInchX <= AndroidDeviceScreenPhysicalInchXThreshold && deviceInfo.PhysicalInchY <= AndroidDeviceScreenPhysicalInchYThreshold) ? _PlatformFactory.GetByType(PlatformType.AndroidHighEndPhone) : ((deviceInfo.Memory > AndroidDeviceMemoryThreshold || (!(deviceInfo.PhysicalInchX > AndroidDeviceScreenPhysicalInchXThreshold) && !(deviceInfo.PhysicalInchY > AndroidDeviceScreenPhysicalInchYThreshold))) ? _PlatformFactory.GetByType(PlatformType.AndroidLowEndPhone) : _PlatformFactory.GetByType(PlatformType.AndroidLowEndTablet))))) : ((deviceInfo.Memory > AndroidDeviceMemoryThreshold) ? _PlatformFactory.GetByType(PlatformType.AndroidHighEndPhone) : _PlatformFactory.GetByType(PlatformType.AndroidLowEndPhone)));
		}
		return platform ?? _PlatformFactory.GetByType(PlatformType.AndroidUnknown);
	}

	private IPlatform GetWindowsPlatform()
	{
		if (IsUwpApplication())
		{
			return _PlatformFactory.GetByType(PlatformType.DesktopWindowsUwp);
		}
		return _PlatformFactory.GetByType(PlatformType.PC);
	}

	private IPlatform GetStudioPlatformFromUserAgent(string userAgent)
	{
		if (userAgent.Equals("RobloxStudio/WinInet"))
		{
			return _PlatformFactory.GetByType(PlatformType.StudioWindows);
		}
		if (userAgent.Equals("RobloxStudio/Darwin"))
		{
			return _PlatformFactory.GetByType(PlatformType.StudioMac);
		}
		return _PlatformFactory.GetByType(PlatformType.Unknown);
	}

	private bool IsUwpApplication()
	{
		return _AppDeviceIdentifier == "ROBLOX UWP";
	}
}
