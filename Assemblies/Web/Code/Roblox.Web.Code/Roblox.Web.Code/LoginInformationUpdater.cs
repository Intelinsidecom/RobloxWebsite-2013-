using System;
using System.Web;
using Roblox.Common;
using Roblox.Platform.Devices;
using Roblox.Platform.IpAddresses;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;
using Roblox.Web.Devices;

namespace Roblox.Web.Code;

/// <summary>
/// A class for updating login information on successful login event.
/// </summary>
public class LoginInformationUpdater : ILoginInformationUpdater
{
	private readonly IPresenceRegistrar _PresenceRegistrar;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly IAccountIpAddressRecorder _AccountIpAddressRecorder;

	/// <summary>
	/// Initializes an instance of <see cref="T:Roblox.Web.Code.LoginInformationUpdater" />.
	/// </summary>
	/// <param name="presenceRegistrar">The <see cref="T:Roblox.Platform.Presence.IPresenceRegistrar" />.</param>
	/// <param name="clientDeviceIdentifier">The <see cref="T:Roblox.Web.Devices.IClientDeviceIdentifier" />.</param>
	/// <param name="accountIpAddressRecorder">The <see cref="T:Roblox.Platform.IpAddresses.AccountIpAddressRecorder" />.</param>
	public LoginInformationUpdater(IPresenceRegistrar presenceRegistrar, IClientDeviceIdentifier clientDeviceIdentifier, IAccountIpAddressRecorder accountIpAddressRecorder)
	{
		_PresenceRegistrar = presenceRegistrar ?? throw new ArgumentNullException("presenceRegistrar");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_AccountIpAddressRecorder = accountIpAddressRecorder ?? throw new ArgumentNullException("accountIpAddressRecorder");
	}

	/// <inheritdoc />
	public void UpdateLoginInformation(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		string ipAddress = HttpContext.Current.GetOriginIP();
		string userAgent = HttpContext.Current?.Request.UserAgent;
		IPlatform platform = _ClientDeviceIdentifier.GetPlatformByUserAgent(userAgent);
		LoginHelper.UpdateLoginInformation(user, ipAddress, _PresenceRegistrar, platform?.PlatformName, _AccountIpAddressRecorder);
	}
}
