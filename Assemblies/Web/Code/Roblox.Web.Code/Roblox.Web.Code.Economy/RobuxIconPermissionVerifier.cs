using System;
using Roblox.Platform.AbTesting;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication;
using Roblox.Web.Code.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Code.Economy;

public class RobuxIconPermissionVerifier : IRobuxIconPermissionVerifier
{
	private readonly IFeatureEnabledValidator _NewRobuxIconEnabledValidator;

	private readonly IWebAuthenticationReader _WebAuthenticationReader;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly string _UserAgent;

	public RobuxIconPermissionVerifier(IWebAuthenticationReader webAuthenticationReader, IClientDeviceIdentifier clientDeviceIdentifier, string userAgent)
	{
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_NewRobuxIconEnabledValidator = new FeatureEnabledValidator(() => Settings.Default.IsNewRobuxIconForSoothsayerEnabled, null, () => Settings.Default.IsNewRobuxIconForGuestEnabled, () => Settings.Default.IsNewRobuxIconForAllEnabled, () => Settings.Default.NewRobuxIconRolloutPercentage);
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_UserAgent = userAgent;
	}

	/// <inheritdoc />
	public bool IsNewRobuxIconEnabled()
	{
		if (!IsNewRobuxIconFeatureEnabled())
		{
			return IsNewRobuxIconAvailableForUser();
		}
		return true;
	}

	private bool IsNewRobuxIconFeatureEnabled()
	{
		return _NewRobuxIconEnabledValidator.IsFeatureEnabled(_WebAuthenticationReader.GetAuthenticatedUser());
	}

	private bool IsNewRobuxIconAvailableForUser()
	{
		if (IsUserEnrolledInABTest())
		{
			return IsNewRobuxIconEnabledOnPlatform();
		}
		return false;
	}

	private bool IsUserEnrolledInABTest()
	{
		return (_WebAuthenticationReader.GetAuthenticatedUser().EnrollTranslated(Settings.Default.NewRobuxIconDesktopAbTestName) ?? 0) == Settings.Default.NewRobuxIconDesktopAbTestVariation;
	}

	private bool IsNewRobuxIconEnabledOnPlatform()
	{
		bool isEnabledInPlatform = true;
		if (_ClientDeviceIdentifier.IsGoogleStoreApp(_UserAgent))
		{
			isEnabledInPlatform = Settings.Default.IsNewRobuxIconEnabledForGoogle;
		}
		else if (_ClientDeviceIdentifier.IsRobloxIOSApp(_UserAgent))
		{
			isEnabledInPlatform = Settings.Default.IsNewRobuxIconEnabledForIOS;
		}
		else if (_ClientDeviceIdentifier.IsAmazonApp(_UserAgent))
		{
			isEnabledInPlatform = Settings.Default.IsNewRobuxIconEnabledForAmazon;
		}
		else if (_ClientDeviceIdentifier.IsRobloxWindowsApp(_UserAgent))
		{
			isEnabledInPlatform = Settings.Default.IsNewRobuxIconEnabledForUwp;
		}
		return isEnabledInPlatform;
	}
}
