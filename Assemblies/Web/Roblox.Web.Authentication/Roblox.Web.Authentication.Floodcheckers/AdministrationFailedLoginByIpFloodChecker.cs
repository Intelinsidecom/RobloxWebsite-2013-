using System;
using Roblox.FloodCheckers;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Floodcheckers;

/// <summary>
/// A flood checker to flood check failed logins by ip
/// </summary>
public class AdministrationFailedLoginByIpFloodChecker : FloodChecker
{
	private const int _IpAddressMaxLength = 45;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Authentication.Floodcheckers.FailedLoginByIpFloodChecker" />
	/// </summary>
	/// <param name="ipAddress">The ip address.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="ipAddress" /> is null, whitespace, or longer than <see cref="F:Roblox.Web.Authentication.Floodcheckers.AdministrationFailedLoginByIpFloodChecker._IpAddressMaxLength" /> characters.</exception>
	public AdministrationFailedLoginByIpFloodChecker(string ipAddress)
		: base($"AdministrationFailedLoginFloodChecker_IPAddress:{ipAddress?.Substring(0, Math.Min(45, ipAddress.Length))}", Settings.Default.AdministrationFailedLoginByIpFloodCheckLimit, Settings.Default.AdministrationFailedLoginByIpFloodCheckExpiry)
	{
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new ArgumentException(string.Format("{0} must not be null or whitespace.", "ipAddress"), "ipAddress");
		}
		if (ipAddress.Length > 45)
		{
			throw new ArgumentException(string.Format("{0} is longer than {1}. Is this a valid IP address?", "ipAddress", 45), "ipAddress");
		}
	}
}
