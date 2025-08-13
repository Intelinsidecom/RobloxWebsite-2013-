using System;
using System.Web;
using Roblox.Platform.Devices;

namespace Roblox.Web.Devices;

/// <summary>
/// An interface that identifies client devices.
/// </summary>
public interface IClientDeviceIdentifier
{
	/// <summary>
	/// Creates and Sets the unique Identifier for the current App.
	/// </summary>
	/// <param name="context">The current <see cref="T:System.Web.HttpContext" /></param>
	/// <returns>The unique Identifier for the current App</returns>
	string CreateAndSetAppIdentifier(HttpContext context);

	/// <summary>
	/// Detects the <see cref="T:Roblox.Platform.Devices.OperatingSystemType" /> indicated by a given UserAgent
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Devices.OperatingSystemType" />.</returns>
	OperatingSystemType DetectOperatingSystemType(string userAgent);

	/// <summary>
	/// Detects the <see cref="T:Roblox.Platform.Devices.DeviceType" /> indicated by a given UserAgent
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Devices.DeviceType" />.</returns>
	DeviceType GetDeviceType(string userAgent);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Devices.IOSDeviceType" /> and a <see cref="T:System.Version" /> for the given UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <param name="deviceType">The corresponding <see cref="T:Roblox.Platform.Devices.IOSDeviceType" />.</param>
	/// <param name="version">The corresponding <see cref="T:System.Version" />.</param>
	void GetDeviceVersionFromRobloxIOSApp(string userAgent, out IOSDeviceType deviceType, out Version version);

	/// <summary>
	/// Gets the friendly name for an iOS device indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The friendly name for the detected iOS device.</returns>
	string GetFriendlyDeviceNameFromRobloxIOSApp(string userAgent);

	/// <summary>
	/// Detects the major version for an iOS device indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The major version.</returns>
	int GetMajorIOSVersion(string userAgent);

	/// <summary>
	/// Detects the major version for an Android device indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The major version.</returns>
	int GetMajorAndroidVersion(string userAgent);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Devices.IPlatform" /> indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Devices.IPlatform" />.</returns>
	IPlatform GetPlatformByUserAgent(string userAgent);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.Devices.PlatformType" /> indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Devices.PlatformType" />.</returns>
	PlatformType GetPlatformTypeByUserAgent(string userAgent);

	/// <summary>
	/// Gets platform name from platformTypeId
	/// </summary>
	/// <param name="platformType"> platform type <see cref="T:Roblox.Platform.Devices.PlatformType" />  </param>
	/// <returns>platform name</returns>
	string GetPlatformNameByPlatformType(PlatformType platformType);

	/// <summary>
	/// Determines the <see cref="!:Roblox.Classification.PlatformType" /> Id based on the UserAgent.
	/// </summary>
	/// <remarks>Please avoid using this where possible.  When writing new code try to consume <see cref="T:Roblox.Platform.Devices.PlatformType" /> from <see cref="M:Roblox.Web.Devices.IClientDeviceIdentifier.GetPlatformTypeByUserAgent(System.String)" /> instead.</remarks>
	/// <param name="userAgent">A UserAgent.</param>
	/// <returns>The corresponding <see cref="!:Roblox.Classification.PlatformType" /> Id.</returns>
	[Obsolete]
	byte GetPlatformTypeIdByUserAgent(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox Powershell script.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its Roblox Powershell.</returns>
	bool IsRobloxPowershell(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent should use App Browsing Mode.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if it should.</returns>
	bool UseAppBrowsingMode(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox App.</returns>
	bool IsRobloxApp(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent corresponds to the Roblox Client.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its the Roblox Client.</returns>
	bool IsRobloxClient(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent corresponds to Roblox Studio.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its Roblox Studio.</returns>
	bool IsRobloxStudio(string userAgent);

	/// <summary>
	/// Determines if the given UserAgent is from any official Roblox consumer.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if <paramref name="userAgent" /> contains "Roblox".</returns>
	bool IsRoblox(string userAgent);

	/// <summary>
	/// Determines if the given UserAgent is from a Mobile device
	/// </summary>
	/// <param name="userAgent"></param>
	/// <returns><c>true</c> if mobile device</returns>
	bool IsMobile(string userAgent);

	/// <summary>
	/// Gets the version string of the Roblox App indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns>A string representation of the App Version.</returns>
	string GetRobloxAppVersion(string userAgent);

	/// <summary>
	/// Get the version number of the Roblox App indicated by a UserAgent.
	/// </summary>
	/// <param name="userAgent"></param>
	/// <returns></returns>
	Version GetRobloxAppVersionNumber(string userAgent);

	/// <summary>
	/// Determines if the Roblox App version indicated by a UserAgent is at least the specified version.
	/// </summary>
	/// <param name="minVersion">The minimum <see cref="T:System.Version" />.</param>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if the version meets minimum requirements.</returns>
	bool IsRobloxAppVersionAtLeast(Version minVersion, string userAgent);

	/// <summary>
	/// Determines if the version of the Roblox iOS App indicated by a UserAgent is supported.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if the corresponding version is supported.</returns>
	bool IsIOSVersionSupported(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox iOS App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox iOS App.</returns>
	bool IsRobloxIOSApp(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox Android App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox Android App.</returns>
	bool IsRobloxAndroidApp(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent corresponds to a Roblox ChromeOS
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox ChromeOS.</returns>
	bool IsRobloxAndroidAppOnChromebook(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox Amazon App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox Amazon App.</returns>
	bool IsAmazonApp(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox GoogleStore App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox GoogleStore App.</returns>
	bool IsGoogleStoreApp(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox Windows App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox Windows App.</returns>
	bool IsRobloxWindowsApp(string userAgent);

	/// <summary>
	/// Determines if the give UserAgent cooresponds to a Roblox Xbox App.
	/// </summary>
	/// <param name="userAgent">The UserAgent.</param>
	/// <returns><c>true</c> if its a Roblox Xbox App.</returns>
	bool IsRobloxXboxApp(string userAgent);
}
